using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado

    {
        // Empleado (Id- Nombre-Apellido-DNI-Legajo-FechaNacimiento y Título) 
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Titulo { get; set; }


    }
}
