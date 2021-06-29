using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class IPI : ITaxes
    {
        public double CalculateTaxes(double value)
        {
            if (value < 25000)
            {
                return value + (value * 0.05);
            }

                return value + (value * 0.1);
        }
    }
}
