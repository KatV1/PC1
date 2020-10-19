using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1.Models;

namespace PC1.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Registrar (Persona persona)
        {
            if (ModelState.IsValid)
            {
                persona.Respuesta= persona.Nombre + ", tus datos han sido registrados por Kat Valcárcel.";
            }         
            return View("index", persona);
        }
    }
}
