using Microsoft.EntityFrameworkCore;
using Proj4WebApiCore.Models;

namespace Proj4WebApiCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string policy = "mypolicy";

            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("conString");
            builder.Services.AddDbContext<ExampleDbContext>((options) =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddDbContext<EmpDbContext>((options) =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddTransient<IEmployeeData, EmployeeData>();
            builder.Services.AddCors((options) =>
            {
                options.AddPolicy(policy, options =>
                {
                    options.AllowAnyHeader();
                    options.AllowAnyOrigin();
                    options.AllowAnyMethod();
                });
            });
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.UseCors(policy);
            
            app.Run();
        }
    }
}