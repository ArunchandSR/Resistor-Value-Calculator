using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrg.CircuitColorCoder.BL.Utilities
{
    public class TolerenceAttribute : Attribute
    {
        public TolerenceAttribute(double value)
        {
            Tolerence = value;
        }
        public double Tolerence { get; set; }
    }
   
}
