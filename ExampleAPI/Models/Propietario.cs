using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string NumeroIdentificacion { get; set; }
        public required string Direccion { get; set; }
        public required string Telefono { get; set; }
        public required string Correo { get; set; }

    }
}