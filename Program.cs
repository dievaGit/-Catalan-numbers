using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise_8
{
    class Program
    {
        //Funtion factorial
        static BigInteger Factorial(uint num)
        {
            BigInteger f = 1;
            for (uint i = num; i > 0; i--)
            {
                f *= i;
            }

            return f;
        }
        static void Main(string[] args)
        {
            //Declaring variables
            BigInteger  Cn = 1;
            uint n = 0, numerator = 0, denominatorSum = 0;


            //Requesting numerator and denominator
            do
            {
                Console.Write(" Enter the number: ");
            n = Convert.ToUInt32 (Console.ReadLine());
                           
            }
            while (n <= 0);

            //calculating the Catalan number
            numerator = 2 * n;
            denominatorSum = n + 1;

            Cn = Factorial(numerator) / (Factorial(denominatorSum) * Factorial(n));

            Console.Write(" Cn = (2*{0})! / ({0} + 1)! * {0}! = {1}", n, Cn);

            Console.ReadKey();
        }
    }
}
