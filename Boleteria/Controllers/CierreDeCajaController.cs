using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class CierreDeCajaController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Retorna la vista principal de CierreDeCaja
        }

    }
}
