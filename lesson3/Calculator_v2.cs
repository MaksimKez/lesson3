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

        //TODO Сделать методы для операторов
        private static string ResetOperator(string oldOperator)
        {
            while (true)
            {
                oldOperator = Console.ReadLine();
                if (oldOperator == null) continue;
                if (oldOperator.Length == 1)
                {
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


        private static double Calculate(double num1, double num2, string operat)
        {
            switch (operat)
            {
                case "+": return num1 + num2 ;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/": return Division(num1, num2);
                case "s": return ;      //TODO сделать возможность извлекать корень
                case "%": return ;
                default: Console.WriteLine("Введите оператор корректно");
            }
        }


        public static void Run()
        {
            double result = 0;      //! но при первом вводе будет в качестве num1\
            ResetNum(result);

            double num2 = 0;
            string operat = "";
            while (true)
            {
                operat = ResetOperator(operat);
                if (operat == "=") break;
                num2 = ResetNum(num2);
                result = Calculate(result, num2, operat);
            }
            result = Calculate(result, num2, operat);
            Console.WriteLine(result);
            //TODO методы для вычислений, поместить их в свич метода Calculate
        }
    }
}
