using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int Año { get; set; }
        public required string Color { get; set; }
        public required string Tipo { get; set; }
        public required int PropietarioId { get; set; } // Referencia a la FK

        // Enlaces FK 
        [ForeignKey("PropietarioId")] // Conexión 
        public Propietario? Propietario { get; set; }


    }
}