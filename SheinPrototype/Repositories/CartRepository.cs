using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class CartRepository
{
    private readonly SheinContext _context;
    public CartRepository(SheinContext context)
    {
        _context = context;
    }
    public void CreateCart(Cart cart)
    {
        _context.Carts.Add(cart);
        _context.SaveChanges();
    }
    public int CountItemsBySessionId(string sessionId)
    {
        return _context.Carts.Count(c => c.SessionId == sessionId);
    }
}