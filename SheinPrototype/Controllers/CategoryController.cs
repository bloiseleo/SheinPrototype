using Microsoft.AspNetCore.Mvc;
using SheinPrototype.Repositories;

namespace SheinPrototype.Controllers;

public class CategoryController: Controller
{
    private CategoriesRepository _categoriesRepository;
    private ProductRepository _productRepository;
    private readonly CartRepository _cartRepository;
    public CategoryController(CategoriesRepository categoriesRepository, ProductRepository productRepository, CartRepository cartRepository)
    {
        _categoriesRepository = categoriesRepository;
        _productRepository = productRepository;
        _cartRepository = cartRepository;
    }
    public IActionResult Index(int id)
    {
        if (!_categoriesRepository.ExistsById(id))
        {
            return NotFound();
        }
        ViewData["CategoryId"] = id;
        var categories = _categoriesRepository.GetAllCategories();
        var category = _categoriesRepository.GetById(id)!;
        var products = _productRepository.GetByCategory(category);
        var cartQtt = _cartRepository.CountItemsBySessionId(HttpContext);
        ViewData["Products"] = products;
        ViewData["CartQtt"] = cartQtt;
        return View(categories);
    }
}