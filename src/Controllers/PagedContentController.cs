using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using source.Models;

namespace source.Controllers;

public class PagedContentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public PagedContentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Page(int pageNumber)
    {
        return PartialView();
    }
}
