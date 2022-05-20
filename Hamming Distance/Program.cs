using System;
using System.Linq;

namespace Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "asdffffds";
            string b = "qwerqwertt";

            Console.WriteLine(b[0]);

            Console.WriteLine("test"[0]);

            Console.WriteLine(HammingDistance(a, b));

        }

        public static int HammingDistance(string str1, string str2)
        {
            var char1 = str1.ToCharArray();
            var char2 = str2.ToCharArray();

            int hammerCount = new int { };
            for (var i = 0; i < char1.Count(); i++)
            {
                if (char1[i] != char2[i])
                {
                    hammerCount++;
                }
            }
            return hammerCount;

        }
    }
}
