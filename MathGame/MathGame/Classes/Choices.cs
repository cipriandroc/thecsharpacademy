using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    public class Choices
    {
        public Choices()
        {
            var choiceList = ChoiceList();

            foreach (var item in choiceList)
            {
                Console.WriteLine(item);
            }
        }

        private List<string> ChoiceList()
        {
            List<string> list = new List<string>();

            list.Add("Add");
            list.Add("Substract");
            list.Add("Multiply");
            list.Add("Divide");

            return list;
        }
    }
}
