using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Calculator_v2
    {
        private static double ResetNum(double oldNum)
        {
            bool isSuitable;
            while (true)
            {
                isSuitable = double.TryParse(Console.ReadLine(), out oldNum);
                if (isSuitable) return oldNum;
                else Console.WriteLine("Введите корретное число");
            }
        }

        private static string ResetOperator(string oldOperator)
        {
            while (true)
            {
                oldOperator = Console.ReadLine();
                if (oldOperator.Length > 1 || oldOperator.Length == 0)
                {
                    Console.WriteLine("Ввдите оператор корректно");
                    continue;
                }
                switch (oldOperator[0])
                {
                     case '+': return "+";
                     case '-': return "-";
                     case '*': return "*";
                     case '/': return "/";
                     case 's': return "s";
                     case '%': return "%";
                     case '=': return "=";
                     default: Console.WriteLine("Введите оператор корректно"); continue;
                }    
                
            }
        }

        private static double Division(double numerator, double denominator)
        {
            while (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю!");
                Console.WriteLine("Далее введите новый знаменатель");
                Console.WriteLine();
                denominator = ResetNum(denominator);
            }
            return numerator / denominator;
        }

        private static double Percent(double value, double percent)
        {
            percent /= 100;
            return value * percent;
        }

        private static double Sqrt(double value)
        {
            while (value < 0)
            {
                Console.WriteLine("Нельзя извлечь корень отрицательного числа");
                Console.WriteLine("Далее введите новое число");
                Console.WriteLine();
                value = ResetNum(value);
            }
            return Math.Sqrt(value);
        }

        private static double Calculate(double num1, string operat, double num2 = 0)
        {
            switch (operat)
            {
                case "+": return num1 + num2 ;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/": return Division(num1, num2);
                case "s": return Sqrt(num1);      //TODO сделать возможность извлекать корень
                case "%": return Percent(num1, num2);
                default: return 0;
            }
        }


        public static void Run()
        {
            double result = ResetNum(0);      //! но при первом вводе будет в качестве num1\
            

            double num2 = 0;
            string operat = "";
            while (true)
            {
                operat = ResetOperator(operat);
                if (operat == "=") break;
                if (operat == "s")
                {
                    result = Calculate(result, operat);
                    continue;
                }
                num2 = ResetNum(num2);
                result = Calculate(result, operat, num2);
            }
            Console.WriteLine(result);
        }
    }
}
