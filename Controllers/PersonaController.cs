using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1.Models;
using PC1.Data;

namespace PC1.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly DatabaseContext _context;

        public PersonaController(ILogger<PersonaController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
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
                _context.Add(persona);
                _context.SaveChanges();
                persona.Respuesta = persona.Nombre + ", tus datos han sido registrados por " + persona.Author + ".";
            }         
            return View("index", persona);
        }
    }
}
