using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double F = 0;
        public static double C = 0;
        public static double FahrenheitToCelcius(double fTemp)
        {
            C = (fTemp - 32) / 1.8000;
            return C;
        }
        public static double CelciusToFahrenheit(double cTemp)
        {
            
            F = (cTemp * (9 / 5)) + 32;
                return F;
        }
    }
}
