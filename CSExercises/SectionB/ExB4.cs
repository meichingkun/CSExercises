using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input the temperature in Centigrade: ");
            string inputCel = Console.ReadLine();
            double celTemp = Convert.ToDouble(inputCel);
            double fahTemp = ConvertToFahrenheit(celTemp);

            Console.WriteLine("The temperature in Fahrenheit is " + fahTemp + ".");
        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            double fahFormula = (1.8 * c) + 32;
            return (fahFormula);

        }
    }
}
