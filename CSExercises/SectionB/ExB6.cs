using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input the value of X1: ");
            string inputFX = Console.ReadLine();
            Console.Write("Please input the value of Y1: ");
            string inputFY = Console.ReadLine();
            Console.Write("Please input the value of X2: ");
            string inputSX = Console.ReadLine();
            Console.Write("Please input the vlaue of Y2: ");
            string inputSY = Console.ReadLine();

            double FX = Convert.ToDouble(inputFX);
            double FY = Convert.ToDouble(inputFY);
            double SX = Convert.ToDouble(inputSX);
            double SY = Convert.ToDouble(inputSY);

            double result = CalculateDistance(FX, FY, SX, SY);

            Console.WriteLine("The distance between the two points is: " + result + ".");

        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return(Distance);
        }
    }
}
