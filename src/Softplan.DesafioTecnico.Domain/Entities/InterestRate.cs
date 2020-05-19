using Softplan.DesafioTecnico.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Entities
{
    public struct InterestRate
    {
        /// <summary>
        /// Valor da taxa de juros
        /// </summary>
        public double Value { get; set; }

        public InterestRate(double _value)
        {
            Value = _value;
        }
    }
}
