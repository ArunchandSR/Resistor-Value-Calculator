using MyOrg.CircuitColorCoder.BL.Abstractions;
using MyOrg.CircuitColorCoder.BL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOrg.CircuitColorCoder.BL.Utilities;

namespace MyOrg.CircuitColorCoder.BL.Implementations
{
    public class ResistorValueCalculator : IResistorValueCalculator
    {
        public long CalculateResistorValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            long CalculatedValue;
            BandA _bandA; BandB _bandB = 0; BandC _bandC = 0;
            bool IsValidColorCodes = (Enum.TryParse<BandA>(bandAColor, out _bandA) &&
                    Enum.TryParse<BandB>(bandBColor, out _bandB) &&
                    Enum.TryParse<BandC>(bandCColor, out _bandC));

            CalculatedValue =  IsValidColorCodes ?  (long)(Extensions.GetColorAppenderValue(_bandA, _bandB) * _bandC.GetAttribute<MultiplierAttribute>().Multiplier) 
                : throw new InvalidOperationException("Color Codes are not Valid");
            return CalculatedValue;
        }

        public double GetTolerance(string bandDColor)
        {
            BandD _bandD;
            bool IsValidColorCodes=Enum.TryParse<BandD>(bandDColor, out _bandD);
            return _bandD.GetAttribute<TolerenceAttribute>().Tolerence;

        }
      
    }
}
