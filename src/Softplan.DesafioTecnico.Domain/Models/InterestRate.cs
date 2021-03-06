﻿using Softplan.DesafioTecnico.Domain.Entities.Base;

namespace Softplan.DesafioTecnico.Domain.Entities
{
    public class InterestRate : BaseEntity
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
