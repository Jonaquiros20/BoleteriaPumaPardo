using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class CierreDeCajaController : Controller
    {
        public IActionResult CierreDeCaja()
        {
            return View();
        }
    }
}
