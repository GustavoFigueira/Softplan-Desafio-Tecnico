using Softplan.DesafioTecnico.Domain.Entities;

namespace Softplan.DesafioTecnico.Domain.Interfaces
{
    public interface ICompoundInterestService
    {
        CompoundInterest Calculate(decimal initialValue, double interestRate, int period);
    }
}
