using System;
using System.Collections.Generic;
using System.Linq;

namespace Eliminate_Odd_Numbers_With_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenOnly = NoOdds(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.WriteLine(string.Join("", evenOnly));
        }


        static int[] NoOdds(int[] arr)
        {
            var evenOnly = new List<int>();

            foreach(var num in arr)
            {
                if(num % 2 == 0)
                {
                    evenOnly.Add(num);
                }
            }

            return evenOnly.ToArray();

        }
    }
}
