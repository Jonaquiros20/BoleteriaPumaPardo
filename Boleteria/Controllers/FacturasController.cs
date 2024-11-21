using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class FacturasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
