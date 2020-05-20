using Microsoft.Extensions.Options;
using Softplan.DesafioTecnico.FirstApi.Models;
using Softplan.DesafioTecnico.UnitTests.Context;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.DesafioTecnico.UnitTests.Tests
{
    public class InterestRateTest
    {
        private readonly TestsContext _testsContext;

        public InterestRateTest()
        {
            _testsContext = new TestsContext();
        }

        [Fact]
        public async Task Get_Default_Interest_Rate()
        {
            var response = await _testsContext.FirstClient.GetAsync("/InterestRate/GetDefault");
            double.TryParse(response.Content.ToString(), out double interestRate);

            Assert.Equal(0.01, interestRate);
        }
    }
}
