using FluentValidation;
using Softplan.DesafioTecnico.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Validations
{
    public abstract class CompoundInterestValidator<T> : AbstractValidator<T> where T : CompoundInterestCommand
    {
      
    }
}
