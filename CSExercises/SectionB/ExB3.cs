﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please input salary: ");
            string salary = Console.ReadLine();
            string total = CalculateIncome(salary);

            Console.WriteLine("The total income is " + total + ".");
        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            double income = Convert.ToDouble(salaryStr);
            double plusAllow = income / 100 * 113;

            string overall = String.Format("{0:C}", plusAllow);
                         

            return(overall);
        }
    }
}
