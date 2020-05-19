using System;

namespace Softplan.DesafioTecnico.Application.Extensions
{
    public static class ValueExtension
    {
        public static double Truncate(double value, int precision)
        {
            return Math.Truncate(value * Math.Pow(10, precision)) / Math.Pow(10, precision);
        }
    }
}
