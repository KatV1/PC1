using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC1.Models
{
    [Table("t_persona")]
    public class Persona
    {
        private string _author="";
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

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
        [Range(18, 150, ErrorMessage = "Debe tener una edad entre 18 y 150 años")]
        [Display(Name="Edad")]
        public int Edad { get; set; }

        [Display(Name="Sexo")]
        public string Sexo { get; set; }
        
        [NotMapped]
        public string Respuesta { get; set; }

        public string Author { 
            get => _author;
            set
            {
                _author = "Kat";
            }
        }
    }
}