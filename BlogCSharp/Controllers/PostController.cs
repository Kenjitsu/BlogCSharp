using Microsoft.AspNetCore.Mvc;

namespace BlogCSharp.Controllers;

public class PostController : Controller
{
    private readonly ILogger<PostController> _logger;
    public PostController(ILogger<PostController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

}
