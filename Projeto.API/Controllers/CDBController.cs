using Projeto.API.Models;
using Projeto.API.Service;
using System;
using System.Web.Http;

namespace Projeto.API.Controllers
{
    public class CDBController : ApiController
    {
        private readonly ICDBService cdbService;

        public CDBController(ICDBService service)
        {
            cdbService = service;
        }

        [Route("api/CalculaCDB")]
        [HttpPost]
        public IHttpActionResult CalculaCDB([FromBody] CDBInputModel input)
        {
            if (input == null || input.ValorInicial <= 0 || input.Meses < 1)
                return BadRequest("Os parâmetros de entrada são inválidos.");

            try
            {
                var result = cdbService.CalcularCDB(input.ValorInicial, input.Meses);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
