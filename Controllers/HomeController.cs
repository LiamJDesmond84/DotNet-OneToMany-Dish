using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNet_OneToMany_Dish.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_OneToMany_Dish.Controllers;

public class HomeController : Controller

{
    private readonly ILogger<HomeController> _logger;

    // DbContext injection
    private AppContext dbContext;

    // here we can "inject" our context service into the constructor
    public HomeController(AppContext context, ILogger<HomeController> logger)
    {
        dbContext = context;
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
