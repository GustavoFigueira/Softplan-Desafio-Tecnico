using System;

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
