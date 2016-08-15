using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100?99.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input a 3 digit integer: ");
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            if(value >999 || value <100)
            {
                Console.WriteLine("The input is invalid.");
            }
            else
            {
                bool output = IsArmstrongNumber(value);
                if (output == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
           
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            int third = n % 10;
            int second = (n / 10) % 10;
            int first = n/100;

            int number = (third*third*third)+(second*second*second)+(first*first*first);

            if (number == n)
            {
                return true;
            }
            else
            {
                return false;
            }
  
        }
    }
}