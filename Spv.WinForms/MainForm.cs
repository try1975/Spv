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
    private readonly List<h248konz>? h248List;
    private readonly List<H264>? h264List = [];
    private readonly DataTable Details;

    public MainForm(ILogger<MainForm> logger, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this.logger = logger;
        this.serviceProvider = serviceProvider;



        button1.Click += Button1_Click;
        button2.Click += Button2_Click;
        bindingSource1.CurrentChanged += BindingSource1_CurrentChanged;
        bindingSource3.CurrentChanged += BindingSource3_CurrentChanged;
        tbTextFilter.TextChanged += TbTextFilter_TextChanged;

        Details = ToDataTable(h264List);


        //var path = "./h264.json";
        //var json = string.Empty;
        //if (Path.Exists(path))
        //{
        //    json = System.IO.File.ReadAllText(path);
        //    h264List = JsonSerializer.Deserialize<List<H264>>(json);
        //}
        //path = "./h248konz.json";
        //if (Path.Exists(path))
        //{
        //    json = System.IO.File.ReadAllText(path);
        //        h248List = JsonSerializer.Deserialize<List<h248konz>>(json);
        //}
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
        row[nameof(H264.ValveType)] = item.ValveType;
        row[nameof(H264.Pressure)] = item.Pressure;
        row[nameof(H264.Vessel)] = item.Vessel;
        row[nameof(H264.Time)] = item.Time;
        row[nameof(H264.Rate)] = item.Rate;
        row[nameof(H264.Bemerkungen)] = item.Bemerkungen;
        row[nameof(H264.ModifiedBy)] = item.ModifiedBy;
        Details.Rows.Add(row);

        bindingSource4.DataSource = Details;
        dataGridView4.DataSource = null;
        dataGridView4.DataSource = bindingSource4;
    }

    private void BindingSource3_CurrentChanged(object? sender, EventArgs e)
    {

    }

    private void BindingSource1_CurrentChanged(object? sender, EventArgs e)
    {
        //throw new NotImplementedException();
    }

    private void Button1_Click(object? sender, EventArgs e)
    {
        logger.LogInformation(nameof(Button1_Click));
        if (h248List != null)
        {
            bindingSource1.DataSource = ToDataTable(h248List);
            dataGridView1.DataSource = bindingSource1;
        }
        if (h264List != null)
        {
            bindingSource3.DataSource = ToDataTable(h264List);
            dataGridView3.DataSource = bindingSource3;
        }

        var startOfThisYear = new DateTime(DateTime.Now.Year, 1, 1);

        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetService<SpvContext>();
        if (context == null) return;
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
