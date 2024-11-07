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

    private bool cartLimitExceeded()
    {
        var cart = _cartRepository.GetCartBySessionId(HttpContext);
        if (cart.Count() < 15)
        {
            return false;
        }

        return true;
    }
    [HttpGet]
    public IActionResult Index(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null) return NotFound();
        ViewData["Product"] = product;
        if (cartLimitExceeded())
        {
            return Redirect($"/Home?error=true");
        }
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
        _cartRepository.AddToCart(variation, HttpContext);
        return Redirect($"Home/");
    }
}