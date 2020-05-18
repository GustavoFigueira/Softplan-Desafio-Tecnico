using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.SecondApi.Models;

namespace Softplan.DesafioTecnico.SecondApi.Controllers
{
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;

        public AboutController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet]
        [Route("showmethecode")]
        public IActionResult ShowMeTheCode()
        {
            try
            {
                var showMeTheCode = _appSettings.Value.RepositoryUrl;

                return Ok(showMeTheCode);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
    }
}
