using Microsoft.Extensions.Caching.Memory;
using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class CategoriesRepository
{
    private readonly SheinContext _context;
    private IMemoryCache _cache;
    public CategoriesRepository(SheinContext sheinContext, IMemoryCache cache)
    {
        _context = sheinContext;
        _cache = cache;
    }
    public IEnumerable<Category> GetAllCategories()
    {
        IEnumerable<Category>? categories;
        if (_cache.TryGetValue("categories", out categories))
        {
            return categories!;
        }
        var categoriesDb = _context.Categories.ToList();
        _cache.Set("categories", categoriesDb);
        return categoriesDb;
    }

    public bool ExistsById(int id)
    {
        return _context.Categories.Any(category => category.Id == id);
    }

    public Category? GetById(int id)
    {
        return _context.Categories.First(c => c.Id == id);
    }
}