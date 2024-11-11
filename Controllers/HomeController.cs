using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMe.Models;
using SMe.Models.Domains;
using SMe.Models.DTOs;
using SMe.Models.Interfaces;

namespace SMe.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IShopRepository _shopRepository;

    public HomeController(ILogger<HomeController> logger, IShopRepository shopRepository)
    {
        _logger = logger;
        _shopRepository = shopRepository;
    }

    public IActionResult Index()
    {
        IEnumerable<Store> stores = _shopRepository.getStores();
        DataViewModel model = new DataViewModel
        {
            Stores = stores,
        };
        return Ok(model);
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
