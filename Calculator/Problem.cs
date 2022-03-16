using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Problem
    {
        private double FirstElement { get; }
        private double SecondElement { get; }
        private string Action { get; }
        public bool flag = false;
        public Problem(double a, double b, string action)
        {
            FirstElement = a;
            SecondElement = b;
            Action = action;
        }

        public double Resolve()
        {
            switch (Action)
            {
                case "+": return FirstElement + SecondElement;
                case "-": return FirstElement - SecondElement;
                case "/":
                    {
                        if (SecondElement != 0)
                            return FirstElement / SecondElement;
                        else
                        {
                            flag = true;
                            return -1;
                        }
                    }
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
