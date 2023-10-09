﻿using System.Diagnostics;
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

    public IActionResult CreateChef(Chef chef)
    {
        _context.Chefs.Add(chef);
        _context.SaveChanges();
        return View();
    }

    public IActionResult CreateDish(Dish dish)
    {
        _context.Dishes.Add(dish);
        _context.SaveChanges();
        return View();
    }

    public IActionResult EditChef(Chef chef)
    {
        if (!ViewData.ModelState.IsValid) {
            return View();
        }

        else
        {
            var chefToUpdate = _context.Chefs.FirstOrDefault(x => x.Id == chef.Id);

            chefToUpdate.Age = chef.Age;
            chefToUpdate.Name = chef.Name;
            chefToUpdate.DOB = chef.DOB;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

    public IActionResult EditDish(Dish dish)
    {
        var dishToUpdate = _context.Dishes.FirstOrDefault(x => x.Id == dish.Id);

        dishToUpdate.Description = dish.Description;
        dishToUpdate.ChefName = dish.ChefName;
        dishToUpdate.Tastiness = dish.Tastiness;
        dishToUpdate.Name = dish.Name;

        _context.SaveChanges();
        return View();
    }
}
