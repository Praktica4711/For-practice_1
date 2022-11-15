using System;

namespace NewCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool finish = false;
            while (!finish) {
            string aIn;
            string bIn;
                double rec;
            Console.Write("Число: ");
            aIn = Console.ReadLine();
            double aIn1;
            while (!double.TryParse(aIn, out aIn1))
            {
                Console.Write("Ошибка. Вводить можно только целые числа: ");
                aIn = Console.ReadLine();
            }
            Console.WriteLine("Вы можете выбрать операции из предоставленного списка:");
            Console.WriteLine("\tplus - Сложение");
            Console.WriteLine("\tminus - Вычитание");
            Console.WriteLine("\tsum - Умножение");
            Console.WriteLine("\tdif - Деление");
            Console.WriteLine("\tgrade - Возведение в степень (второе число будет показателем степени)");
            Console.WriteLine("\tfinish - Завершение работы");
            Console.Write("Операция: ");
            string oper = Console.ReadLine();
            Console.Write("Число: ");
            bIn = Console.ReadLine();
            double bIn1 = 0;
            while (!double.TryParse(bIn, out bIn1))
            {
                Console.Write("Ошибка. Вводить можно только целые числа: ");
                bIn = Console.ReadLine();
            }
            try
                {
                    rec = CalClass.CalClassOp(aIn1, bIn1, oper);
                    if(double.IsNaN(rec))
                    {
                        Console.WriteLine("Операция невозможна\n");
                    }
                    else Console.WriteLine("Результат: ", rec);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("Введите finish, чтобы завершить работу калькулятора, или любую клавишу, чтобы продолжить ");
                if (Console.ReadLine() == "finish") finish = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
