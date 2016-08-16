using System;

namespace CSExercises
{
    //Given an integer as input write a C# program to determine 
    //whether the number is a Perfect Number or not.

    //A perfect number is one for which the sum of its factors
    //    (including number one) add up to the number itself.For example 
    //        number six is a perfect number because,
    //		6 = 1 + 2 + 3.


    public class ExE4
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectNumber(n)==true)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }

        public static bool IsPerfectNumber(int n)
        {
            //YOUR CODE HERE
            bool IsPerfectNumber = true;
            int test = 0;
                         
            for (int num = 1; num < n; num++)
            {
                if(n%num==0)
                {
                    test = test + num;
                }
            }
             
            if(test == n)
            {
                IsPerfectNumber = true;
            }
            else
            {
                IsPerfectNumber = false; 
            }
            return IsPerfectNumber;


        }
    }
}
