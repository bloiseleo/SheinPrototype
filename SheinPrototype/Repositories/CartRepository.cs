using System.Text;
using SheinPrototype.Context;
using SheinPrototype.Models;

namespace SheinPrototype.Repositories;

public class CartRepository
{
    public void AddToCart(ProductVariations productVariations, HttpContext context)
    {
        context.Session.Set($"ProductVariation__{productVariations.Id}", Encoding.UTF8.GetBytes(productVariations.Id.ToString()));
    }
    public int CountItemsBySessionId(HttpContext context)
    {
        return context.Session.Keys.Count(key => key.StartsWith("ProductVariation__"));
    }
    public IEnumerable<int> GetCartBySessionId(HttpContext context)
    {
        return context.Session.Keys.Where(key =>
            {
                return key.StartsWith("ProductVariation__");
            })
            .Select(key =>
            {
                var data = context.Session.Get(key);
                var dataString = Encoding.UTF8.GetString(data);
                
                int.TryParse(dataString, out var result);
                return result;
            });
    }

    public void CleanCart(HttpContext context)
    {
        foreach (var se in context.Session.Keys.Where(key => key.StartsWith("ProductVariation__")))
        {
            context.Session.Remove(se);
        }
    }
}