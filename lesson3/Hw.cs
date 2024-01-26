namespace lesson3
{
    internal static class Hw
    {
        public static void EvenOrOdd()
        {
            int num = 0;
            bool isInteger = false;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Введите число");
                    isInteger = int.TryParse(Console.ReadLine(), out num);     //  Я не придумал пока что как это пофиксить :(
                    if (isInteger) break;
                }

                if(num%2==0) Console.WriteLine("Число четное");
                else Console.WriteLine("Число нечетное");

                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }

        public static void Tempreture()
        {
            int tempreture = 0;
            bool isInteger = false;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Введите температуру");
                    isInteger = int.TryParse(Console.ReadLine(), out tempreture);     //  Я не придумал пока что как это пофиксить :(
                    if (isInteger) break;
                }

                switch (tempreture)
                {
                    case > -5:
                        Console.WriteLine("Тепло");
                        break;
                    case > -20:
                        Console.WriteLine("Нормально");
                        break;
                    case < -20:
                        Console.WriteLine("Холодно");
                        break;
                    default:
                        Console.WriteLine("Ошибка :(");
                        break;
                }

                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }

        public static void Season2()
        {
            int mounth = -1;
            bool isInteger = false;
            while (true)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите номер месяца от 1 до 12: ");
                    isInteger = int.TryParse(Console.ReadLine(), out mounth);       //  Я не придумал пока что как это пофиксить :(
                    if (isInteger && mounth >= 1 && mounth <= 12) break;
                    else Console.WriteLine("Вы ввели некорректный номер месяца. Попробуйте еще раз.");
                }

                #region Вывод результата
                if (mounth == 1) Console.WriteLine("Месяц под номером 1- Январь");
                else if (mounth == 2) Console.WriteLine("Месяц под номером 2- Февраль");
                else if (mounth == 3) Console.WriteLine("Месяц под номером 3- Март");
                else if (mounth == 4) Console.WriteLine("Месяц под номером 4- Апрель");
                else if (mounth == 5) Console.WriteLine("Месяц под номером 5- Май");
                else if (mounth == 6) Console.WriteLine("Месяц под номером 6- Июнь");
                else if (mounth == 7) Console.WriteLine("Месяц под номером 7- Июль");
                else if (mounth == 8) Console.WriteLine("Месяц под номером 8- Август");
                else if (mounth == 9) Console.WriteLine("Месяц под номером 9- Сентябрь");
                else if (mounth == 10) Console.WriteLine("Месяц под номером 10- Октябрь");
                else if (mounth == 11) Console.WriteLine("Месяц под номером 11- Ноябрь");
                else if (mounth == 12) Console.WriteLine("Месяц под номером 12- Декабрь");
                else Console.WriteLine("Ошибка :(");

                #endregion

                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }

        public static void Season()
        {
            int mounth = -1;
            bool isInteger = false;
            while (true)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите номер месяца от 1 до 12: ");
                    isInteger = int.TryParse(Console.ReadLine(), out mounth);       //  Я не придумал пока что как это пофиксить :(
                    if (isInteger && mounth >= 1 && mounth <= 12) break;
                    else Console.WriteLine("Вы ввели некорректный номер месяца. Попробуйте еще раз.");
                }

                switch (mounth)
                {
                    case 1:
                        Console.WriteLine("Месяц под номером 1- Январь");
                        break;
                    case 2:
                        Console.WriteLine("Месяц под номером 2- Февраль");
                        break;
                    case 3:
                        Console.WriteLine("Месяц под номером 3- Март");
                        break;
                    case 4:
                        Console.WriteLine("Месяц под номером 4- Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Месяц под номером 5- Май");
                        break;
                    case 6:
                        Console.WriteLine("Месяц под номером 6- Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Месяц под номером 7- Июль");
                        break;
                    case 8:
                        Console.WriteLine("Месяц под номером 8- Август");
                        break;
                    case 9:
                        Console.WriteLine("Месяц под номером 9- Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Месяц под номером 10- Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Месяц под номером 11- Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Месяц под номером 12- Декабрь");
                        break;

                    default:
                        Console.WriteLine("Ошибка :(");
                        break;
                }

                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }

        public static void Rainbow()
        {
            int colorNum = -1;
            bool isInteger = false;
            while (true)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите номер цвета от 1 до 7: ");
                    isInteger = int.TryParse(Console.ReadLine(), out colorNum);       //  Я не придумал пока что как это пофиксить :(
                    if (isInteger && colorNum >= 1 && colorNum <= 7) break;
                    else Console.WriteLine("Вы ввели некорректный номер цвета. Попробуйте еще раз.");
                }

                switch (colorNum)
                {
                    case 1:
                        Console.WriteLine("Цвет в радуге под номером 1- Красный");
                        break;
                    case 2:
                        Console.WriteLine("Цвет в радуге под номером 2- Оранжевый");
                        break;
                    case 3:
                        Console.WriteLine("Цвет в радуге под номером 3- Желтый");
                        break;
                    case 4:
                        Console.WriteLine("Цвет в радуге под номером 4- Зеленый");
                        break;
                    case 5:
                        Console.WriteLine("Цвет в радуге под номером 5- Голубой");
                        break;
                    case 6:
                        Console.WriteLine("Цвет в радуге под номером 6- Синий");
                        break;
                    case 7:
                        Console.WriteLine("Цвет в радуге под номером 7- Фиолетовый");
                        break;
                    default:
                        Console.WriteLine("Ошибка :(");
                        break;
                }

                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }
        }
    }
}
