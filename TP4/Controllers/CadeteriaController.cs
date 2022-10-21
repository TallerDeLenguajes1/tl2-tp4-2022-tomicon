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
        public IActionResult AltaCadete(int idCadete, string nombCadete, string apeCadete, string telCadete)
        {
            string linea= $"{idCadete};{nombCadete};{apeCadete};{telCadete}";
            string nombreArchivo= "Cadetes.csv";
            bool archivoExiste= System.IO.File.Exists(nombreArchivo);
            StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
            if (!archivoExiste)
            {
                escritor.WriteLine("ID;Nombre;Apellido;Telefono");
            }
            escritor.WriteLine(linea);
            escritor.Close();
            return View();
        }

        
        public IActionResult cargarCadete()
        {
            return View();
        }

        public IActionResult listarCadetes()
        {
            return View();
        }
    }
}

       
