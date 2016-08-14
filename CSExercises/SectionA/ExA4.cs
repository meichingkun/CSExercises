using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes a double precision number as input 
    //and prints the square of that number
    //For this exercise, you need to implement the square function
    //and handle the input and output in the Main method (use Exercise 2 as an example)

    public class ExA4
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string inputRealNumber = Console.ReadLine();
            Double realNumber = Convert.ToDouble(inputRealNumber);

            Double result = square(realNumber);

            Console.WriteLine("The square of the number is " + result);                       
        }

        public static double square(double x)
        {            
            return x*x;
        }
    }
}
