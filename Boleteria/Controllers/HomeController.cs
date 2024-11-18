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
        // Acción para mostrar la vista de selección de vendedor
        public IActionResult SeleccionarVendedor()
        {
            return View();
        }

        // Acción para guardar el nombre del vendedor en sesión
        [HttpPost]
        public IActionResult SetVendedor(string vendedor)
        {
            if (vendedor == "Kiara" || vendedor == "Allan")
            {
                HttpContext.Session.SetString("Vendedor", vendedor);
                return RedirectToAction("Boleteria");
            }

            TempData["Error"] = "Debe seleccionar un vendedor válido.";
            return RedirectToAction("SeleccionarVendedor");
        }

    }
}
