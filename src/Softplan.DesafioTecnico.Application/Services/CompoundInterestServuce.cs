using Softplan.DesafioTecnico.Application.Extensions;
using Softplan.DesafioTecnico.Domain.Entities;
using Softplan.DesafioTecnico.Domain.Interfaces;
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
            double finalInterestRate = Math.Pow((double)initialValue * (1 + interestRate), period);

            var truncatedInterestRate = ValueExtension.Truncate(finalInterestRate, 2);

            return new CompoundInterest(initialValue, Convert.ToDecimal(truncatedInterestRate), interestRate, period);
        }
    }
}
