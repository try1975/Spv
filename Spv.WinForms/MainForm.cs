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
    private long maxId = 0;

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
        maxId = (long)context.OrdersDetails.Max(x => x.Id);

        tabPage2.Enter += TabPage2_Enter;
        button2.Click += BtnAdd_Click;
        btnSave.Click += BtnSave_Click;
        btnClear.Click += BtnClear_Click;
        tbTextFilter.TextChanged += TbTextFilter_TextChanged;
        dataGridView2.UserDeletingRow += DataGridView2_UserDeletingRow;
        dataGridView3.CellDoubleClick += DataGridView3_CellDoubleClick;

        // contains order details
        Details = ToDataTable(new List<NewOrderDetail>());
        SetDetailsColumns();

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
        if (await CheckData() == false) return;
        using var transaction = await context.Database.BeginTransactionAsync();
        try
        {
            var ordernb = tbOrderNb.Text; //context.Orders.Select(x => int.Parse(x.OrderNb)).ToList().Max() + 1;
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
            MessageBox.Show($"Заказ сохранен в базу");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            MessageBox.Show(ex.ToString());
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        H264 item = null;
        if (bindingSource3.Current != null)
        {
            var current = (DataRowView)bindingSource3.Current;
            item = ToDto<H264>(current);
        }
        if (item == null) return;
        var row = Details.NewRow();
        //row[nameof(NewOrderDetail.Serialnb)] = rnd.Next(1_000_000, 2_000_000).ToString();

        
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
                row[nameof(NewOrderDetail.p1)] = p1 * 100_000;
            }
            if (pressures.Length >= 2 && float.TryParse(pressures[1].Trim(), out var p2))
            {
                row[nameof(NewOrderDetail.p2)] = p2 * 100_000;
            }
        }
        row[nameof(NewOrderDetail.innerrate)] = item.Rate / 3600.00;
        row[nameof(NewOrderDetail.innertime)] = item.Time * 60;
        row[nameof(NewOrderDetail.outerrate)] = -1;
        row[nameof(NewOrderDetail.outertime)] = -1;
        row[nameof(NewOrderDetail.pressure)] = -1;
        row[nameof(NewOrderDetail.vessel)] = item.Vessel;
        row[nameof(NewOrderDetail.ValueInner)] = -1;
        row[nameof(NewOrderDetail.ValueOuter)] = -1;
        maxId++;
        row[nameof(NewOrderDetail.Id)] = maxId;
        Details.Rows.Add(row);

        var npp = 0;
        foreach (var r in Details.Rows)
        {
            npp++;
            (r as DataRow)[nameof(NewOrderDetail.npp)] = npp;
        }

        bindingSource4.DataSource = Details;
        dataGridView4.DataSource = null;
        dataGridView4.DataSource = bindingSource4;
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        tbOrderNb.Clear();
        if (Details is not null)
        {
            Details.Clear();
        }
    }

    private void DataGridView3_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        BtnAdd_Click(sender, e);
    }

    private async void DataGridView2_UserDeletingRow(object? sender, DataGridViewRowCancelEventArgs e)
    {
        //e.Row
        VOrder item = null;
        if (bindingSource2.Current != null)
        {
            var current = (DataRowView)bindingSource2.Current;
            item = ToDto<VOrder>(current);
        }
        if (item == null) return;
        const string question = @"You really want to delete selected records?";
        const string caption = @"Delete warning";
        if (MessageBox.Show(question, caption, MessageBoxButtons.OKCancel) != DialogResult.OK) return;
        var queryable = from orderDetail in context.OrdersDetails 
                        join meassure in context.Meassures on orderDetail.Serialid equals meassure.SerialId
                        where
                            orderDetail.Serialid == item.Serialid
                        select new
                        {
                            Serialid = orderDetail.Serialid,
                            TestId = meassure.TestId
                        };
        var order_position = await queryable.FirstAsync();
        if (context.MeassuredVals.Count(x => order_position.TestId==x.TestId)>0)
        {
            MessageBox.Show("Позиция не может быть удалена");
            return;
        }
        using var transaction = await context.Database.BeginTransactionAsync();
        try
        {

            context.Remove(context.Meassures.Single(a => a.TestId == order_position.TestId));
            context.Remove(context.OrdersDetails.Single(a => a.Serialid == order_position.Serialid));
            var position_count= context.OrdersDetails.Count(x => item.OrderId == x.Orderid);
            if (position_count == 1)
            {
                context.Remove(context.Orders.Single(x => x.OrderId == item.OrderId));
            }
            context.SaveChanges();
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            MessageBox.Show(ex.ToString());
        }
    }

    private void TabPage2_Enter(object? sender, EventArgs e)
    {
        logger.LogInformation(nameof(TabPage2_Enter));

        var startDate = DateTime.Today.AddDays(-730);

        var queryable = from order in context.VOrders
                            //join orderDetail in context.OrdersDetails on order.OrderId equals orderDetail.Orderid
                        where
                            order.OrderDate >= startDate
                        orderby order.OrderDate descending
                        select order;
        var list = queryable
            .AsNoTracking()
            .ToList();
        bindingSource2.DataSource = ToDataTable(list);
        dataGridView2.DataSource = bindingSource2;
    }

    private async Task<bool> CheckData()
    {
        if (string.IsNullOrEmpty(tbOrderNb.Text))
        {
            MessageBox.Show("Укажите номер заказа");
            return false;
        }
        var order = await context.Orders.FirstOrDefaultAsync(x => x.OrderNb == tbOrderNb.Text);
        if (order != null)
        {
            MessageBox.Show($"Заказ номер {tbOrderNb.Text} уже есть");
            return false;
        }
        if (Details.Rows.Count == 0)
        {
            MessageBox.Show($"В заказе нет позиций");
            return false;
        }
        return true;
    }

    private void SetDetailsColumns()
    {
        if (Details is null) return;
        var column = Details.Columns[nameof(NewOrderDetail.ValueInner)];
        if (column is not null)
        {
            column.ColumnMapping = MappingType.Hidden;
        }
        column = Details.Columns[nameof(NewOrderDetail.ValueOuter)];
        if (column is not null)
        {
            column.ColumnMapping = MappingType.Hidden;
        }
    }

    private void TbTextFilter_TextChanged(object? sender, EventArgs e)
    {
        bindingSource3.Filter = GetFilterString();
        bindingSource3.ResetBindings(false);
    }

    private List<NewOrderDetail> MapDetails()
    {
        List<NewOrderDetail> list = [];
        foreach (var item in Details.Rows)
        {
            if (item is not DataRow row) continue;
            list.Add(new NewOrderDetail
            {
                Serialnb = row[nameof(NewOrderDetail.Serialnb)].ToString() ?? string.Empty,
                ValveType = row[nameof(NewOrderDetail.ValveType)].ToString() ?? string.Empty,
                Drawing = row[nameof(NewOrderDetail.Drawing)].ToString() ?? string.Empty,
                TypeParam = (int)row[nameof(NewOrderDetail.TypeParam)],
                MatNb = row[nameof(NewOrderDetail.MatNb)].ToString() ?? string.Empty,
                MatDesc = row[nameof(NewOrderDetail.MatDesc)].ToString() ?? string.Empty,
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
