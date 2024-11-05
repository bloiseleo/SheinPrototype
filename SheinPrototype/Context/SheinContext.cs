using Microsoft.EntityFrameworkCore;
using SheinPrototype.Models;

namespace SheinPrototype.Context;

public class SheinContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductVariations> ProductVariations { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public SheinContext(DbContextOptions<SheinContext> options): base(options) {}
}