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
        // Acción para manejar la impresión de tiquetes
        public IActionResult ImprimirTiquete(string ruta, string horario, string subRuta, int cantidad)
        {
            var vendedor = HttpContext.Session.GetString("Vendedor");
            if (string.IsNullOrEmpty(vendedor))
            {
                return RedirectToAction("SeleccionarVendedor");
            }

            // Lógica para calcular el precio y pasar los datos a la vista
            decimal precio = 500; // Ejemplo de precio base
            ViewBag.Vendedor = vendedor;
            ViewBag.Ruta = ruta;
            ViewBag.Horario = horario;
            ViewBag.SubRuta = subRuta;
            ViewBag.Cantidad = cantidad;
            ViewBag.PrecioTotal = precio * cantidad;

            return View();
        }





        [HttpPost]
        public IActionResult Comprar(string ruta, decimal precio)
        {
            // Validar parámetros de entrada
            if (string.IsNullOrEmpty(ruta) || precio <= 0)
            {
                TempData["ErrorMessage"] = "Datos inválidos. Por favor revise la ruta y el precio.";
                return RedirectToAction("Index");
            }

            // Leer las cookies existentes
            int totalTiquetes = Request.Cookies["TotalTiquetes"] != null
                                ? int.Parse(Request.Cookies["TotalTiquetes"])
                                : 0;

            decimal totalDinero = Request.Cookies["TotalDinero"] != null
                                  ? decimal.Parse(Request.Cookies["TotalDinero"])
                                  : 0;

            // Actualizar los valores
            totalTiquetes++;
            totalDinero += precio;

            // Escribir las cookies actualizadas con una duración de 1 día
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTime.Now.AddDays(1)
            };

            Response.Cookies.Append("TotalTiquetes", totalTiquetes.ToString(), cookieOptions);
            Response.Cookies.Append("TotalDinero", totalDinero.ToString(), cookieOptions);

            // Guardar un mensaje de éxito en TempData
            TempData["SuccessMessage"] = $"¡Compra exitosa! Has comprado un tiquete para la ruta {ruta} por {precio:C}.";

            return RedirectToAction("Index");
        }
    }
}
