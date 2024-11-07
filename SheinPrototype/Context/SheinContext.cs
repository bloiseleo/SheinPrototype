using Microsoft.EntityFrameworkCore;
using SheinPrototype.Models;

namespace SheinPrototype.Context;

public class SheinContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductVariations> ProductVariations { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PostCode> PostCodes { get; set; }
    public SheinContext(DbContextOptions<SheinContext> options): base(options) {}
}