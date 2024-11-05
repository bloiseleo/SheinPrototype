using Microsoft.AspNetCore.Mvc;
using SheinPrototype.Repositories;

namespace SheinPrototype.Controllers;

public class CategoryController: Controller
{
    private CategoriesRepository _categoriesRepository;
    private ProductRepository _productRepository;
    public CategoryController(CategoriesRepository categoriesRepository, ProductRepository productRepository)
    {
        _categoriesRepository = categoriesRepository;
        _productRepository = productRepository;
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
        ViewData["Products"] = products;
        return View(categories);
    }
}