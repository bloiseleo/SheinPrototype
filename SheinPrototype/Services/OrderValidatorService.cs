using System.Text.RegularExpressions;
using SheinPrototype.Dtos;
using SheinPrototype.Repositories;

namespace SheinPrototype.Services;

public class OrderValidatorService
{
    private readonly PostCodeService _postCodeService;
    public OrderValidatorService(PostCodeService postCodeService)
    {
        _postCodeService = postCodeService;
    }
    public ValidationResponse GenerateValidationResponse(string message, string elementName, bool valid = false)
    {
        return new ValidationResponse()
        {
            Message = message,
            Success = valid,
            Field = elementName
        };
    }
    private bool ValidCellphone(string number)
    {
        if (number.Length < 10 || number.Length >= 12)
        {
            return false;
        }
        return !Regex.IsMatch(number, @"[a-zA-Z]");
    }
    public bool ValidCep(string cep)
    {
        if (cep.Length != 8)
        {
            return false;
        }
        return !Regex.IsMatch(cep, @"[a-zA-Z]");
    }

    public bool ValidCity(string city)
    {
        return city.Length >= 2 && !Regex.IsMatch(city, @"\d");
    }
    public bool ValidState(string state)
    {
        if (state.Length != 2)
        {
            return false;
        }
        return !Regex.IsMatch(state, @"\d");
    }
    public bool ValidLogradouro(string logradouro)
    {
        return logradouro.Length >= 5;
    }
    private bool ValidateCPF(string cpf)
    {
        cpf = new string(cpf.Where(char.IsDigit).ToArray());
        if (cpf.Length != 11)
            return false;
        if (cpf.Distinct().Count() == 1)
            return false;
        int sum = 0;
        for (int i = 0; i < 9; i++)
            sum += (cpf[i] - '0') * (10 - i);
        
        int remainder = sum % 11;
        int firstDigit = remainder < 2 ? 0 : 11 - remainder;
        
        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += (cpf[i] - '0') * (11 - i);
        
        remainder = sum % 11;
        int secondDigit = remainder < 2 ? 0 : 11 - remainder;

        return cpf[9] - '0' == firstDigit && cpf[10] - '0' == secondDigit;
    }
    
    public ValidationResponse? ValidateOrder(CreateOrder order)
    {
        
        if (order.Name == null)
        {
            return GenerateValidationResponse("Nome deve ser preenchido", "name");
        }
        if (order.Name.Length < 3)
        {
            return GenerateValidationResponse("O nome deve ter ao menos três caracteres", "name");
        }
        if (order.Telefone == null)
        {
            return GenerateValidationResponse("Telefone deve ser preenchido", "telefone");
        }
        if (!ValidCellphone(order.Telefone))
        {
            return GenerateValidationResponse("Telefone deve ser válido", "telefone");
        }
        if (order.Cpf == null)
        {
            return GenerateValidationResponse("O CPF deve ser preenchido", "cpf");
        }
        if (!ValidateCPF(order.Cpf))
        {
            return GenerateValidationResponse("CPF deve ser válido", "cpf");
        }
        if (order.Cep == null)
        {
            return GenerateValidationResponse("Cep deve ser preenchido", "cep");
        }
        if (!ValidCep(order.Cep))
        {
            return GenerateValidationResponse("CEP deve ser válido", "cep");
        }
        if (order.Logradouro == null)
        {
            return GenerateValidationResponse("O Logradouro deve ser preenchido", "logradouro");   
        }
        if (!ValidLogradouro(order.Logradouro))
        {
            return GenerateValidationResponse("Logradouro deve ser válido", "logradouro");
        }
        if (order.Cidade == null)
        {
            return GenerateValidationResponse("A Cidade deve ser preenchida", "cidade");
        }
        if (!ValidCity(order.Cidade))
        {
            return GenerateValidationResponse("Cidade deve ser válida", "cidade");
        }
        if (order.Estado == null)
        {
            return GenerateValidationResponse("Estado deve ser preenchido", "estado");
        }
        if (!ValidState(order.Estado))
        {
            return GenerateValidationResponse("Estado deve ter apenas dois caracteres", "estado");
        }
        if (_postCodeService.AlreadyHasABuy(order.Cpf))
        {
            return GenerateValidationResponse("Você já solicitou suas roupas grátis", "cpf");
        }
        
        return null;
    }
}