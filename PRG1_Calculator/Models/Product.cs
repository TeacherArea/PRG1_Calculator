using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG1_Calculator.Models;

namespace PRG1_Calculator
{
    internal class Product : IProduct
    {
        double IProduct.Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
