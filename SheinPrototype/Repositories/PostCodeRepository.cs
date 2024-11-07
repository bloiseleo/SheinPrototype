using Microsoft.EntityFrameworkCore;
using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class PostCodeRepository
{
    private readonly SheinContext _sheinContext;

    public PostCodeRepository(SheinContext sheinContext)
    {
        _sheinContext = sheinContext;
    }

    public PostCode? FindPostCodeByToken(string token)
    {
        return _sheinContext.PostCodes.Include(pc => pc.Order).FirstOrDefault(pc => pc.Token == token);
    }
    public PostCode? FindPostCodeByCpf(string cpf)
    {
        return _sheinContext.PostCodes.Include(pc => pc.Order).FirstOrDefault(pc => pc.Order.Cpf == cpf);
    }
    public PostCode CreatePostCode(PostCode postCode)
    {
        _sheinContext.PostCodes.Add(postCode);
        _sheinContext.SaveChanges();
        return postCode;
    }
}