using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers.V1.Propietarios
{
    [ApiController]
    [Route("api/V1/[controller]")]
    public class PropietariosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get(){
            return Ok("hola mundo, mi primer endpoint");
        }
    }
}