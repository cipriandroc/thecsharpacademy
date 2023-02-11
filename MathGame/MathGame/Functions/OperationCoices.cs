using MathGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathGame.Functions
{
    public class Choices
    {
        private readonly IDictionary<string, CalculationMethodInfo> _choiceDict;
        private readonly List<int> _keyList = new List<int>();
        public Choices(IDictionary<string, CalculationMethodInfo> choiceDict)
        {
            _choiceDict = choiceDict;

            foreach (var item in choiceDict.Values)
            {
                _keyList.Add(item.Counter);
            }
        }
        public int GetSelection()
        {
            foreach (var item in _choiceDict)
            {
                Console.WriteLine($"{item.Value.Counter}) {item.Value.Name}");
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
