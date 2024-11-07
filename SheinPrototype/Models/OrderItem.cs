namespace SheinPrototype.Models;

public class OrderItem
{
    public int Id { get; set; }
    public ProductVariations ProductVariations { get; set; }
    public Order Order { get; set; }
}