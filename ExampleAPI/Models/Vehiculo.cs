using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.Models
{

    // [Table("vehiculos")]
    public class Vehiculo
    {
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int PropietarioID { get; set; }
        public required int Año { get; set; }
        public required string Color { get; set; }
        public string? TipoVehiculo { get; set; }
        public required string NumeroChasis { get; set; }

        //Enlaces foraneos
        [ForeignKey("PropietarioID")]
        public required Propietario Propietario { get; set; }
    }
}