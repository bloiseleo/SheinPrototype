using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SheinPrototype.Context;

public static class DbInitializerExtension
{
    public static IApplicationBuilder UseDbInitializer(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<SheinContext>();
        var logger = services.GetRequiredService<ILogger<DbInitialize>>();
        var options = services.GetRequiredService<DbContextOptions<SheinContext>>();
        var initializer = new DbInitialize(context, logger, options);
        initializer.Initialize();
        return app;
    }
}