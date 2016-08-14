using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input the distance travelled: ");
            string meterInput = Console.ReadLine();
            double meter = Convert.ToDouble(meterInput);

            double total = CalculateFare(meter);

            Console.WriteLine("The total fare is {0:0.00}. (rounded upwards to nearest 10 cents)", total);
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double charge = 2.40 + distance * 0.4;
            double pay = Math.Ceiling(charge*10);
            double final = pay / 10;

            return (final);

        }
    }
}
