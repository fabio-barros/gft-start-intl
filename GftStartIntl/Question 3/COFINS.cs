using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class COFINS : ITaxes
    {
        public double CalculateTaxes(double value)
        {
            return value + (value * 0.3);
        }
    }
}
