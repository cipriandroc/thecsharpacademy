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
        public int userScore {get; set;}

        private delegate int CalculationMethod(int x, int y);
        private readonly IDictionary<string, CalculationMethodInfo> _calculationMethods;
        public GameCreator()
        {
            _calculationMethods = CalculationMethods();
            userScore = 0;
        }
        public new void StartGame()
        {
            Console.WriteLine("You have started the game");
            CalculationMethodInfo selectedCalculationMethod = OperationSelection();

            PerformOperationGame(selectedCalculationMethod);
        }

        private void PerformOperationGame(CalculationMethodInfo selectedCalculationMethod)
        {
            Console.WriteLine("Please enter your first number below:");
            int firstNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine("Please enter your second number below:");
            int secondNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine($"What is {firstNumber} {selectedCalculationMethod.OperationSign} {secondNumber}?");
            int userResult = ParseInputToInt.ParseLineToInt();
            int result = selectedCalculationMethod.Method(firstNumber, secondNumber);

            if (userResult == result)
            {
                Console.WriteLine("You got it right!");
                userScore += 1;
            }
            else
            {
                Console.WriteLine("You did not get it right!");
            }

            Console.WriteLine($"{firstNumber} {selectedCalculationMethod.OperationSign} {secondNumber} = {result}");
        }

        private CalculationMethodInfo OperationSelection()
        {
            Console.WriteLine("Please make your selection");

            var choices = new Choices(_calculationMethods);
            int choiceResult = choices.GetSelection();

            CalculationMethodInfo selectedCalculationMethod = MapChoiceToCalculationMethod(_calculationMethods, choiceResult);
            Console.WriteLine($"You selected the [{selectedCalculationMethod.Name}({selectedCalculationMethod.OperationSign})] operation.");
            return selectedCalculationMethod;
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
        private CalculationMethodInfo MapChoiceToCalculationMethod(IDictionary<string, CalculationMethodInfo> calculationMethods, int result)
        {
           
            foreach (var item in calculationMethods)
            {
                if (item.Value.Counter == result) 
                { 
                    return item.Value;
                }
            }

            throw new Exception("No valid operation has been selected");

        }

    }
}
