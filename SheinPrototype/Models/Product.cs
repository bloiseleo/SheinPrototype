namespace SheinPrototype.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public IEnumerable<ProductVariations> Variations { get; set; }
    
}