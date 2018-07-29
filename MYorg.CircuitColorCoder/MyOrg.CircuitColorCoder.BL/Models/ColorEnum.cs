using MyOrg.CircuitColorCoder.BL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrg.CircuitColorCoder.BL.Models
{
    public enum BandA
    {
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Gray,
        White
    }

    public enum BandB
    {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Gray,
        White
    }

    public enum BandC
    {
        [Multiplier(1)]
        Black,
        [Multiplier(10)]
        Brown,
        [Multiplier(100)]
        Red,
        [Multiplier(1000)]
        Orange,
        [Multiplier(10000)]
        Yellow,
        [Multiplier(100000)]
        Green,
        [Multiplier(1000000)]
        Blue,
        [Multiplier(10000000)]
        Violet,
        [Multiplier(100000000)]
        Gray,
        [Multiplier(1000000000)]
        White,
        [Multiplier(0.1)]
        Gold,
        [Multiplier(0.01)]
        Silver
    }

    public enum BandD
    {
        [Tolerence(1)]
        Brown,
        [Tolerence(2)]
        Red,
        [Tolerence(.5)]
        Green,
        [Tolerence(.25)]
        Blue,
        [Tolerence(.1)]
        Violet,
        [Tolerence(.05)]
        Gray,
        [Tolerence(5)]
        Gold,
        [Tolerence(10)]
        Silver
    }
}



