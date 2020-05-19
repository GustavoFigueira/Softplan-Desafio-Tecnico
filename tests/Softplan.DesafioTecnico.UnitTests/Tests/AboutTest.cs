using FluentAssertions;
using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.SecondApi.Models;
using Softplan.DesafioTecnico.UnitTests.Context;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.DesafioTecnico.UnitTests.Tests
{
    public class AboutTest
    {
        private readonly TestsContext _testsContext;
        private readonly IOptions<AppSettings> _appSettings;

        public AboutTest()
        {
            _testsContext = new TestsContext();
        }

        [Fact]
        public async Task InterestRate_Should_ReturnDefaultValue()
        {
            var response = await _testsContext.SecondClient.GetAsync("/ShowMeTheCode");

            var repositoryUrl = _appSettings.Value.RepositoryUrl;

            Assert.NotNull(response);
            Assert.Equal(repositoryUrl, response.Content.ToString());
        }
    }
}
