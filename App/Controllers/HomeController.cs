using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.ViewModels;
using App.Data;
using App.Models;
using System;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository<Race> _raceRepository;

    public HomeController(ILogger<HomeController> logger, IRepository<Race> repository)
    {
        _logger = logger;
        _raceRepository = repository;
    }
    public IActionResult Index()
    {
        var race = _raceRepository.GetAll();
            var IndexViewModel = new IndexViewModel(
                race,
                "Détails"
            );

            return View(IndexViewModel);
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
