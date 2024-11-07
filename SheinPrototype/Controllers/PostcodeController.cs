using Microsoft.AspNetCore.Mvc;
using Npgsql.Internal;
using SheinPrototype.Repositories;
using SheinPrototype.Services;

namespace SheinPrototype.Controllers;

public class PostcodeController: Controller
{
    private readonly PostCodeRepository _postCodeRepository;
    private readonly PostCodeService _postCodeService;
    public PostcodeController(
        PostCodeRepository postCodeRepository,
        PostCodeService postCodeService
        )
    {
        _postCodeRepository = postCodeRepository;
        _postCodeService = postCodeService;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string cpf)
    {
        var postCode =_postCodeRepository.FindPostCodeByCpf(cpf);
        if (postCode == null)
        {
            return NotFound();
        }
        return Redirect($"/Postcode/Track?code={postCode.Token}");
    }
    [HttpGet]
    public IActionResult Track(string code, bool? firstTime)
    {
        var postCode = _postCodeRepository.FindPostCodeByToken(code);
        var viewmodel = _postCodeService.GetTrackViewModel(postCode);
        viewmodel.IsFirstTime = firstTime ?? false;
        return View(viewmodel);
    }
}