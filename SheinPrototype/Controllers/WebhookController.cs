using Microsoft.AspNetCore.Mvc;

namespace SheinPrototype.Controllers;

public class WebhookController: Controller
{
    public IActionResult Index(HttpRequest request)
    {
        var body = new StreamReader(request.Body).ReadToEnd();
        Console.WriteLine(request.Body);
        return NotFound();
    }
}