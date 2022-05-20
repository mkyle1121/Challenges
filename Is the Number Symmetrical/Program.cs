using System;
using System.Linq;

namespace Is_the_Number_Symmetrical
{
    class Program
    {
        static void Main(string[] args)
        {
            IsSymmetrical(125);
        }

        public static bool IsSymmetrical(int num)
        {
            var reversed = num.ToString().Reverse().ToArray();
            Console.WriteLine(reversed.ToString());
            var reversedint = int.Parse(new string(reversed));

            if (num == reversedint)
            {
                Console.WriteLine("It is symmetrical");
                return true;
            }

            Console.WriteLine("It is NOT symmetrical");
            return false;

            //string numString = num.ToString();

            //for (int i = 0, j = numString.Length - 1 ; i <= numString.Length - 1 ; i++, j--)
            //{
            //    if (numString[i] != numString[j])
            //    {
            //        Console.WriteLine($"{numString[i]} does not equal {numString[j]}");
            //        return false;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{numString[i]} == {numString[j]}");
            //    }               
            //}

            //Console.WriteLine("It is symmetrical");
            //return true;


        }
    }
}
