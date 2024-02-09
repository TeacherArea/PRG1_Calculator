using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1_Calculator
{
    internal class Quot : IQuot
    {
        double IQuot.Divide(double a, double b)
        {
            return a / b;
        }
    }
}
