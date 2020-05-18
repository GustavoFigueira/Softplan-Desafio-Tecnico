using Softplan.DesafioTecnico.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Entities
{
    public class InterestRate : BaseEntitiy
    {
        /// <summary>
        /// Valor da taxa de juros (%)
        /// </summary>
        public decimal Value { get; set; }
    }
}
