namespace SheinPrototype.Dtos;

public class CreateOrder
{
    public string? Name { get; set; }
    public string? Telefone { get; set; }
    public string? Cpf { get; set; }
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string SessionId { get; set; }
}