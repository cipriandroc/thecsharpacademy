using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MathGame.Classes
{
    public class CalculationMethodInfo
    {
        public delegate int CalculationMethod(int x, int y);

        private int _counter;
        private string _name;
        private string _operationSign;
        private CalculationMethod _method;

        public int Counter { get { return _counter; } }
        public string Name { get { return _name; } }
        public string OperationSign { get { return _operationSign; } }
        public CalculationMethod Method { get { return _method; } }


        public CalculationMethodInfo(int counter, string name, string operationSign, CalculationMethod method)
        {
            _counter = counter;
            _name = name;
            _operationSign = operationSign;
            _method = method;
        }
    }
}
