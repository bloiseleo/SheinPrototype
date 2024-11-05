namespace SheinPrototype.Models;

public class Cart
{
    public int Id { get; set; }
    public ProductVariations ProductVariations { get; set; }
    public string Size { get; set; }
    public string SessionId { get; set; }
}