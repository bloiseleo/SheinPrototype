using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class ProductVariationsRepository
{
    private readonly SheinContext _context;
    public ProductVariationsRepository(SheinContext context)
    {
        _context = context;
    }

    public ProductVariations? FindById(int id)
    {
        return _context.ProductVariations.First(c => c.Id == id);
    }
}