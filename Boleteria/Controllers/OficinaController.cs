using Microsoft.AspNetCore.Mvc;

namespace PumaPardo.Controllers
{
    public class OficinaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Gestionar Choferes
        public IActionResult GestionarChoferes()
        {
            return View(); // Devuelve la vista para gestionar choferes
        }

        // Gestionar Facturas
        public IActionResult GestionarFacturas()
        {
            return View(); // Devuelve la vista para gestionar facturas
        }

        // Cierres de Caja
        public IActionResult CierresCaja()
        {
            return View(); // Devuelve la vista de cierres de caja
        }

        // Gestionar Unidades
        public IActionResult GestionarUnidades()
        {
            return View(); // Devuelve la vista para gestionar unidades de transporte
        }
    }
}
