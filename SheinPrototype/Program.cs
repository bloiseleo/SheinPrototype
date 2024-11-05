using Microsoft.EntityFrameworkCore;
using SheinPrototype.Context;
using SheinPrototype.Repositories;

namespace SheinPrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<SheinContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddScoped<CategoriesRepository>();
            builder.Services.AddScoped<ProductRepository>();
            builder.Services.AddScoped<ProductVariationsRepository>();
            builder.Services.AddScoped<CartRepository>();
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "SESSION_ID";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.MaxAge = TimeSpan.FromDays(365);
            });
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            app.UseDbInitializer();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();            
        }
    }
}