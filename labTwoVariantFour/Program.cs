using System;

namespace labTwoVariantFour
{
    public class Program
    {
        public static double Function(double x)
        {
            return x - 2 * Math.Sin(1 / x);
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите вашу точность: ");
            double eps = double.Parse(Console.ReadLine());

            Console.Write("Введите начало отрезка: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите конец отрезка: ");
            double b = double.Parse(Console.ReadLine());

            double c;

            while (Math.Abs(b - a) > eps)
            {
                c = (a + b) / 2;

                if ((Function(a) * Function(c)) < 0)
                {
                    b = c;
                }

                else
                {
                    a = c;
                }
            }

            Console.Write("Корень уравнения на заданном отрезке равен: " + (a + b) / 2 );

            Console.ReadLine();

        }
    }
}
