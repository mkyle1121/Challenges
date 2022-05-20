using System;

namespace Shuffle_The_Name
{

     /*
     * Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameShuffle("Rosie O'Donnel"));
        }

        public static string NameShuffle(string str)
        {
            var splits = str.Split(" ");
            return splits[1] + " " + splits[0];
        }

        //Single quotes encode a single character (data type char), while double quotes encode a string of multiple characters.


    }
}
