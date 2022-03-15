using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Problem
    {
        public int FirstElement { get; set; }
        public int SecondElement { get; set; }
        public string Action { get; set; }
        public bool flag = false;
        public Problem(int a, int b, string action)
        {
            FirstElement = a;
            SecondElement = b;
            Action = action;
        }

        public int Resolve()
        {
            switch (Action)
            {
                case "+": return FirstElement + SecondElement;
                case "-": return FirstElement - SecondElement;
                case "/": return FirstElement / SecondElement;
                case "*": return FirstElement * SecondElement;
                default:
                    {
                        flag = true;
                        return -1;
                    }
            }
        }
    }
}
