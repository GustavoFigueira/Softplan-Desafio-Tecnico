using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.DesafioTecnico.Domain.Commands
{
    public abstract class Command
    {
        public Guid Id { get; private set; }

        public Command()
        {

        }
    }
}
