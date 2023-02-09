using MathGame.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathGame.Classes
{
    public class Choices
    {
        private readonly IDictionary<int, string> _choiceDict;
        private readonly List<int> _keyList;
        public Choices(IDictionary<int, string> choiceDict)
        {
            _choiceDict = choiceDict;
            _keyList = new List<int>(choiceDict.Keys);
        }
        public int GetSelection()
        {
            foreach (var item in _choiceDict)
            {
                Console.WriteLine($"{item.Key}) {item.Value}");
            }

            Console.WriteLine("Make your selection:");
            return ValidateInput(_keyList);
        }
        private int ValidateInput(List<int> keyList)
        {
            bool isValidInput = false;
            int key = 0;

            while (!isValidInput)
            {

                key = ParseInputToInt.ParseKeyToInt();

                if (keyList.Contains(key))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine($"The number selected ({key}) is not an existing selection number");
                }
            }

            return key;
        }
    }
}
