using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Propietario> Propietarios{get;set;}
        public DbSet<Vehiculo> Vehiculos{get;set;}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}