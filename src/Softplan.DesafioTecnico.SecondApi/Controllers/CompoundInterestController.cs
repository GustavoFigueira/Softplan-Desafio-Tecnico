using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Softplan.DesafioTecnico.Domain.Services;
using Softplan.DesafioTecnico.SecondApi.Models;

namespace Softplan.DesafioTecnico.SecondApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private ICompoundInterestService _compoundInterestService;

        public CompoundInterestController(IOptions<AppSettings> appSettings, ICompoundInterestService compoundInterestService)
        {
            _appSettings = appSettings;
            _compoundInterestService = compoundInterestService;
        }

        /// <summary>
        /// Calcula os Juros Compostos com base nos parâmetros de entrada.
        /// Caso a Taxa de Juros não seja fornecida, ela é buscada na primeira API que deve estar em execução.
        /// </summary>
        /// <param name="initialValue">Valor inicial</param>
        /// <param name="period">Tempo (em meses)</param>
        /// <param name="interestRate">Taxa de Juros (opcional)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Calculate")]
        public async Task<IActionResult> Calculate([FromQuery] decimal initialValue, [FromQuery] int period, [FromQuery] double? interestRate)
        {
            try
            {
                var defaultInterestRate = interestRate;

                if (defaultInterestRate == null)
                    defaultInterestRate = await GetInterestRateFromApi();

                var compoundInterest = _compoundInterestService.Calculate(initialValue, defaultInterestRate.GetValueOrDefault(), period);

                if (compoundInterest == null)
                    return BadRequest("Não foi possível calcular os Juros Compostos.");

                return Ok(compoundInterest.FinalValue);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        /// <summary>
        /// Retorna a Taxa de Juro de uma API em um outro projeto na mesma solução
        /// </summary>
        /// <returns></returns>
        private async Task<double> GetInterestRateFromApi()
        {
            var client = new RestClient(_appSettings.Value.FirstApiUrl);
            var request = new RestRequest("api/InterestRate/GetDefault", DataFormat.None);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                var interestRate = content.Value<double>();
                return interestRate;
            }

            return 0.01;
        }
    }
}