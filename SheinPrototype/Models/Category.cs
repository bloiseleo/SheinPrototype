namespace SheinPrototype.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public IEnumerable<Product> Products { get; set; }
}