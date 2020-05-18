using Softplan.DesafioTecnico.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Entities
{
    public class CompoundInterest : BaseEntitiy
    {
        /// <summary>
        /// Valor monetário inicial.
        /// </summary>
        public decimal InitialValue { get; set; }

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
