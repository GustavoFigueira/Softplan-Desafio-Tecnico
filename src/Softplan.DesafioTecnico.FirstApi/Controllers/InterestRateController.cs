using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.Domain.Entities;
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
        [Route("GetDefault")]
        public IActionResult GetDefault()
        {
            try
            {
                var interestRate = new InterestRate(_appSettings.Value.InterestRate).Value;

                return Ok(interestRate);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}