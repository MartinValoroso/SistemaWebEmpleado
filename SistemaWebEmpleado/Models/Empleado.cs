using SistemaWebEmpleado.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebEmpleado.Models
{
    public class Empleado

    {
        // Empleado (Id- Nombre-Apellido-DNI-Legajo-FechaNacimiento y Título) 
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Apellido { get; set; }

        public int DNI { get; set; }
        [RegularExpression("[a-zA-Z]{2}[1-9]{5}$")]
        public int Legajo { get; set; }

        [CheckValidYear]
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Titulo { get; set; }


    }
}
