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
            var vendedor = HttpContext.Session.GetString("Vendedor");
            if (string.IsNullOrEmpty(vendedor))
            {
                return RedirectToAction("SeleccionarVendedor");
            }

            ViewBag.Vendedor = vendedor;
            return View();
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

        // Acci�n para guardar el nombre del vendedor en sesi�n
        [HttpPost]
        public IActionResult SetVendedor(string vendedor)
        {
            if (vendedor == "Kiara" || vendedor == "Allan")
            {
                HttpContext.Session.SetString("Vendedor", vendedor);
                return RedirectToAction("Boleteria");
            }

            TempData["Error"] = "Debe seleccionar un vendedor v�lido.";
            return RedirectToAction("SeleccionarVendedor");
        }

    }
}
