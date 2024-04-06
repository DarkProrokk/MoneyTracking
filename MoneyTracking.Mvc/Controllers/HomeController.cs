using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoneyTracking.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Identity;

namespace MoneyTracking.Controllers;

public class HomeController : Controller
{
    private readonly TrackingContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,  TrackingContext context)
    {
        _context = context;
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}