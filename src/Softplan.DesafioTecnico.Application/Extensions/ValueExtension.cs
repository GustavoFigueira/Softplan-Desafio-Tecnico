using System;

namespace Softplan.DesafioTecnico.Application.Extensions
{
    public static class ValueExtension
    {
        // Trunca os decimais sem o problema do Trailling Zero
        public static decimal TruncateDecimal(decimal value, int precision)
        {
            return Math.Truncate(value * (decimal)Math.Pow(10, precision)) / (decimal)Math.Pow(10, precision);
        }
    }
}
