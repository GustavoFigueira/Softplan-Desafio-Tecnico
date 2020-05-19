using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Softplan.DesafioTecnico.Domain.Interfaces;
using Softplan.DesafioTecnico.SecondApi.Models;

namespace Softplan.DesafioTecnico.SecondApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        ICompoundInterestService _compoundInterestService;

        public CompoundInterestController(IOptions<AppSettings> appSettings, ICompoundInterestService compoundInterestService)
        {
            _appSettings = appSettings;
            _compoundInterestService = compoundInterestService ?? throw new ArgumentNullException(nameof(compoundInterestService));
        }

        [HttpGet]
        [Route("CalculaJuros")]
        public async Task<IActionResult> Get([FromQuery] decimal valorInicial, [FromQuery] int tempo)
        {
            try
            {
                var interestRate = await GetInterestRateFromApi();

                var compoundInterest = _compoundInterestService.Calculate(valorInicial, interestRate, tempo);

                if (compoundInterest == null)
                    return BadRequest("Não foi possível efetuar o cálculo.");


                return Ok(compoundInterest.FinalValue);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        public async Task<double> GetInterestRateFromApi()
        {
            var client = new RestClient(_appSettings.Value.FirstApiUrl);
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                var interestRate = content.Value<double>();
                return interestRate;
            }

            return 0;
        }
    }
}