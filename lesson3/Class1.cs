using System;
using System.Collections.Generic;
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
                        default: continue;
                    }
                }
            }
        }

        private static double Calculate(double num1, double num2, string operat)
        {
            switch (operat)
            {
                default:
                    break;
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
            Console.WriteLine(result);
            //TODO методы для вычислений, поместить их в свич метода Calculate
        }
    }
}
