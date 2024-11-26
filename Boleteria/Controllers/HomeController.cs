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
            // Aquí puedes agregar lógica futura para la Oficina
            return View(); // Busca Views/Home/Oficina.cshtml
        }

        public IActionResult Boleteria()
        {
            // Redirige al controlador de boletería
            return RedirectToAction("Index", "Boleteria");
           
        }
        public IActionResult Facturas()
        {
            // Redirige al controlador de Facturas
            return RedirectToAction("Index", "CierreDeCaja");
        }

        public IActionResult Privacy()
        {
            return View();
        }
      

    

    }
}
