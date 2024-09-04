using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using ExampleAPI.Models;

namespace ExampleAPI.Seeders
{
    public class DatabaseSeeder
    {
        public static List<Propietario> PropietariosSeeders(int cantidad)
        {
            var faker = new Faker<Propietario>(
            )
            .RuleFor(p => p.Nombre, f => f.Name.FirstName())
            .RuleFor(p => p.Apellido, f => f.Name.LastName())
            .RuleFor(p => p.NumeroIdentificaion, f => f.Random.AlphaNumeric(10))
            .RuleFor(p => p.FotoPerfil, f => f.Internet.Avatar())
            .RuleFor(p => p.Direccion, f => f.Address.FullAddress())
            .RuleFor(p => p.Telefono, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Correo, f => f.Internet.Email())
            .RuleFor(p => p.ColorDePelo, f => f.Commerce.Color())  // Genera un color aleatorio
            .RuleFor(p => p.Vehiculos, f => new List<Vehiculo>()); // Asocia una lista vacía de Vehículos por ahora

            return faker.Generate(cantidad); // retornamos la lista
            // Se crea una nueva migración y se hace el update.
        }

    }
}