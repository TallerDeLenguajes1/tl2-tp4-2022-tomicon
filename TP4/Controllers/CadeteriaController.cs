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

        [HttpPost]
        public void AltaCadete(int idCadete, string nombCadete, string apeCadete, string telCadete)
        {
            string linea= $"{idCadete};{nombCadete};{apeCadete};{telCadete}";
            
        }

        
        public IActionResult cargarCadete()
        {
            return View();
        }
    }
}

       
