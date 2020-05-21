using System;

namespace Kustova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Кустова Юлия Сергеевна, АЭМ-111");
            Console.Write("Введите M: ");
            var line = Console.ReadLine().Replace(".", ",");
            double m;

            //проверка правильности ввода
            if (double.TryParse(line, out m))
            {
                Console.Write("Введите B: ");
                line = Console.ReadLine().Replace(".", ",");
                double b;
                //проверка правильности ввода
                if (double.TryParse(line, out b))
                {
                    double a;
                    if (m < 10)
                    {
                        a = m * m + 5;
                    }
                    else if (m > 10)
                    {
                        a = Math.Cos(m * m);
                    }
                    else
                    {
                        a = m * m - Math.Cos(m);
                    }

                    double u;
                    if (m > 5)
                    {
                        u = b * b;
                    }
                    else
                    {
                        u = b * b - m;
                    }

                    double z = (a * Math.Tan(a) - m * m) / (Math.Cos(u) + u * b);

                    Console.WriteLine("Z: {0:0.000}", z); //вывод с точностью 3 знака
                }
                else
                {
                    Console.WriteLine("Ввод не удалось распознать");
                }
            }
            else
            {
                Console.WriteLine("Ввод не удалось распознать");
            }

            Console.ReadKey(); //ожидание любой клавиши
        }
    }
}