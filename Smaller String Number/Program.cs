using System;

namespace Smaller_String_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(smallerNum("100", "200"));
        }


        public static string smallerNum(string n1, string n2)
        {

             return int.Parse(n1) > int.Parse(n2) ? n1 : n2;

            

            //int z1 = int.Parse(n1);
            //int z2 = int.Parse(n2);

            //if (z1 > z2)
            //{
            //    return z1.ToString();
            //}
            //else //if (z2 >= z1)
            //{
            //    return z2.ToString();
            //}
        }

    }
}
