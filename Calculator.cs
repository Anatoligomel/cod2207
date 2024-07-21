using System;
using Xunit;

namespace HOMEWORK22._07
{
    public class Calculator : ICalculator
    {
        public double Cos(double angle)
        {
            // Заглушка для метода Cos
            return Math.Cos(angle);
        }

        public double Sin(double angle)
        {
            // Заглушка для метода Sin
            return Math.Sin(angle);
        }

       
    }
}