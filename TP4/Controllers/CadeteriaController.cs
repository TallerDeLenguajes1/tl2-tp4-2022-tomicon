using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TP4.Controllers
{

    public class CadeteriaController : Controller
    {
        private readonly ILogger<CadeteriaController> _logger;

        public CadeteriaController(ILogger<CadeteriaController> logger)
        {
            _logger = logger;
        }

        public IActionResult AltaCadete()
        {
            return View();
        }

        [HttpPost]
        public void agregarCadete(int idCadete, string nombCadete, string apeCadete, string telCadete)
        {
            
        }
    }
}

       
