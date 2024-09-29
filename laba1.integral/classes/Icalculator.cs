using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.integral.classes
{
    internal interface Icalculator
    {
        double Calculate(double lower, double upper, int count, Func<double, double> func);
    }
}
