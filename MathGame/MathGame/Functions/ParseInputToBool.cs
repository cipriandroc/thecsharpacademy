using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Functions
{
    public static class ParseInputToBool
    {

        public static bool YesNoLoop(string promptText)
        {

            IDictionary<string, bool> valuesDict = new Dictionary<string, bool>
            {
                {"y", true},
                {"n", false},
            };

            promptText = promptText + " (y/n): ";

            bool loop = false;

            while (!loop)
            {
                Console.Write(promptText);

                var key = Console.ReadKey();

                if (valuesDict.ContainsKey(key.KeyChar.ToString()) )
                {
                    Console.WriteLine();
                    return valuesDict[key.KeyChar.ToString()];
                }

                Console.WriteLine();
            }

            throw new Exception("No valid choice made!");
        }
    }
}
