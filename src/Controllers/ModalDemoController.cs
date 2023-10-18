using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using source.Models;

namespace source.Controllers;

public class ModalDemoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ModalDemoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult ModalContent()
    {
        return PartialView("_ModalContent");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
