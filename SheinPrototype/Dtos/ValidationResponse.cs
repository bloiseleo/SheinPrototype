namespace SheinPrototype.Dtos;

public class ValidationResponse
{
    public string Message { get; set; }
    public bool Success { get; set; }
    public string Field { get; set; }
}