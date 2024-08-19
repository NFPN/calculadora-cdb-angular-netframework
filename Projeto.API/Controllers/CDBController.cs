using Projeto.API.Models;
using Projeto.API.Service;
using System;
using System.Web.Http;

namespace Projeto.API.Controllers
{
    public class CdbController : ApiController
    {
        private readonly ICdbService cdbService;

        public CdbController(ICdbService service)
        {
            cdbService = service;
        }

        [Route("api/CalculaCDB")]
        [HttpPost]
        public IHttpActionResult CalculaCDB([FromBody] CdbInputModel input)
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

        [Route("api/test")]
        [HttpPost]
        public IHttpActionResult Test([FromBody] object input)
        {
            var test = input;

            return Ok(test);
        }
    }
}
