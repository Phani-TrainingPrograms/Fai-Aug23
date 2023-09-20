using AspNetCore.Unobtrusive.Ajax;
using Microsoft.EntityFrameworkCore;
using Proj3MvcCoreRecap.Models;

namespace Proj3MvcCoreRecap
{
    //The place from where the Program runs....
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateBuilder will build a min ASP.NET Web Application. It takes the command line args if required for the Application..
            var builder = WebApplication.CreateBuilder(args);
            //U can add middlewares for UR app like authentication, db server, asp.net pipelines: webforms, mvc and web api..
            
            builder.Services.AddDbContext<MyDbContext>((context) => {
                context.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True; TrustServerCertificate=True");
            });
            
            builder.Services.AddTransient<IDBComponent, DBComponent>();
            builder.Services.AddMvc();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseUnobtrusiveAjax();

            /**********Routes for UR URL Patterns*************************/
            app.MapControllerRoute("default", "{controller=Employee}/{action=Index}/{id?}");
            //U can add as many no of routes U want for UR URL Patterns...
            //Once the App Runs, U dont have controll over the settings for UR Application. 
            app.Run();
        }
    }
}