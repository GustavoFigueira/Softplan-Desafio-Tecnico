namespace Softplan.DesafioTecnico.Domain.Entities
{
    public class InterestRate
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
