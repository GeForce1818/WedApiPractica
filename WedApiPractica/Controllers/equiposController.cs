using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiPractica.Models;
using Microsoft.EntityFrameworkCore;
using WedApiPractica.Models;

namespace WedApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContex _equiposContexto;

        public equiposController (equiposContex equipoContexto)
        {
            this._equiposContexto = equipoContexto;
        }
        /// <summary>
        /// EndPoint que retorna el listado de todos los equipos existentes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<equipos> listadoEquipo = (from e in _equiposContexto.equipos
                                           select e).ToList();

            if (listadoEquipo.Count == 0)
            {
                return NotFound();
            }

            return Ok(listadoEquipo);
        }

    }

}

