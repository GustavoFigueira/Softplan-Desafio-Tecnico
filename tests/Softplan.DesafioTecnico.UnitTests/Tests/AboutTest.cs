using Softplan.DesafioTecnico.UnitTests.Context;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.DesafioTecnico.UnitTests.Tests
{
    public class AboutTest
    {
        private  TestsContext _testsContext;

        public AboutTest()
        {
            _testsContext = new TestsContext();
        }

        [Fact]
        public async Task InterestRate_Should_ReturnDefaultUrl()
        {
            var response = await _testsContext.SecondClient.GetAsync("/ShowMeTheCode");

            Debug.Write(response);

            const string repositoryUrl = "https://github.com/GustavoFigueira/Softplan-Desafio-Tecnico";

            Assert.NotNull(response);
            Assert.Equal(repositoryUrl, response.Content.ToString());
        }
    }
}
