using System;
using System.Collections.Generic;

namespace Filter_Out_String_From_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FilterArray(new object[] { 1, 2, "a", "b" } );
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] FilterArray(object[] arr)
        {
            var intList = new List<int>();   

            foreach (object x in arr)
            {
                try
                {
                    int f = (int)x;
                    intList.Add(f);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not convert '{x}' to int.");
                }
            }

            return intList.ToArray();
        }
    }
}
