using Softplan.DesafioTecnico.Application.Extensions;
using Softplan.DesafioTecnico.Domain.Entities;
using Softplan.DesafioTecnico.Domain.Services;
using System;

namespace Softplan.DesafioTecnico.Application.Services
{
    public class CompoundInterestService : ICompoundInterestService
    {
        /// <summary>
        /// Calcula a taxa de juros com base no valor inicial, nos juros e no tempo em meses.
        /// </summary>
        /// <param name="initialValue">Valor monetário inicial</param>
        /// <param name="finalValue">Valor monetário final</param>
        /// <param name="interestRate">Juros</param>
        /// <param name="period">Tempo (meses)</param>
        /// <returns></returns>
        public CompoundInterest Calculate(decimal initialValue, double interestRate, int period)
        {
            decimal finalInterestRate = initialValue * (decimal)Math.Pow(1 + interestRate, period);

            var truncatedInterestRate = ValueExtension.TruncateDecimal(finalInterestRate, 2);

            return new CompoundInterest(initialValue, truncatedInterestRate, interestRate, period);
        }
    }
}
