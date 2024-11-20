using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class BoleteriaController : Controller
    {
        public IActionResult Index()
        {
            // Leer las cookies existentes de manera segura
            int totalTiquetes = Request.Cookies["TotalTiquetes"] != null
                                ? int.Parse(Request.Cookies["TotalTiquetes"])
                                : 0;

            decimal totalDinero = Request.Cookies["TotalDinero"] != null
                                  ? decimal.Parse(Request.Cookies["TotalDinero"])
                                  : 0;

            // Pasar los valores al ViewBag para la vista
            ViewBag.TotalTiquetes = totalTiquetes;
            ViewBag.TotalDinero = totalDinero;

            return View();
        }

        [HttpGet]
        public JsonResult GetSubRutas(string ruta)
        {
            // Mapeo de rutas con sus subrutas y precios
            var subRutas = new Dictionary<string, List<(string SubRuta, int Precio)>>()
            {
                { "Siquirres-La Alegría", new List<(string, int)>
                    {
                        ("Cairo", 335), ("Herediana", 365), ("Y Griega", 385),
                        ("San Isidro", 385), ("Villa Bonita", 410), ("El Cruce", 410)
                    }
                },
                { "Otra Ruta", new List<(string, int)>
                    {
                        ("SubRuta1", 200), ("SubRuta2", 250)
                    }
                }
            };

            if (subRutas.ContainsKey(ruta))
            {
                return Json(subRutas[ruta]);
            }

            return Json(new List<(string, int)>());
        }
    }
}
