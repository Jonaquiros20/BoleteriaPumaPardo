using Boleteria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Boleteria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Oficina()
        {
            // Aqu� puedes agregar l�gica futura para la Oficina
            return View(); // Busca Views/Home/Oficina.cshtml
        }

        public IActionResult Boleteria()
        {
            // Redirige al controlador de boleter�a
            return RedirectToAction("Index", "Boleteria");
           
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // Acci�n para mostrar la vista de selecci�n de vendedor
        public IActionResult SeleccionarVendedor()
        {
            return View();
        }

    

    }
}
