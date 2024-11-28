using Microsoft.AspNetCore.Mvc;

namespace Boleteria.Controllers
{
    public class CierreDeCajaController : Controller
    {
        // Acción principal para la vista Index
        public IActionResult Index()
        {
            return View();
        }

        // Acción para manejar los filtros (Diarios, Semanales, etc.)
        public IActionResult Filtrar(string tipo)
        {
            // Crear datos simulados según el filtro
            var datos = new List<CierreDeCaja>();
            switch (tipo)
            {
                case "diario":
                    datos.Add(new CierreDeCaja { Titulo = "Cierre Diario", Fecha = "27 Nov, 2024", Monto = "$1,200", ImagenFactura = "https://via.placeholder.com/300" });
                    break;
                case "semanal":
                    datos.Add(new CierreDeCaja { Titulo = "Cierre Semanal", Fecha = "Semana del 20-26 Nov", Monto = "$8,400", ImagenFactura = "https://via.placeholder.com/300" });
                    break;
                case "quincenal":
                    datos.Add(new CierreDeCaja { Titulo = "Cierre Quincenal", Fecha = "1-15 Nov, 2024", Monto = "$15,000", ImagenFactura = "https://via.placeholder.com/300" });
                    break;
                case "mensual":
                    datos.Add(new CierreDeCaja { Titulo = "Cierre Mensual", Fecha = "Noviembre, 2024", Monto = "$30,000", ImagenFactura = "https://via.placeholder.com/300" });
                    break;
                case "anual":
                    datos.Add(new CierreDeCaja { Titulo = "Cierre Anual", Fecha = "2024", Monto = "$360,000", ImagenFactura = "https://via.placeholder.com/300" });
                    break;
            }

            // Enviar los datos a la vista Index para mostrar el filtro
            ViewBag.Tipo = tipo; // Indica el tipo actual de filtro
            return View("Index", datos);
        }

        // Acción para la vista Detalles
        public IActionResult Detalles(CierreDeCaja cierre)
        {
            return View(cierre);
        }
    }

    // Modelo que representa los datos de un cierre
    public class CierreDeCaja
    {
        public string Titulo { get; set; }
        public string Fecha { get; set; }
        public string Monto { get; set; }
        public string ImagenFactura { get; set; }
    }
}
