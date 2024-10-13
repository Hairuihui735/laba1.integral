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
            if (count <= 0)
            {
                throw new ArgumentException("количество разбиений должно быть больше 0");
            }

            double partLength = (upper - lower) / count;
            double answer = func(lower) + func(upper); 

            for (int i = 1; i < count; i += 2)
            {
                double x = lower + i * partLength;
                answer += 4 * func(x);
            }

            
            for (int i = 2; i < count - 1; i += 2)
            {
                double x = lower + i * partLength;
                answer += 2 * func(x);
            }

            answer *= partLength / 3; 
            return answer;
        }
    }
}
