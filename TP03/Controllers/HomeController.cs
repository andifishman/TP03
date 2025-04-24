using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static ListaDiscos miLista;
    private static Disco miDisco;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        miLista = new ListaDiscos();
        ViewBag.Lista = miLista;
        return View();
    }
     public IActionResult InfoDisco(int ID)
    {
        ViewData["ID"] = ID;
        miDisco = miLista.Discos[ID];
        ViewBag.Disco = miDisco;
        return View("InfoDisco");
    }
}
