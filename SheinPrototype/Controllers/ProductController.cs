using System.Text;
using Microsoft.AspNetCore.Mvc;
using SheinPrototype.Dtos;
using SheinPrototype.Models;
using SheinPrototype.Repositories;

namespace SheinPrototype.Controllers;

public class ProductController: Controller
{
    private ProductRepository _productRepository;
    private readonly CartRepository _cartRepository;
    private readonly ProductVariationsRepository _productVariationsRepository;
    public ProductController(ProductRepository productRepository, CartRepository cartRepository, ProductVariationsRepository productVariationsRepository)
    {
        _productRepository = productRepository;
        _cartRepository = cartRepository;
        _productVariationsRepository = productVariationsRepository;
    }
    [HttpGet]
    public IActionResult Index(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null) return NotFound();
        ViewData["Product"] = product;
        return View();
    }

    [HttpPost]
    public IActionResult Index(PutOnCartDTO dto)
    {
        var variation = _productVariationsRepository.FindById(dto.Variation);
        if (variation == null)
        {
            return NotFound();
        }
        var cart = new Cart()
        {
            Size = dto.Size.ToString(),
            ProductVariations = variation,
            SessionId = HttpContext.Session.Id,
        };
        _cartRepository.CreateCart(cart);
        return Redirect($"Home/");
    }
}