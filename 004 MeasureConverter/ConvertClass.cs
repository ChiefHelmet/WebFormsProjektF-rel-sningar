using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MeasureConverter
{
    class ConvertClass
    {
        public static double MetersToFeet(double Meters)
        {
            return Meters/0.304800610;
        }

        public static double FeetToMeters(double Feet)
        {
            return Feet*0.04800610;
        }
    }
}
