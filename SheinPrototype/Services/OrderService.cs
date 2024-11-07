using SheinPrototype.Dtos;
using SheinPrototype.Models;
using SheinPrototype.Repositories;

namespace SheinPrototype;

public class OrderService
{
    private readonly OrderRepository _repository;
    public OrderService(OrderRepository repository)
    {
        _repository = repository;
    }
    public Order CreateOrder(CreateOrder createOrder, IEnumerable<ProductVariations> productVariationsEnumerable)
    {
        var order = new Order()
        {
            Name = createOrder.Name,
            Telefone = createOrder.Telefone,
            Cpf = createOrder.Cpf,
            Logradouro = createOrder.Logradouro,
            Cep = createOrder.Cep,
            Cidade = createOrder.Cidade,
            Estado = createOrder.Estado,
        };
        var orderItems = productVariationsEnumerable.Select(pv => new OrderItem()
        {
            ProductVariations = pv,
            Order = order
        }).ToList();
        order.Items = orderItems;
        return _repository.Create(order);
    }
}