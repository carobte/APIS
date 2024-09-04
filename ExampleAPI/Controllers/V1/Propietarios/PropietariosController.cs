using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExampleAPI.Controllers.V1.Propietarios
{
    [ApiController]
    [Route("api/V1/[controller]")] // Para saber donde buscar, se pone una vez
    public class PropietariosController : ControllerBase
    {
        // Atributo para consumir la API
        private readonly ApplicationDBContext ConexionDB;

        // Constructor 
        public PropietariosController(ApplicationDBContext conexionDB)
        {
            ConexionDB = conexionDB;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            
            // Leer propietarios de la DB

            var PropietariosDB = await ConexionDB.Propietarios.ToListAsync();
            return Ok(PropietariosDB);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            var Propietario = await ConexionDB.Propietarios.FirstOrDefaultAsync(p=> p.Id == id);
            return Ok(Propietario);
        }

        [HttpGet("p/{nombre}")]
        public async Task<IActionResult> GetByName(string nombre){
            var Propietario = await ConexionDB.Propietarios.FirstOrDefaultAsync(p=> p.Nombre == nombre);
            return Ok(Propietario);
        }

    }
}