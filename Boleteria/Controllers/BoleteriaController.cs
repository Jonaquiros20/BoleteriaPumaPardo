using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    [Route("Boleteria")]
    public class BoleteriaController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            int totalTiquetes = Request.Cookies["TotalTiquetes"] != null
                                ? int.Parse(Request.Cookies["TotalTiquetes"])
                                : 0;

            decimal totalDinero = Request.Cookies["TotalDinero"] != null
                                  ? decimal.Parse(Request.Cookies["TotalDinero"])
                                  : 0;

            ViewBag.TotalTiquetes = totalTiquetes;
            ViewBag.TotalDinero = totalDinero;

            return View();
        }

        [HttpGet("ImprimirTiquete")]
        public IActionResult ImprimirTiquete(string subRuta, int cantidad, decimal precioUnitario, string ruta)
        {
            ViewBag.SubRuta = subRuta;
            ViewBag.Cantidad = cantidad;
            ViewBag.PrecioUnitario = precioUnitario;
            ViewBag.Ruta = ruta;

            return View();
        }
    }
}
