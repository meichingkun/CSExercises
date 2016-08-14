using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
           Console.Write("Please input value of a: ");
            string inputA = Console.ReadLine();
            Console.Write("Please input value of b: ");
            string inputB = Console.ReadLine();
            Console.Write("Please input value of c: ");
            string inputC = Console.ReadLine();

            double A = Convert.ToDouble(inputA);
            double B = Convert.ToDouble(inputB);
            double C = Convert.ToDouble(inputC);

            double result = CalculateArea(A, B, C);
            if (double.IsNaN(result))
                Console.WriteLine("Please check your input as squareroot of negative number could not be calculated");
            else
                Console.WriteLine("The area of the triangle is " + result + ".");
                      

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
           
            return (area);
        }
    }
}