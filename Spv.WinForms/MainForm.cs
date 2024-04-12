using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Spv.WinForms.Models;
using System.Data;
using System.Reflection;
using System.Text.Json;

namespace Spv.WinForms;

public partial class MainForm : Form
{
    private readonly ILogger<MainForm> logger;
    private readonly IServiceProvider serviceProvider;
    private readonly List<h248konz> h248konzList;

    public MainForm(ILogger<MainForm> logger, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this.logger = logger;
        this.serviceProvider = serviceProvider;



        button1.Click += Button1_Click;
        var json = System.IO.File.ReadAllText("./h248konz.json");
        h248konzList = JsonSerializer.Deserialize<List<h248konz>>(json);
    }

    private void Button1_Click(object? sender, EventArgs e)
    {
        logger.LogInformation(nameof(Button1_Click));
        bindingSource1.DataSource = ToDataTable(h248konzList);
        dataGridView1.DataSource = bindingSource1;

        var startOfThisYear = new DateTime(DateTime.Now.Year, 1, 1);
        
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetService<SpvContext>();
        if (context == null) return;
        var queryable = from order in context.Orders
                        join orderDetail in context.OrdersDetails on order.OrderId equals orderDetail.Orderid
                        where
                            order.OrderDate>= startOfThisYear
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
}
