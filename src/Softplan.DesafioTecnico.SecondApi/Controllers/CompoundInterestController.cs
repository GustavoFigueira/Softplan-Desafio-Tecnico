using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.SecondApi.Models;

namespace Softplan.DesafioTecnico.SecondApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {
        [HttpGet]
        [Route("CalculaJuros")]
        public IActionResult Get([FromQuery] decimal valorInicial)
        {
            try
            {
                var interestValue = valorInicial;

                return Ok(interestValue);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}