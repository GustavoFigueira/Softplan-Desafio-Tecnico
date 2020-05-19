using Softplan.DesafioTecnico.Domain.Entities.Base;

namespace Softplan.DesafioTecnico.Domain.Entities
{
    public class CompoundInterest : BaseEntitiy
    {
        public CompoundInterest(decimal initialValue, decimal finalValue, double interestRate, int period)
        {
            InitialValue = initialValue;
            FinalValue = finalValue;
            InterestRate = new InterestRate(interestRate);
            Period = period;
        }

        /// <summary>
        /// Valor monetário inicial.
        /// </summary>
        public decimal InitialValue { get; set; }

        /// <summary>
        /// Valor monetário final.
        /// </summary>
        public decimal FinalValue { get; set; }

        /// <summary>
        /// Valor da taxa de juros (%)
        /// </summary>
        public InterestRate InterestRate { get; set; }

        /// <summary>
        /// Tempo em meses
        /// </summary>
        public decimal Period { get; set; }
    }
}
