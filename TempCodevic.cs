using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNc
{
    public class Temperature
    {
        private int celsius = 0;
        private int farenheit = 0;
        private int kelvin = 0;
        private string key = "Farenheit";
        private int num = 10;

        public Temperature()
        {
            celsius = 0;
            farenheit = 0;
            kelvin = 0;

        }
        public bool Fahrenheit(int num, string key)
        {

            if (key == "farenheit")
            {
                celsius = (int)(num - 32) * 5 / 9;
                farenheit = num;
                kelvin = (int)((int)(num - 32) * 5 / 9 + 273.15);
               
            }
            return true;

        }
        public bool Celsius(int num, string key)
        {
            if (key == "celcius")
            {

                celsius = num;
                farenheit = (int)(num * 1.8) + 32;
                kelvin = (int)(num + 273.15);

            }
            return true;
        }
        public bool Kelvin(int num, string key)
        {

            if (key == "kelvin")
            {
                celsius = (int)(num - 273.15);
                farenheit = (int)(num - 273.15) * 9 / 5 + 32;
                kelvin = num;

            }
            return true;

        }
    }
}