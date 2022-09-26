using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 радиус");
            double R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 радиус");
            double R2 = double.Parse(Console.ReadLine());
            Values(R1, R2);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите x");
                    String user_input = Console.ReadLine();
                    if (user_input == "")//если ничего не ввели,заканчиваем программу
                    {
                        break;
                    }
                    double x = double.Parse(user_input);
                    Functions(x, R1, R2);
                }
                catch (System.FormatException)//проверка на число
                {
                    Console.WriteLine("Введён некорректный x");
                }
            }
        }
        static double Y1(double x)//первый сегмент
        {
            double y = 1;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }
        static double Y2(double x)//второй сегмент
        {
            double y = Math.Round((-0.5 * x - 2), 3);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }
        static double Y3(double x, double R1)//третий сегмент
        {
            if (R1 * R1 - (x + 2) * (x + 2) >= 0)
            {
                double y = Math.Round(Math.Sqrt(R1 * R1 - (x + 2) * (x + 2)), 3);
                Console.WriteLine($"Значение функции при x = {x}: {y}");
                return y;
            }
            else
            {
                if (x == -4 || x == 0)// проверка на точки
                {
                    return 0;
                };
                Console.WriteLine($"Функция неопределена при х={x}");
                return 0;
            }
        }
        static double Y4(double x, double R2)//четвертый сегмент
        {
            if (R2 * R2 - (x - 1) * (x - 1) >= 0)
            {
                double y = -Math.Round(Math.Sqrt(R2 * R2 - (x - 1) * (x - 1)), 3);
                Console.WriteLine($"Значение функции при x = {x}: {y}");
                return y;
            }
            else
            {
                if (x == 0 || x == 2)// проверка на точки
                {
                    return 0;
                };
                Console.WriteLine($"Функция неопределена при х={x}");
                return 0;
            }
        }
        static double Y5(double x)//пятый сегмент
        {
            double y = Math.Round((-x + 2), 3);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }
        static void Values(double R1, double R2)//выдача значений с шагом 0,2
        {
            for (double x = -7; x <= 3; x += 0.2)
            {
                Functions(Math.Round(x, 2), R1, R2);
            }

        }
        static void Functions(double x, double R1, double R2)
        {
            if (-7 <= x && x <= -6)
            {
                Y1(x);
            };
            if (-6 <= x && x <= -4)
            {
                Y2(x);
            };
            if (-4 <= x && x <= 0)
            {
                Y3(x, R1);
            };
            if (0 < x && x <= 2)
            {
                Y4(x, R2);
            };
            if (2 < x && x <= 3)
            {
                Y5(x);
            };
            if (x > 3 || x < -7)
            {
                Console.WriteLine("x должен принадлежать отрезку [-7, 3]");
            };
        }
    }
}