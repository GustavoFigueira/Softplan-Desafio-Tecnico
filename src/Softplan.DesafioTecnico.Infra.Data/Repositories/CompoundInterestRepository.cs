using Softplan.DesafioTecnico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Infra.Data.Repositories
{
    public class CompoundInterestRepository
    {
        public InterestRate GetCompountInterest()
        {
            return new InterestRate { 
                Value = 0.01
            };
        }
    }
}
