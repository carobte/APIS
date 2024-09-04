using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleAPI.Models;
using ExampleAPI.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ExampleAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var data = DatabaseSeeder.PropietariosSeeders(100); // Ejecutamos el método que ingresa fake data.

            modelBuilder.Entity<Propietario>(propietario =>
            {
                propietario.ToTable("propietarios");
                propietario.HasKey(p => p.Id);
                propietario.Property(p => p.Id).ValueGeneratedOnAdd();
                propietario.Property(p => p.Nombre).HasMaxLength(100).IsRequired();
                propietario.Property(p => p.Apellido).HasMaxLength(100).IsRequired();
                propietario.Property(p => p.FotoPerfil).HasMaxLength(100).IsRequired();
                propietario.Property(p => p.Direccion).HasMaxLength(200).IsRequired();
                propietario.Property(p => p.Telefono).HasMaxLength(25).IsRequired();
                propietario.Property(p => p.Direccion).HasMaxLength(255).IsRequired();
                propietario.Ignore(p => p.ColorDePelo);
                propietario.HasData(data);
            });

            modelBuilder.Entity<Vehiculo>(vehiculo =>
            {
                vehiculo.ToTable("vehiculos"); // Data  Annotations de [Table("vehiculos")]
                vehiculo.HasKey(v => v.Id);
                vehiculo.Property(v => v.Id).ValueGeneratedOnAdd();
                vehiculo.Property(v => v.Marca).HasMaxLength(100).IsRequired();
                vehiculo.Property(v => v.Modelo).HasMaxLength(50).IsRequired();
                vehiculo.Property(v => v.PropietarioID).IsRequired();
                vehiculo.Property(v => v.Año).HasMaxLength(4).IsRequired();
                vehiculo.Property(v => v.Color).HasMaxLength(50).IsRequired();
                vehiculo.Property(v => v.TipoVehiculo).HasMaxLength(50).IsRequired(false); // False sirve para que una propiedad sea opcional
                vehiculo.Property(v => v.NumeroChasis).HasMaxLength(25).IsRequired();

                vehiculo.HasOne(v => v.Propietario) // Relacion uno a muchos
                        .WithMany(p => p.Vehiculos) // Coleccion de vehiculos en Propietario
                        .HasForeignKey(v => v.PropietarioID); // Clave foranea en Vehiculo
            });
        }
    }
}