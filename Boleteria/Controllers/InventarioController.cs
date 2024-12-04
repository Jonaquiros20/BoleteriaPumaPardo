using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
