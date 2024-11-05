using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class ProductRepository
{
    private SheinContext _context;
    private IMemoryCache _cache;
    public ProductRepository(SheinContext sheinContext, IMemoryCache memoryCache)
    {
        _cache = memoryCache;
        _context = sheinContext;
    }

    public Product? GetProductById(int id)
    {
        return GetAll().SingleOrDefault(x => x.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        if (_cache.TryGetValue("Products", out IEnumerable<Product>? products))
        {
            return products!;
        }
        if (!_context.Products.Any())
        {
            return new List<Product>();
        }

        var all = _context.Products.Include(p => p.Category).Include(p => p.Variations).ToList();
        _cache.Set("Products", all);
        return all;
    }

    public IEnumerable<Product> GetByCategory(Category category)
    {
        var cacheKey = $"Products_{category.Id}";
        if (_cache.TryGetValue(cacheKey, out IEnumerable<Product>? products))
        {
            return products!;
        }
        var all = GetAll().Where(p => p.Category.Id == category.Id);
        _cache.Set(cacheKey, all);
        return all;
    }
}