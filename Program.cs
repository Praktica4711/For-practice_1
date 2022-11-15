using System;

namespace NewCalculator
{
    public class CalClass
    {
        public static double DoOperation(double num1, double num2, string oper)
        {
            double result = double.NaN; 

            switch (oper)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "g":
                        result = num1 * num1;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;


                Console.Write("Введите число: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Вводиться должно только целое число: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Введите второе число: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Вводиться должно только целое число: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Введите оператор:");
                Console.WriteLine("\ta - Сложение");
                Console.WriteLine("\ts - Вычитание");
                Console.WriteLine("\tm - Умножение");
                Console.WriteLine("\td - Деление");
                Console.Write("Оператор: ");

                string oper = Console.ReadLine();

                try
                {
                    result = CalClass.DoOperation(cleanNum1, cleanNum2, oper);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Математическая ошибка \n");
                    }
                    else Console.WriteLine("Результат: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                Console.Write("Чтобы закрыть приложение, введите'n', либо любую другую клавишу, чтобы продолжить: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }

   
}
