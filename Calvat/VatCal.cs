using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class VatCal
    {
        public static double TotalPrice(double price,double vat)
        {
            
            return (price * (vat / 100)) + price;
        }
        public static double VatPrice(double price,double vat)
        {
            return ( price * vat ) / 100;
        }
    }
}
