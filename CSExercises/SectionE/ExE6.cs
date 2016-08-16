using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here
            for (int num = 1; num <= 1000; num++)
            {
                if (ExE4.IsPerfectNumber(num) == true)
                {
                    Console.WriteLine(num);
                }
            }
                      
        }
    }
}
