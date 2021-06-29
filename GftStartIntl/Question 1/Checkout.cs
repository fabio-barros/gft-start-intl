using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Checkout
    {
        private double _totalCost { get; set; }
        private double _costWithDiscount { get; set; }

        public double ComputeFinalValue(Product prod, int qty)
        {
            _totalCost = prod.Value * qty;

            switch (prod.Type)
            {
                case 1:
                     _costWithDiscount = _totalCost - (_totalCost *= 0.1);
                     break;
                case 2:
                     _costWithDiscount = _totalCost - (_totalCost *= 0.2);
                     break;
                case 3:
                    if (qty > 5)
                    {
                        _costWithDiscount = _totalCost - (_totalCost *= 0.2);
                    }
                    break;
                default:
                    _costWithDiscount = _totalCost;
                    break;
            }
            return _costWithDiscount;

        }
    }
}
