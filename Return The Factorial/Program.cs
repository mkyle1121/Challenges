using System;

namespace Return_The_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
        }

        public static int Factorial(int num)
        {
            int factorial = 1 ;

            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
