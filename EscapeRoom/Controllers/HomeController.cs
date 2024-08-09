using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
//using SalaDeEscape.Models;

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
         return RedirectToAction("Habitacion", new { sala = Escape.GetEstadoJuego() });
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if (sala != Escape.GetEstadoJuego())
            {
                return RedirectToAction("Habitacion", new { sala = Escape.GetEstadoJuego() });
            }

            if (clave != null)
            {
                bool correcta = Escape.ResolverSala(sala, clave);
                if (correcta)
                {
                    if (sala == 5)
                    {
                        return RedirectToAction("Victoria");
                    }
                    else
                    {
                        return RedirectToAction("Habitacion", new { sala = sala + 1 });
                    }
                }
                else
                {
                    ViewBag.Error = "¡Respuesta incorrecta! Intenta de nuevo.";
                }
            }
            return View($"Habitacion{sala}");
    }
        public IActionResult Victoria()
    {
        return View();
    }
}
