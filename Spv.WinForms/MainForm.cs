using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Spv.WinForms.Models;
using Spv.WinForms.Models.Dict;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace Spv.WinForms;

public partial class MainForm : Form
{
    private readonly ILogger<MainForm> logger;
    private readonly IServiceProvider serviceProvider;
    private readonly IServiceScope scope;
    private readonly List<h248konz>? h248List;
    private readonly List<H264>? h264List = [];
    private readonly DataTable Details;
    private readonly SpvContext context;
    private readonly int userid;
    private readonly int ordertype;
    private readonly int orderstateid;
    private readonly Random rnd = new();

    public MainForm(ILogger<MainForm> logger, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this.logger = logger;
        this.serviceProvider = serviceProvider;
        scope = serviceProvider.CreateScope();
        context = scope.ServiceProvider.GetRequiredService<SpvContext>();

        userid = 2;
        ordertype = 50;
        orderstateid = 0;

        button1.Click += Button1_Click;
        button2.Click += Button2_Click;
        btnSave.Click += BtnSave_Click;
        tbTextFilter.TextChanged += TbTextFilter_TextChanged;

        // contains order details
        Details = ToDataTable(new List<NewOrderDetail>());

        var config = new CsvConfiguration(CultureInfo.GetCultureInfo("ru-RU"))
        {
            HasHeaderRecord = true,

        };
        var path = "./h264.csv";
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, config))
        {
            //csv.Context.RegisterClassMap<NavigationRecordReadMap>();
            h264List = csv.GetRecords<H264>().ToList();
        }
        bindingSource3.DataSource = ToDataTable(h264List);
        dataGridView3.DataSource = bindingSource3;
    }

    private async void BtnSave_Click(object? sender, EventArgs e)
    {
        using var transaction = await context.Database.BeginTransactionAsync();
        try
        {
            var ordernb = context.Orders.Select(x => int.Parse(x.OrderNb)).ToList().Max() + 1;
            OutputParameter<Guid?> orderid = new();
            await context.Procedures.OrderAddAsync(ordernb.ToString(), ordertype, orderstateid, userid, orderid);

            List<NewOrderDetail> rows = MapDetails();
            foreach (var newOrderDetail in rows)
            {
                await context.Procedures.OrderDetailAddAsync(
                    orderid.Value,
                    newOrderDetail.MatNb,
                    newOrderDetail.MatDesc,
                    newOrderDetail.ValveType,
                    newOrderDetail.Drawing,
                    newOrderDetail.p1,
                    newOrderDetail.p2,
                    newOrderDetail.innerrate,
                    newOrderDetail.innertime,
                    newOrderDetail.outerrate,
                    newOrderDetail.outertime,
                    userid,
                    newOrderDetail.Serialnb,
                    newOrderDetail.TypeParam,
                    newOrderDetail.pressure,
                    newOrderDetail.vessel,
                    newOrderDetail.Id,
                    newOrderDetail.ValueInner,
                    newOrderDetail.ValueOuter
                    );
            }
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            MessageBox.Show(ex.ToString());
        }
    }

    private List<NewOrderDetail> MapDetails()
    {
        List<NewOrderDetail> list = [];
        foreach (var item in Details.Rows)
        {
            if (item is not DataRow row) continue;
            list.Add(new NewOrderDetail
            {
                Serialnb = row[nameof(NewOrderDetail.Serialnb)].ToString(),
                ValveType = row[nameof(NewOrderDetail.ValveType)].ToString(),
                Drawing = row[nameof(NewOrderDetail.Drawing)].ToString(),
                TypeParam = (int)row[nameof(NewOrderDetail.TypeParam)],
                MatNb = row[nameof(NewOrderDetail.MatNb)].ToString(),
                MatDesc = row[nameof(NewOrderDetail.MatDesc)].ToString(),
                Id = (long)row[nameof(NewOrderDetail.Id)],
                p1 = (float)row[nameof(NewOrderDetail.p1)],
                p2 = (float)row[nameof(NewOrderDetail.p2)],
                innerrate = (double)row[nameof(NewOrderDetail.innerrate)],
                innertime = (double)row[nameof(NewOrderDetail.innertime)],
                outerrate = (double)row[nameof(NewOrderDetail.outerrate)],
                outertime = (double)row[nameof(NewOrderDetail.outertime)],
                pressure = (double)row[nameof(NewOrderDetail.pressure)],
                vessel = (double)row[nameof(NewOrderDetail.vessel)],
                ValueInner = (double)row[nameof(NewOrderDetail.ValueInner)],
                ValueOuter = (double)row[nameof(NewOrderDetail.ValueOuter)],
            });
        }
        return list;
    }

    private void Button2_Click(object? sender, EventArgs e)
    {
        H264 item = null;
        if (bindingSource3.Current != null)
        {
            var current = (DataRowView)bindingSource3.Current;
            item = ToDto<H264>(current);
        }
        if (item == null) return;
        var row = Details.NewRow();
        row[nameof(NewOrderDetail.Serialnb)] = rnd.Next(20_000, 30_000).ToString();
        row[nameof(NewOrderDetail.MatNb)] = rnd.Next(5_000, 10_000).ToString();
        row[nameof(NewOrderDetail.ValveType)] = item.ValveType;
        row[nameof(NewOrderDetail.Drawing)] = string.Empty;
        row[nameof(NewOrderDetail.TypeParam)] = 0;
        row[nameof(NewOrderDetail.MatDesc)] = $"Клапан {item.ValveType}";
        row[nameof(NewOrderDetail.p1)] = -1;
        row[nameof(NewOrderDetail.p2)] = -1;
        var pressures = item.Pressure.Split('/');
        if (pressures != null)
        {
            row[nameof(NewOrderDetail.p1)] = 0;
            row[nameof(NewOrderDetail.p2)] = 0;
            if (pressures.Length >= 1 && float.TryParse(pressures[0].Trim(), out var p1))
            {
                row[nameof(NewOrderDetail.p1)] = p1;
            }
            if (pressures.Length >= 2 && float.TryParse(pressures[1].Trim(), out var p2))
            {
                row[nameof(NewOrderDetail.p2)] = p2;
            }
        }
        row[nameof(NewOrderDetail.innerrate)] = item.Rate;
        row[nameof(NewOrderDetail.innertime)] = item.Time;
        row[nameof(NewOrderDetail.outerrate)] = -1;
        row[nameof(NewOrderDetail.outertime)] = -1;
        row[nameof(NewOrderDetail.pressure)] = -1;
        row[nameof(NewOrderDetail.vessel)] = item.Vessel;
        row[nameof(NewOrderDetail.ValueInner)] = -1;
        row[nameof(NewOrderDetail.ValueOuter)] = -1;
        row[nameof(NewOrderDetail.Id)] = context.OrdersDetails.Max(x => x.Id) + 1;
        Details.Rows.Add(row);

        bindingSource4.DataSource = Details;
        dataGridView4.DataSource = null;
        dataGridView4.DataSource = bindingSource4;
    }


    private void Button1_Click(object? sender, EventArgs e)
    {
        logger.LogInformation(nameof(Button1_Click));

        var startOfThisYear = new DateTime(DateTime.Now.Year, 1, 1);

        var queryable = from order in context.VOrders
                            //join orderDetail in context.OrdersDetails on order.OrderId equals orderDetail.Orderid
                        where
                            order.OrderDate >= startOfThisYear
                        orderby order.OrderDate
                        select order;
        var list = queryable
            .AsNoTracking()
            .ToList();
        bindingSource2.DataSource = ToDataTable(list);
        dataGridView2.DataSource = bindingSource2;
    }

    private void TbTextFilter_TextChanged(object? sender, EventArgs e)
    {
        DgvItems_FilterStringChanged(sender, e);
    }

    private void DgvItems_FilterStringChanged(object? sender, EventArgs e)
    {
        bindingSource3.Filter = GetFilterString();
        bindingSource3.ResetBindings(false);
    }

    private string GetFilterString()
    {
        var value = tbTextFilter.Text.Trim();
        var valveType = nameof(H264.ValveType);
        var filterString = $"([{valveType}] LIKE '%{value}%')";
        return filterString;
    }

    private DataTable ToDataTable<T>(IEnumerable<T> items)
    {
        logger.LogDebug($"ToDataTable start {typeof(T).Name}");
        var dataTable = new DataTable(typeof(T).Name);

        var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var prop in props)
        {
            var type = prop.PropertyType.IsGenericType &&
                       prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)
                ? Nullable.GetUnderlyingType(prop.PropertyType)
                : prop.PropertyType;
            if (type != null) dataTable.Columns.Add(prop.Name, type);
            logger.LogDebug($"prop.Name {prop.Name}");
        }
        foreach (var item in items)
        {
            var values = new object[props.Length];
            for (var i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(item, null);
                logger.LogDebug($"values[i] {props[i].GetValue(item, null)}");
            }
            dataTable.Rows.Add(values);
        }
        return dataTable;
    }

    private static T ToDto<T>(DataRowView data)
    {
        var result = (T)Activator.CreateInstance(typeof(T), null);
        var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        for (var i = 0; i < props.Length; i++)
        {
            var value = data.Row.ItemArray[i];
            if (value != DBNull.Value)
                props[i].SetValue(result, data.Row.ItemArray[i]);
        }
        return result;
    }
}
