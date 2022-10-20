using Microsoft.AspNetCore.Mvc;
using Taller2_clase5.Models;

namespace Taller2_clase5.Controllers
{
    public class ejem1Controller : Controller
    {
        private readonly ILogger<ejem1Controller> _logger;

        public ejem1Controller(ILogger<ejem1Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Cliente miCliente)
        {
            
            return View(miCliente);
        }

        public IActionResult ConsultaCliente()
        {
            var miCliente = new Cliente();
            miCliente.Name= "tomi";
            miCliente.Edad= 21;
            return View(miCliente);
        }

        [HttpGet]
        public IActionResult AltaCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AltaCliente(Cliente cliente)
        {
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}