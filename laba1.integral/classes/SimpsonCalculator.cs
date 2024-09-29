using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.integral.classes
{
    public class SimpsonCalculator : Icalculator
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            if (count % 2 != 0)
            {
                throw new ArgumentException("Количество подынтервалов должно быть четным.");
            }

            double partLength = (upper - lower) / count;
            double answer = func(lower) + func(upper); // Начинаем с крайних значений

            // Суммируем значения функции на нечетных индексах
            for (int i = 1; i < count; i += 2)
            {
                double x = lower + i * partLength;
                answer += 4 * func(x);
            }

            // Суммируем значения функции на четных индексах
            for (int i = 2; i < count - 1; i += 2)
            {
                double x = lower + i * partLength;
                answer += 2 * func(x);
            }

            answer *= partLength / 3; // Умножаем на h/3
            return answer;
        }
    }
}
