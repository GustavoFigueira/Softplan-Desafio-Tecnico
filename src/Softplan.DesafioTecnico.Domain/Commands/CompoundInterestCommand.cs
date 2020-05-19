using Softplan.DesafioTecnico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Commands
{
    public class CompoundInterestCommand
    {
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
