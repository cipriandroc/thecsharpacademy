using MathGame.Functions;
using MathGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    public class GameCreator : Game, IGameCreator
    {
        public bool userSuccess { get; set; }

        private delegate int CalculationMethod(int x, int y);
        private readonly IDictionary<string, CalculationMethodInfo> _calculationMethods;
        public GameCreator()
        {
            _calculationMethods = CalculationMethods();
            userSuccess = false;
        }
        public new void StartGame()
        {
            Console.WriteLine("You have started the game");
            Console.WriteLine("Please make your selection");

            var choiceDict = CalcFunctDict(_calculationMethods);

            var choices = new Choices(_calculationMethods);
            int choiceResult = choices.GetSelection();

            string resultFunction = MapChoiceToFunctionName(choiceDict, choiceResult);
            Console.WriteLine($"Your selection is {choiceResult}");
            Console.WriteLine($"Your selection performs a [{_calculationMethods[resultFunction].Name}] function.");

            Console.WriteLine("Please enter your first number below:");
            int firstNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine("Please enter your second number below:");
            int secondNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine($"What is {firstNumber} {resultFunction} {secondNumber}?");
            int userResult = ParseInputToInt.ParseLineToInt();
            int result = _calculationMethods[resultFunction].Method(firstNumber, secondNumber);

            if (userResult == result)
            {
                Console.WriteLine("You got it right!");
                userSuccess = true;
            }
            else
            {
                Console.WriteLine("You did not get it right!");
            }

            Console.WriteLine($"{firstNumber} [{resultFunction}] {secondNumber} = {result}");
        }
        private IDictionary<string, CalculationMethodInfo> CalculationMethods()
        {
            return new Dictionary<string, CalculationMethodInfo>
            {
                {"Add", new CalculationMethodInfo(1,"Add","+", Add)},
                {"Substract", new CalculationMethodInfo(2,"Substract","-", Substract)},
                {"Multiply", new CalculationMethodInfo(3,"Multiply","*", Multiply)},
                {"Divide", new CalculationMethodInfo(4,"Divide","/", Divide)},
            };
        }
        private IDictionary<int, string> CalcFunctDict(IDictionary<string, CalculationMethodInfo> calculationMethods)
        {

            IDictionary<int, string> dict = new Dictionary<int, string>();

            foreach (var item in calculationMethods)
            {
                dict.Add(item.Value.Counter, item.Value.Name);
            }

            return dict;
        }
        private string MapChoiceToFunctionName(IDictionary<int, string> choicesDict, int result)
        {

            if (!choicesDict.ContainsKey(result))
            {
                throw new Exception("not a valid selection");
            }

            string myValue = choicesDict[result];

            return myValue;
        }
        public int GetUserResult()
        {
            if (userSuccess)
            {
                return 1;
            }

            return 0;
        }
    }
}
