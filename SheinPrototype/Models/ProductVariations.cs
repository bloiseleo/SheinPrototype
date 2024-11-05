namespace SheinPrototype.Models;

public class ProductVariations
{
    public int Id { get; set; }
    public string Color { get; set; }
    public string ImageUrl { get; set; }
    public Product Product { get; set; }
}