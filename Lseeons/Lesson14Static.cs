using System;

/* This class goes over Lesson 14 content
Static */
namespace C_Class.Lseeons
{
    public static class Lesson14Static
    {
        static readonly int baseTemp;

        static Lesson14Static()
        {
            baseTemp = 32;
        }

        // static method 1
        public static void CelsiusToFahrenheit(string temperature)
        {
            double celsius = Double.Parse(temperature);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine(fahrenheit);
        }

        public static void FahrenheitToCelsius(string temperature)
        {
            double fahrenheit = Double.Parse(temperature);
            double celsius = (fahrenheit - baseTemp) * 5/9;
            Console.WriteLine(celsius);
        }

    }
}