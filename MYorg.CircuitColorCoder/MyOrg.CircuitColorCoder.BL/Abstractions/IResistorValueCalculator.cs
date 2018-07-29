using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrg.CircuitColorCoder.BL.Abstractions
{
    public interface IResistorValueCalculator
    {

        long CalculateResistorValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        double GetTolerance(string bandDColor);
    }
}
