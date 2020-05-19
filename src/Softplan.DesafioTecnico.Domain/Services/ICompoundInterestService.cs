using Softplan.DesafioTecnico.Domain.Entities;

namespace Softplan.DesafioTecnico.Domain.Services
{
    public interface ICompoundInterestService
    {
        CompoundInterest Calculate(decimal initialValue, double interestRate, int period);
    }
}
