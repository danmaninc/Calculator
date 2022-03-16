using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Введите первое число.");
                string input1 = Console.ReadLine();
                if (!double.TryParse(input1, out double a))
                {
                    Console.WriteLine("Неверный ввод.");
                    continue;
                }
                Console.WriteLine("Введите второе число.");
                string input2 = Console.ReadLine();
                if (!double.TryParse(input2, out double b))
                {
                    Console.WriteLine("Неверный ввод.");
                    continue;
                }
                Console.WriteLine("Какое действие нужно выполнить? (+ - / *)");
                string action = Console.ReadLine();
                Problem expression = new Problem(a, b, action);

                double answer = expression.Resolve();
                if (expression.flag)
                {
                    Console.WriteLine("Неверный ввод.");
                } else
                {
                    Console.WriteLine(answer);
                }

                Console.WriteLine("Завершить работу? (y/n)");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                    break;
            }
        }
    }
}
