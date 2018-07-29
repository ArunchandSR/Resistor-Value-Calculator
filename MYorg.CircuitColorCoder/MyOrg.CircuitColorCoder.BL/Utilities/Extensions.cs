using MyOrg.CircuitColorCoder.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrg.CircuitColorCoder.BL.Utilities
{
        public static class Extensions
        {
            public static TAttribute GetAttribute<TAttribute>(this Enum value)
                where TAttribute : Attribute
            {
                var type = value.GetType();
                var name = Enum.GetName(type, value);
                return type.GetField(name) 
                    .GetCustomAttributes(false)
                    .OfType<TAttribute>()
                    .SingleOrDefault();
            }
          
        public static int GetColorAppenderValue(BandA bandA,BandB bandB)
        {
            bandA = bandA + 1;
            return Convert.ToInt32((((int)bandA).ToString() + ((int)bandB).ToString()));
        }

        }

 }

