using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNet_OneToMany_Dish.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_OneToMany_Dish.Controllers;

public class HomeController : Controller

{
    private readonly ILogger<HomeController> _logger;

    // DbContext injection
    private AppDbContext _context;

    public HomeController(AppDbContext context, ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.Chefs = _context.Chefs.Select(x => x.Dishes).ToList();

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

    public IActionResult CreateChef()
    {
        return View();
    }
}
