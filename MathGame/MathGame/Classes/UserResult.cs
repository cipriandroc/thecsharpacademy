using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    internal class UserResult
    {
        public string Operation { get; set; }
        public string OperationSign { get; set; }
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public int userResult { get; set; }
        public int computerResult { get; set; }
        public bool userSuccess { get; set; }
        public UserResult() { }
    }
}
