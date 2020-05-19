using Softplan.DesafioTecnico.Application.Services;
using Softplan.DesafioTecnico.Domain.Services;
using System.Diagnostics;
using Xunit;

namespace Softplan.DesafioTecnico.UnitTests.Tests
{
    public class CompoundInterestTest
    {
        private readonly ICompoundInterestService compoundInterestService;

        public CompoundInterestTest()
        {
            compoundInterestService = new CompoundInterestService();
        }

        [Theory]
        [InlineData(100, 0.01, 5)]
        public void First_Calculation_Scenario_Is_Correct(decimal initialValue, double interestRate, int period)
        {
            var result = compoundInterestService.Calculate(initialValue, interestRate, period);

            Debug.Write(result);

            Assert.Equal(105.10, (double)result.FinalValue);
        }
    }
}
