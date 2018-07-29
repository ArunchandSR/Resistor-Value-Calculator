using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrg.CircuitColorCoder.BL.Utilities
{
    public class MultiplierAttribute : Attribute
    {
        public MultiplierAttribute(double value)
        {
            Multiplier = value;
        }
        public double Multiplier { get; set; }
    }
   
}
