using AdminErpTemplate.Core.Interfaces;
using AdminErpTemplate.Core.Models;

namespace AdminErpTemplate.Infrastructure.Services;

public class DashboardService : IDashboardService
{
    public DashboardData GetDashboardData()
    {
        return new DashboardData
        {
            KpiCards = new List<DashboardWidget>
            {
                new DashboardWidget
                {
                    Id = "revenue",
                    Title = "Total Revenue",
                    Value = "$48,295",
                    Icon = "bi-currency-dollar",
                    Color = "primary",
                    Change = "+12.5%",
                    IsPositiveChange = true
                },
                new DashboardWidget
                {
                    Id = "orders",
                    Title = "Total Orders",
                    Value = "1,247",
                    Icon = "bi-cart-check",
                    Color = "success",
                    Change = "+8.2%",
                    IsPositiveChange = true
                },
                new DashboardWidget
                {
                    Id = "customers",
                    Title = "Total Customers",
                    Value = "3,842",
                    Icon = "bi-people",
                    Color = "info",
                    Change = "+5.1%",
                    IsPositiveChange = true
                },
                new DashboardWidget
                {
                    Id = "growth",
                    Title = "Growth Rate",
                    Value = "24.8%",
                    Icon = "bi-graph-up-arrow",
                    Color = "warning",
                    Change = "-2.4%",
                    IsPositiveChange = false
                }
            },
            Charts = new List<ChartData>
            {
                new ChartData
                {
                    Id = "revenue-chart",
                    Title = "Revenue Overview",
                    Type = "line",
                    Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                    DataSets = new List<DataSet>
                    {
                        new DataSet
                        {
                            Label = "Revenue",
                            Data = new List<double> { 4200, 3800, 5100, 4600, 5800, 6200, 5400, 6800, 7100, 6500, 7800, 8200 },
                            BorderColor = "rgba(99, 102, 241, 1)",
                            BackgroundColor = "rgba(99, 102, 241, 0.1)"
                        },
                        new DataSet
                        {
                            Label = "Expenses",
                            Data = new List<double> { 2800, 2600, 3200, 3000, 3400, 3800, 3200, 4000, 4200, 3800, 4400, 4600 },
                            BorderColor = "rgba(244, 63, 94, 1)",
                            BackgroundColor = "rgba(244, 63, 94, 0.1)"
                        }
                    }
                },
                new ChartData
                {
                    Id = "orders-chart",
                    Title = "Orders by Category",
                    Type = "doughnut",
                    Labels = new List<string> { "Electronics", "Clothing", "Food", "Books", "Other" },
                    DataSets = new List<DataSet>
                    {
                        new DataSet
                        {
                            Label = "Orders",
                            Data = new List<double> { 35, 25, 20, 12, 8 },
                            BackgroundColor = "['#6366f1','#22c55e','#f59e0b','#06b6d4','#f43f5e']"
                        }
                    }
                }
            },
            RecentActivities = new List<RecentActivity>
            {
                new RecentActivity
                {
                    Id = "a1",
                    Title = "New order placed",
                    Description = "Order #1247 placed by John Doe - $425.00",
                    Time = "2 min ago",
                    Icon = "bi-cart-plus",
                    Color = "primary"
                },
                new RecentActivity
                {
                    Id = "a2",
                    Title = "Payment received",
                    Description = "Payment of $1,250.00 from Acme Corp",
                    Time = "15 min ago",
                    Icon = "bi-credit-card-2-front",
                    Color = "success"
                },
                new RecentActivity
                {
                    Id = "a3",
                    Title = "New employee added",
                    Description = "Sarah Johnson joined Engineering team",
                    Time = "1 hour ago",
                    Icon = "bi-person-plus",
                    Color = "info"
                },
                new RecentActivity
                {
                    Id = "a4",
                    Title = "Invoice overdue",
                    Description = "Invoice #892 for $3,200 is 5 days overdue",
                    Time = "2 hours ago",
                    Icon = "bi-exclamation-triangle",
                    Color = "warning"
                },
                new RecentActivity
                {
                    Id = "a5",
                    Title = "Server alert",
                    Description = "CPU usage exceeded 90% on production server",
                    Time = "3 hours ago",
                    Icon = "bi-hdd-rack",
                    Color = "danger"
                },
                new RecentActivity
                {
                    Id = "a6",
                    Title = "Project milestone",
                    Description = "Project Alpha reached Phase 3 completion",
                    Time = "5 hours ago",
                    Icon = "bi-flag",
                    Color = "success"
                }
            },
            TopProducts = new List<TopProduct>
            {
                new TopProduct { Name = "Wireless Headphones Pro", Category = "Electronics", Price = 129.99m, Sold = 342, Revenue = 44456.58m, Status = "In Stock" },
                new TopProduct { Name = "Smart Watch Ultra", Category = "Electronics", Price = 299.99m, Sold = 218, Revenue = 65397.82m, Status = "In Stock" },
                new TopProduct { Name = "Ergonomic Office Chair", Category = "Furniture", Price = 449.99m, Sold = 156, Revenue = 70198.44m, Status = "Low Stock" },
                new TopProduct { Name = "Organic Coffee Beans 1kg", Category = "Food", Price = 24.99m, Sold = 892, Revenue = 22291.08m, Status = "In Stock" },
                new TopProduct { Name = "Laptop Stand Adjustable", Category = "Accessories", Price = 59.99m, Sold = 567, Revenue = 33994.33m, Status = "In Stock" },
                new TopProduct { Name = "Mechanical Keyboard RGB", Category = "Electronics", Price = 149.99m, Sold = 289, Revenue = 43347.11m, Status = "Out of Stock" }
            }
        };
    }
}
