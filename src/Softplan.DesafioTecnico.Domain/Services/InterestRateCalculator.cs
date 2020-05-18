using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Services
{
    public class InterestRateCalculator : IInterestRateCalculator
    {
        public InterestRateCalculator()
        {

        }

        /// <summary>
        /// Calcula a taxa de juros com base no valor inicial, nos juros e no tempo em meses.
        /// </summary>
        /// <param name="initialValue">Valor inicial</param>
        /// <param name="interestRate">Juros</param>
        /// <param name="period">Tempo (meses)</param>
        /// /// <param name="precision">Número de casas decimais (padrão = 2)</param>
        /// <returns></returns>
        public double Calculate(decimal initialValue, double interestRate, int period, int precision = 2)
        {
            double interestRateValue = Math.Pow((double) initialValue * (1 + interestRate), period);

            var finalInterestRate = Truncate(interestRateValue, 2);

            return finalInterestRate;
        }

        private double Truncate(double valor, int precisao)
        {
            return Math.Truncate(valor * Math.Pow(10, precisao)) / Math.Pow(10, precisao);
        }
    }
}
