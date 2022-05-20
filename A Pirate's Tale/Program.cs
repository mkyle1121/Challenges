using System;
using System.Linq;

namespace A_Pirate_s_Tale
{
    class Program
    {
        static void Main()
        {
            NumberOfDays(new int[] { 10, 0 });
        }

        static void NumberOfDays(int[] coordinates)
        {
            int totalDays = Math.Abs(coordinates[0]) + Math.Abs(coordinates[1]);
            double restDays = (double)totalDays / (double)5;            

            int grandTotal = totalDays + (int)restDays;

            if ((double)totalDays % (double)5 == 0)
            {
                grandTotal--;
            }

        }
    }
}

