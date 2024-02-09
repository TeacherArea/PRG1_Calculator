using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1_Calculator
{
    internal class Sum : ISum
    {
        double ISum.Add(double a, double b)
        {
            return a + b;
        }
    }
}
