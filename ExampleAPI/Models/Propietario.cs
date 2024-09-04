using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace ExampleAPI.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [MinLength(5, ErrorMessage = "The Name field must be more than {5} characters.")]
        [MaxLength(125, ErrorMessage = "The Name field must be less than {125} characters.")]
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string NumeroIdentificaion { get; set; }

        [MaxLength(100, ErrorMessage = "The Name field must be less than {125} characters.")]
        [Url(ErrorMessage = "The FotoPerfil field must be a valid URL.")]
        public required string FotoPerfil { get; set; }
        public required string Direccion { get; set; }


        [MinLength(5, ErrorMessage = "The Phone field must be more than {5} characters.")]
        [MaxLength(25, ErrorMessage = "The Phone field must be less than {125} characters.")]
        [Phone(ErrorMessage = "Invalid Phone Format.")]
        public required string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Format.")]
        [MinLength(5, ErrorMessage = "The Email field must be more than {5} characters.")]
        [MaxLength(255, ErrorMessage = "The Email field must be less than {125} characters.")]
        public required string Correo { get; set; }

        [NotMapped]
        public required string ColorDePelo { get; set; }

        // Enlace a la tabla vehiculo
        // Enlaces foraneos
        [JsonIgnore]
        public virtual ICollection<Vehiculo>? Vehiculos { get; set; }
    }
}