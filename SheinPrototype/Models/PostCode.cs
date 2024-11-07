namespace SheinPrototype.Models;

public class PostCode
{
    public int Id { get; set; }
    public string Token { get; set; }
    public Order Order { get; set; }
    public DateTime StartDate { get; set; }
}