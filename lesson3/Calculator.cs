using System.Numerics;
using System.Transactions;
using System.Windows.Markup;

namespace lesson3
{
    internal static class Calculator
    {
        //!! test
        private static double Division(double numerator, double denominator) 
        {
            while (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю!");
                Console.WriteLine("Далее введите новый знаменатель");
                Console.WriteLine();
                denominator = GetNum();
            }
            return numerator / denominator;
        }


        //!! test
        private static double Sqrt(double value)
        {
            while (value < 0)
            {
                Console.WriteLine("Нельзя извлечь корень отрицательного числа");
                Console.WriteLine("Далее введите новое число");
                Console.WriteLine();
                value = GetNum();
            }  
            return Math.Sqrt(value);
        }


        private static double Percent(double value, double percent)
        {
            percent /= 100;
            return value * percent;
        }


        private static double GetNum()
        {
            bool success = false;
            double value;
            while (true)
            {
                Console.WriteLine("Введите число ");
                success = double.TryParse(Console.ReadLine(), out value);     //  Я не придумал пока что как это пофиксить :(
                if (success) break;
            }
            return value;
        }

        public static void Run()
        {
            double firstnum;
            double secondnum;
            bool isInteger;
            int numChosenOperation;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите операцию (напишите номер операции из списка ниже)");
                Console.WriteLine("1) Сложение");
                Console.WriteLine("2) Вычитание");
                Console.WriteLine("3) Умножение");
                Console.WriteLine("4) Вычислить процент от числа");
                Console.WriteLine("5) Извлечение корня");
                Console.WriteLine("6) Деление");

                while (true)
                {
                    Console.WriteLine("Введите номер операции");
                    isInteger = int.TryParse(Console.ReadLine(), out numChosenOperation);     //  Я не придумал пока что как это пофиксить :(
                    if (isInteger && numChosenOperation >= 1 && numChosenOperation <= 6) break;
                }

                switch (numChosenOperation)
                {
                    case 1:
                        firstnum = GetNum();
                        secondnum = GetNum();
                        Console.WriteLine("Cумма = " + (firstnum + secondnum));
                        break;
                    case 2:
                        firstnum = GetNum();
                        secondnum = GetNum();
                        Console.WriteLine("Разность = " + (firstnum - secondnum));
                        break;
                    case 3:
                        firstnum = GetNum();
                        secondnum = GetNum();
                        Console.WriteLine("Произвкедение = " + (firstnum * secondnum));
                        break;
                    case 4:
                        firstnum = GetNum();
                        secondnum = GetNum();
                        Console.WriteLine($"{secondnum}% от {firstnum} = " + Percent(firstnum, secondnum));
                        break;
                    case 5:
                        firstnum = GetNum();
                        Console.WriteLine("Корень числа = " + Sqrt(firstnum));
                        break;
                    case 6:
                        firstnum = GetNum();
                        secondnum = GetNum();
                        Console.WriteLine("Частное = " + Division(firstnum, secondnum));
                        break;
                }


                Console.WriteLine("Если повторно использовать калькулятор не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }
    }
}
