using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Functions
{
    public static class ParseInputToInt
    {

        public static int ParseKeyToInt()
        {
            bool isValidInput = false;
            int number = 0;

            while (!isValidInput)
            {
                var key = Console.ReadKey(true);

                if (char.IsDigit(key.KeyChar))
                {
                    number = int.Parse(key.KeyChar.ToString());
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine($"Invalid input, ({key.KeyChar.ToString()}) is not a valid number.");
                }
            }

            return number;
        }
        public static int ParseLineToInt()
        {
            bool isValidInput = false;
            int input = 0;

            while (!isValidInput)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    isValidInput = true;
                }
                catch
                {
                    Console.WriteLine("You didn't input a valid number! Try again..");
                }
            }

            return input;
        }
    }
}
