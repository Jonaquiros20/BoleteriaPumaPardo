using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class ManualDeUsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
