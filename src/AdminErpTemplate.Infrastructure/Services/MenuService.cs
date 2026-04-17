using AdminErpTemplate.Core.Interfaces;
using AdminErpTemplate.Core.Models;

namespace AdminErpTemplate.Infrastructure.Services;

public class MenuService : IMenuService
{
    public List<MenuItem> GetSidebarMenu()
    {
        return new List<MenuItem>
        {
            new MenuItem
            {
                Id = "dashboard",
                Title = "Dashboard",
                Icon = "bi-speedometer2",
                Url = "/Dashboard",
                Section = "Main",
                Order = 1
            },
            new MenuItem
            {
                Id = "ecommerce",
                Title = "E-Commerce",
                Icon = "bi-cart4",
                Section = "Applications",
                Order = 2,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "products", Title = "Products", Icon = "bi-box", Url = "/Commerce/Products" },
                    new MenuItem { Id = "orders", Title = "Orders", Icon = "bi-receipt", Url = "/Commerce/Orders", Badge = "12", BadgeColor = "danger" },
                    new MenuItem { Id = "customers", Title = "Customers", Icon = "bi-people", Url = "/Commerce/Customers" },
                    new MenuItem { Id = "inventory", Title = "Inventory", Icon = "bi-boxes", Url = "/Commerce/Inventory" }
                }
            },
            new MenuItem
            {
                Id = "hrm",
                Title = "HRM",
                Icon = "bi-person-badge",
                Section = "Applications",
                Order = 3,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "employees", Title = "Employees", Icon = "bi-person-lines-fill", Url = "/Dashboard/Employees" },
                    new MenuItem { Id = "departments", Title = "Departments", Icon = "bi-building", Url = "/Dashboard/Departments" },
                    new MenuItem { Id = "attendance", Title = "Attendance", Icon = "bi-calendar-check", Url = "/Dashboard/Attendance" },
                    new MenuItem { Id = "payroll", Title = "Payroll", Icon = "bi-cash-stack", Url = "/Dashboard/Payroll" }
                }
            },
            new MenuItem
            {
                Id = "accounting",
                Title = "Accounting",
                Icon = "bi-calculator",
                Section = "Applications",
                Order = 4,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "invoices", Title = "Invoices", Icon = "bi-file-earmark-text", Url = "/Dashboard/Invoices", Badge = "5", BadgeColor = "warning" },
                    new MenuItem { Id = "expenses", Title = "Expenses", Icon = "bi-credit-card", Url = "/Dashboard/Expenses" },
                    new MenuItem { Id = "reports", Title = "Reports", Icon = "bi-graph-up", Url = "/Dashboard/Reports" },
                    new MenuItem
                    {
                        Id = "tax",
                        Title = "Tax Management",
                        Icon = "bi-percent",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "tax-settings", Title = "Tax Settings", Url = "/Dashboard/TaxSettings" },
                            new MenuItem { Id = "tax-reports", Title = "Tax Reports", Url = "/Dashboard/TaxReports" }
                        }
                    }
                }
            },
            new MenuItem
            {
                Id = "crm",
                Title = "CRM",
                Icon = "bi-headset",
                Section = "Applications",
                Order = 5,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "leads", Title = "Leads", Icon = "bi-funnel", Url = "/Dashboard/Leads" },
                    new MenuItem { Id = "deals", Title = "Deals", Icon = "bi-handshake", Url = "/Dashboard/Deals" },
                    new MenuItem { Id = "contacts", Title = "Contacts", Icon = "bi-person-rolodex", Url = "/Dashboard/Contacts" }
                }
            },
            new MenuItem
            {
                Id = "project",
                Title = "Project Management",
                Icon = "bi-kanban",
                Section = "Applications",
                Order = 6,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "projects", Title = "Projects", Icon = "bi-folder2-open", Url = "/Dashboard/Projects" },
                    new MenuItem { Id = "tasks", Title = "Tasks", Icon = "bi-list-check", Url = "/Dashboard/Tasks" },
                    new MenuItem { Id = "timeline", Title = "Timeline", Icon = "bi-calendar3", Url = "/Dashboard/Timeline" }
                }
            },
            new MenuItem
            {
                Id = "ui-elements",
                Title = "UI Elements",
                Icon = "bi-palette",
                Section = "Components",
                Order = 7,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "buttons", Title = "Buttons", Icon = "bi-hand-index", Url = "/Dashboard/Buttons" },
                    new MenuItem { Id = "cards", Title = "Cards", Icon = "bi-card-heading", Url = "/Dashboard/Cards" },
                    new MenuItem { Id = "modals", Title = "Modals", Icon = "bi-window-stack", Url = "/Dashboard/Modals" },
                    new MenuItem { Id = "tables", Title = "Tables", Icon = "bi-table", Url = "/Dashboard/Tables" },
                    new MenuItem { Id = "forms", Title = "Forms", Icon = "bi-input-cursor-text", Url = "/Dashboard/Forms" },
                    new MenuItem { Id = "charts", Title = "Charts", Icon = "bi-bar-chart-line", Url = "/Dashboard/Charts" }
                }
            },
            new MenuItem
            {
                Id = "pages",
                Title = "Pages",
                Icon = "bi-file-earmark",
                Section = "Components",
                Order = 8,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "login", Title = "Login", Icon = "bi-box-arrow-in-right", Url = "/Account/Login" },
                    new MenuItem { Id = "register", Title = "Register", Icon = "bi-person-plus", Url = "/Account/Register" },
                    new MenuItem { Id = "error-404", Title = "Error 404", Icon = "bi-exclamation-triangle", Url = "/Dashboard/Error404" },
                    new MenuItem { Id = "error-500", Title = "Error 500", Icon = "bi-exclamation-octagon", Url = "/Dashboard/Error500" },
                    new MenuItem { Id = "profile", Title = "Profile", Icon = "bi-person-circle", Url = "/Dashboard/Profile" }
                }
            },
            new MenuItem
            {
                Id = "settings",
                Title = "Settings",
                Icon = "bi-gear",
                Section = "System",
                Order = 9,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "general", Title = "General", Icon = "bi-sliders", Url = "/Dashboard/Settings" },
                    new MenuItem { Id = "users", Title = "Users & Roles", Icon = "bi-shield-lock", Url = "/Dashboard/Users" },
                    new MenuItem { Id = "notifications-settings", Title = "Notifications", Icon = "bi-bell", Url = "/Dashboard/NotificationSettings" }
                }
            }
        };
    }

    public List<MenuItem> GetHorizontalMenu()
    {
        return new List<MenuItem>
        {
            new MenuItem
            {
                Id = "mega-dashboard",
                Title = "Dashboard",
                Icon = "bi-speedometer2",
                Url = "/Dashboard",
                Order = 1
            },
            new MenuItem
            {
                Id = "mega-apps",
                Title = "Applications",
                Icon = "bi-grid",
                Order = 2,
                Children = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Id = "mega-ecommerce",
                        Title = "E-Commerce",
                        Icon = "bi-cart4",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-products", Title = "Products", Url = "/Dashboard/Products" },
                            new MenuItem { Id = "m-orders", Title = "Orders", Url = "/Dashboard/Orders" },
                            new MenuItem { Id = "m-customers", Title = "Customers", Url = "/Dashboard/Customers" },
                            new MenuItem { Id = "m-inventory", Title = "Inventory", Url = "/Dashboard/Inventory" }
                        }
                    },
                    new MenuItem
                    {
                        Id = "mega-hrm",
                        Title = "HRM",
                        Icon = "bi-person-badge",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-employees", Title = "Employees", Url = "/Dashboard/Employees" },
                            new MenuItem { Id = "m-departments", Title = "Departments", Url = "/Dashboard/Departments" },
                            new MenuItem { Id = "m-attendance", Title = "Attendance", Url = "/Dashboard/Attendance" },
                            new MenuItem { Id = "m-payroll", Title = "Payroll", Url = "/Dashboard/Payroll" }
                        }
                    },
                    new MenuItem
                    {
                        Id = "mega-accounting",
                        Title = "Accounting",
                        Icon = "bi-calculator",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-invoices", Title = "Invoices", Url = "/Dashboard/Invoices" },
                            new MenuItem { Id = "m-expenses", Title = "Expenses", Url = "/Dashboard/Expenses" },
                            new MenuItem { Id = "m-reports", Title = "Reports", Url = "/Dashboard/Reports" }
                        }
                    },
                    new MenuItem
                    {
                        Id = "mega-crm",
                        Title = "CRM",
                        Icon = "bi-headset",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-leads", Title = "Leads", Url = "/Dashboard/Leads" },
                            new MenuItem { Id = "m-deals", Title = "Deals", Url = "/Dashboard/Deals" },
                            new MenuItem { Id = "m-contacts", Title = "Contacts", Url = "/Dashboard/Contacts" }
                        }
                    }
                }
            },
            new MenuItem
            {
                Id = "mega-project",
                Title = "Projects",
                Icon = "bi-kanban",
                Order = 3,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "m-projects", Title = "All Projects", Url = "/Dashboard/Projects" },
                    new MenuItem { Id = "m-tasks", Title = "Tasks", Url = "/Dashboard/Tasks" },
                    new MenuItem { Id = "m-timeline", Title = "Timeline", Url = "/Dashboard/Timeline" }
                }
            },
            new MenuItem
            {
                Id = "mega-components",
                Title = "Components",
                Icon = "bi-palette",
                Order = 4,
                Children = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Id = "mega-ui",
                        Title = "UI Elements",
                        Icon = "bi-brush",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-buttons", Title = "Buttons", Url = "/Dashboard/Buttons" },
                            new MenuItem { Id = "m-cards", Title = "Cards", Url = "/Dashboard/Cards" },
                            new MenuItem { Id = "m-modals", Title = "Modals", Url = "/Dashboard/Modals" },
                            new MenuItem { Id = "m-tables", Title = "Tables", Url = "/Dashboard/Tables" }
                        }
                    },
                    new MenuItem
                    {
                        Id = "mega-forms-charts",
                        Title = "Forms & Charts",
                        Icon = "bi-bar-chart",
                        Children = new List<MenuItem>
                        {
                            new MenuItem { Id = "m-forms", Title = "Forms", Url = "/Dashboard/Forms" },
                            new MenuItem { Id = "m-charts", Title = "Charts", Url = "/Dashboard/Charts" }
                        }
                    }
                }
            },
            new MenuItem
            {
                Id = "mega-pages",
                Title = "Pages",
                Icon = "bi-file-earmark",
                Order = 5,
                Children = new List<MenuItem>
                {
                    new MenuItem { Id = "m-profile", Title = "Profile", Url = "/Dashboard/Profile" },
                    new MenuItem { Id = "m-settings", Title = "Settings", Url = "/Dashboard/Settings" },
                    new MenuItem { Id = "m-login", Title = "Login", Url = "/Account/Login" },
                    new MenuItem { Id = "m-register", Title = "Register", Url = "/Account/Register" }
                }
            }
        };
    }

    public FooterConfig GetFooterConfig()
    {
        return new FooterConfig
        {
            CompanyName = "AdminERP",
            Copyright = $"© {DateTime.Now.Year} AdminERP. All rights reserved.",
            Description = "A unified advanced ERP admin template built with ASP.NET Core, designed to be API-driven and compatible with any frontend framework.",
            Columns = new List<FooterColumn>
            {
                new FooterColumn
                {
                    Title = "Product",
                    Links = new List<FooterLink>
                    {
                        new FooterLink { Title = "Features", Url = "#" },
                        new FooterLink { Title = "Pricing", Url = "#" },
                        new FooterLink { Title = "Documentation", Url = "#" },
                        new FooterLink { Title = "Changelog", Url = "#" },
                        new FooterLink { Title = "API Reference", Url = "/swagger" }
                    }
                },
                new FooterColumn
                {
                    Title = "Company",
                    Links = new List<FooterLink>
                    {
                        new FooterLink { Title = "About Us", Url = "#" },
                        new FooterLink { Title = "Careers", Url = "#" },
                        new FooterLink { Title = "Blog", Url = "#" },
                        new FooterLink { Title = "Press", Url = "#" }
                    }
                },
                new FooterColumn
                {
                    Title = "Resources",
                    Links = new List<FooterLink>
                    {
                        new FooterLink { Title = "Help Center", Url = "#" },
                        new FooterLink { Title = "Community", Url = "#" },
                        new FooterLink { Title = "Tutorials", Url = "#" },
                        new FooterLink { Title = "Status", Url = "#" }
                    }
                },
                new FooterColumn
                {
                    Title = "Legal",
                    Links = new List<FooterLink>
                    {
                        new FooterLink { Title = "Privacy Policy", Url = "#" },
                        new FooterLink { Title = "Terms of Service", Url = "#" },
                        new FooterLink { Title = "Cookie Policy", Url = "#" },
                        new FooterLink { Title = "GDPR", Url = "#" }
                    }
                }
            },
            SocialLinks = new List<SocialLink>
            {
                new SocialLink { Platform = "Twitter", Url = "#", Icon = "bi-twitter-x" },
                new SocialLink { Platform = "GitHub", Url = "#", Icon = "bi-github" },
                new SocialLink { Platform = "LinkedIn", Url = "#", Icon = "bi-linkedin" },
                new SocialLink { Platform = "YouTube", Url = "#", Icon = "bi-youtube" },
                new SocialLink { Platform = "Discord", Url = "#", Icon = "bi-discord" }
            }
        };
    }
}
