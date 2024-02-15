using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1_Calculator.Services
{
    internal class DataContainer
    {
        public double Value { get; set; }

        public DataContainer(double value)
        {
            Value = value;
        }
    }
}
