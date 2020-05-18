using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Services
{
    public interface IInterestRateCalculator
    {
        double Calculate(decimal initialValue, double interestRate, int period, int precision);
    }
}
