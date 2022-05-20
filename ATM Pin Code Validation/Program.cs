using System;
using System.Linq;

namespace ATM_Pin_Code_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePIN("-234"));
        }


        public static bool ValidatePIN(string pin)
        {
            foreach (char i in pin)
            {
                int num;
                bool eachNumberResult = int.TryParse(i.ToString(), out num);
                if (eachNumberResult == false)
                {
                    return false;
                }
            }

            if (pin.Length == 4 || pin.Length == 6)
            {
                return true;
            }

            return false;

            //////////////////////

            //pin.All(char.IsDigit);
        }
    }
}
