using Microsoft.EntityFrameworkCore;
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
    public IEnumerable<ProductVariations> GetRange(IEnumerable<int> productIds)
    {
        return _context.ProductVariations.Where(pv => productIds.Contains(pv.Id)).Include(pv => pv.Product).ToList();
    }
}