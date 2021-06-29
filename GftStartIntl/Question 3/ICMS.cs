using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class ICMS : ITaxes
    {
        public double CalculateTaxes(double value)
        {
            if (value > 17000)
            {
                return value + (value * 0.08);
            }

            return value;
        }
    }
}
