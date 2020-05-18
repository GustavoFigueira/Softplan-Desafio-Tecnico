using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.FirstApi.Models;

namespace Softplan.DesafioTecnico.FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestRateController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;

        public InterestRateController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet]
        [Route("TaxaJuros")]
        public IActionResult InterestRate()
        {
            try
            {
                var interestRate = _appSettings.Value.InterestRate;

                return Ok(interestRate);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}