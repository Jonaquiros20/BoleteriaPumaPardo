using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class OficinaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
