using BlogCSharp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogCSharp.Controllers;

public class PostController : Controller
{
    private readonly ILogger<PostController> _logger;
    private readonly ApplicationDbContext _context;
    public PostController(ILogger<PostController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Blog(int? id)
    {
        if(id == null)
        {
            return RedirectToAction(nameof(Index));
        }

        var postContent = _context.Posts
                            .Include(x => x.UserId)
                            .FirstOrDefault(p => p.Id == id);

        return View(postContent);
    }
}
