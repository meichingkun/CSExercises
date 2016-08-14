using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input the distance travelled: ");
            string meterInput = Console.ReadLine();
            double meter = Convert.ToDouble(meterInput);

            double total = CalculateFare(meter);

            Console.WriteLine("The total fare is: " +total +".");
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double charge = 2.40 + distance * 0.4;              
            return (charge);

        }
    }
}
