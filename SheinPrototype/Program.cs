using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using SheinPrototype.Context;
using SheinPrototype.Repositories;
using SheinPrototype.Services;

namespace SheinPrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
                });
            builder.Services.AddDbContext<SheinContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddScoped<OrderRepository>();
            builder.Services.AddScoped<OrderValidatorService>();
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddScoped<CategoriesRepository>();
            builder.Services.AddScoped<ProductRepository>();
            builder.Services.AddScoped<ProductVariationsRepository>();
            builder.Services.AddScoped<CartRepository>();
            builder.Services.AddScoped<PostCodeRepository>();
            builder.Services.AddScoped<PostCodeService>();
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "SESSION_ID";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.MaxAge = TimeSpan.FromDays(365);
            });
            var app = builder.Build();
            var logger = app.Services.GetService<ILogger<Program>>();
            logger.LogInformation($"Starting up using {app.Environment.EnvironmentName}");
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            app.UseDbInitializer();
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "PostcontrollerRoute",
                pattern: "Postcode/{code}"
            );
            app.UseRouting();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();            
        }
    }
}