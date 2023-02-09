﻿using MathGame.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    public class GameCreator : Game
    {
        private delegate int CalculationMethod(int x, int y);
        private readonly IDictionary<string, CalculationMethod> _calculationMethods;
        public GameCreator() 
        {
            _calculationMethods = CalculationMethods();
        }
        public new void StartGame()
        {
            Console.WriteLine("You have started the game");
            Console.WriteLine("Please make your selection");

            var choiceDict = CalcFunctDict(_calculationMethods);

            var choices = new Choices(choiceDict);
            int choiceResult = choices.GetSelection();

            string resultFunction = MapChoiceToFunctionName(choiceDict, choiceResult);
            Console.WriteLine($"Your selection is {choiceResult}");
            Console.WriteLine($"Your selection performs a [{resultFunction}] function.");

            Console.WriteLine("Please enter your first number below:");
            int firstNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine("Please enter your second number below:");
            int secondNumber = ParseInputToInt.ParseLineToInt();

            Console.WriteLine($"What is {firstNumber} {resultFunction} {secondNumber}?");
            int userResult = ParseInputToInt.ParseLineToInt();
            int result = _calculationMethods[resultFunction](firstNumber, secondNumber);

            bool userSuccess = false;

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
        private IDictionary<string, CalculationMethod> CalculationMethods()
        {
            return new Dictionary<string, CalculationMethod>
            {
                {"Add", Add},
                {"Substract", Substract },
                {"Multiply", Multiply },
                {"Divide", Divide },
            };
        }
        private IDictionary<int, string> CalcFunctDict(IDictionary<string, CalculationMethod> calculationMethods)
        {

            IDictionary<int, string> dict = new Dictionary<int, string>();

            foreach (var item in calculationMethods)
            {
                dict.Add(dict.Count, item.Key);
            }

            return dict;
        }
        private string MapChoiceToFunctionName(IDictionary<int, string> choicesDict,int result)
        {

            if (!choicesDict.ContainsKey(result)) 
            {
                throw new Exception("not a valid selection");
            }

            string myValue = choicesDict[result];

            return myValue;
        }
    }
}