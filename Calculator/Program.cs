using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Введите первое число.");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число.");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Какое действие нужно выполнить? (+ - / *)");
                string action = Console.ReadLine();
                Problem expression = new Problem(a, b, action);

                int answer = expression.Resolve();
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
