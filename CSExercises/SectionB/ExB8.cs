using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input the distance travelled: ");
            string meterInput = Console.ReadLine();
            double meter = Convert.ToDouble(meterInput);

            double total = CalculateFare(meter);

            Console.WriteLine("The total fare is {0:0.00}. (rounded to nearest 10 cents)", total);
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double charge = 2.40 + distance * 0.4;
            double pay = Math.Round(charge, 1);
           
            return (pay);            

        }
    }
}
