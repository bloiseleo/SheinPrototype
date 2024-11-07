using Microsoft.AspNetCore.Mvc;
using SheinPrototype.Dtos;
using SheinPrototype.Models;
using SheinPrototype.Repositories;
using SheinPrototype.Services;

namespace SheinPrototype.Controllers;

public class CartController: Controller
{
    private readonly ProductVariationsRepository _productVariationsRepository;
    private readonly CartRepository _cartRepository;
    public readonly OrderValidatorService _orderValidatorService;
    private readonly OrderService _orderService;
    private readonly PostCodeService _postCodeService;
    public CartController(
        CartRepository cartRepository, 
        ProductVariationsRepository productVariationsRepository, 
        OrderValidatorService orderValidatorService, 
        OrderService orderService,
        PostCodeService postCodeService)
    {
        _productVariationsRepository = productVariationsRepository;
        _cartRepository = cartRepository;
        _orderValidatorService = orderValidatorService;
        _orderService = orderService;
        _postCodeService = postCodeService;
    }
    private IEnumerable<ProductVariations> GetAllProductVariations()
    {
        var cart = _cartRepository.GetCartBySessionId(HttpContext);
        if (cart == null)
        {
            return Enumerable.Empty<ProductVariations>();
        }

        return _productVariationsRepository.GetRange(cart);
    }
    public IActionResult Index()
    {
        var data = GetAllProductVariations();
        if (data.Count() == 0)
        {
            return Redirect("/");
        }
        return View(data);
    }
    [HttpPost]
    public IActionResult Index(CreateOrder order)
    {
        var validateOrder = _orderValidatorService.ValidateOrder(order);
        if (validateOrder != null)
        {
            ViewData["ValidateOrder"] = validateOrder;
            ViewData["OldOrder"] = order;
            return View("Index", GetAllProductVariations());
        }
        var orderEntity = _orderService.CreateOrder(order, GetAllProductVariations());
        var postCode = _postCodeService.CreatePostCode(orderEntity);
        _cartRepository.CleanCart(HttpContext);
        return Redirect($"/Postcode/Track?code={postCode.Token}&firstTime=true"); 
    }
}