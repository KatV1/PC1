using System;
using System.ComponentModel.DataAnnotations;

namespace PC1.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese apellido")]
        [Display(Name="Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el distrito donde vive")]
        [Display(Name="Distrito")]
        public string Distrito { get; set; }

        [Display(Name="Banco")]
        public string Banco { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su edad")]
        [Display(Name="Edad")]
        public int Edad { get; set; }

        [Display(Name="Sexo")]
        public char Sexo { get; set; }
        
        public string Respuesta { get; set; }
    }
}