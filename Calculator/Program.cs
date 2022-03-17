using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                double a = 0;
                double b = 0;
                Console.WriteLine("Введите первое число.");
                string input1 = Console.ReadLine();
                while (!double.TryParse(input1, out a))
                {
                    Console.WriteLine("Неверный ввод.");
                    Console.WriteLine("Введите первое число.");
                    input1 = Console.ReadLine();
                }
                Console.WriteLine("Введите второе число.");
                string input2 = Console.ReadLine();
                while (!double.TryParse(input2, out b))
                {
                    Console.WriteLine("Неверный ввод.");
                    Console.WriteLine("Введите второе число.");
                    input2 = Console.ReadLine();
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
