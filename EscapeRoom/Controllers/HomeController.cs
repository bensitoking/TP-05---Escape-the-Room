using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        int num = Escape.GetEstadoJuego();
        return View();
    }

    // public IActionResult Habitacion(int sala, string clave)
    // {
    //     if (sala == Escape.GetEstadoJuego())
    //     {

    //     }
    // }

}
static class Escape
{
       static string[] incognitasSalas = {"", };
       static int estadoJuego = 1;

    private static void InicializarJuego() {

    }
    public static int GetEstadoJuego() {
        return estadoJuego;
    }

    // public static bool ResolverSala(int Sala, string Incognita){

    // }
}