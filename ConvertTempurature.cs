using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public static class ConvertTempurature
    {
       
            
            public static double CelsiusFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            
            public static double FahrenheitCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            
            public static double ToFahrenheit(this double celsius)
            {
                return CelsiusFahrenheit(celsius);
            }

           
            public static double ToCelsius(this double fahrenheit)
            {
                return FahrenheitCelsius(fahrenheit);
            }
    }
}

