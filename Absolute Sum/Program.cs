using System;
using System.Linq;

namespace Absolute_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetAbsSum(new int[] { 1, 2, 3, -4, -5 });
            Console.WriteLine(result);

        }

        public static int GetAbsSum(int[] arr)
        {
            var result = arr.Select(x => Math.Abs(x));
            var addResult = result.Sum();
            return addResult;
        }
    }
}
