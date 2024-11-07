using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class OrderRepository
{
    private readonly SheinContext _context;
    public OrderRepository(SheinContext context)
    {
        _context = context;
    }

    public Order Create(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
        return order;
    }
}