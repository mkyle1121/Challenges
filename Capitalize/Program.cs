using System;
using System.Linq;

namespace Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "one day i went to the office and there was a bunch of people there.";
            string[] splits = input.Split(" ");
            string inputUpper = "";


            foreach (var line in splits)
            {
                Char[] letters = line.ToCharArray();
                letters[0] = Char.ToUpper(line[0]);

                

                inputUpper += new string(letters) + " ";
                
            }

            Console.WriteLine(inputUpper);
        }
    }
}
