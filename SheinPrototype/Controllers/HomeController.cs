using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SheinPrototype.Context;
using SheinPrototype.Models;
using SheinPrototype.Repositories;

namespace SheinPrototype.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CategoriesRepository _categoriesRepository;
    private readonly ProductRepository _productRepository;
    private readonly CartRepository _cartRepository;

    public HomeController(ILogger<HomeController> logger, CategoriesRepository categoriesRepository, ProductRepository productRepository, CartRepository cartRepository)
    {
        _logger = logger;
        _categoriesRepository = categoriesRepository;
        _productRepository = productRepository;
        _cartRepository = cartRepository;
    }

    private void _setSessionContextIfNeeded()
    {
        var sessionId = HttpContext.Session.Keys.Contains("SESSION_ID");
        if (sessionId)
        {
            return;
        }
        HttpContext.Session.Set("SESSION_ID", Encoding.UTF8.GetBytes(HttpContext.Session.Id));
    }
    public IActionResult Index(bool error = false)
    {
        _setSessionContextIfNeeded();
        var menuList = _categoriesRepository.GetAllCategories();
        var allProducts = _productRepository.GetAll();
        var cartQtt = _cartRepository.CountItemsBySessionId(HttpContext);
        ViewData["Products"] = allProducts;
        ViewData["CartQtt"] = cartQtt;
        ViewData["Error"] = error ? "Voce ja atingiu o limite de produtos que pode escolher" : null;
        return View(menuList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}