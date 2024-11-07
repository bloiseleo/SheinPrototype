namespace SheinPrototype.Models;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Telefone { get; set; }
    public string Cpf { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public IEnumerable<OrderItem> Items { get; set; }
}