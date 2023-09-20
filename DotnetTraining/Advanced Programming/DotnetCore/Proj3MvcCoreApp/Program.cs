using Microsoft.EntityFrameworkCore;
using Proj3MvcCoreApp.Models;
using System.Web.Mvc;

namespace Proj3MvcCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ExpenseDbContext>((context)=> {
                context.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True; TrustServerCertificate=True");
            });
            builder.Services.AddTransient<IExpenseManager, ExpenseManager>();
            builder.Services.AddMvc();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            
            app.UseStaticFiles();
            const string pattern = "{controller}/{action}/{id}";

            app.MapControllerRoute("default", pattern, new { controller = "Expense", action = "Index", id = UrlParameter.Optional});

            app.Run();
        }
    }
}