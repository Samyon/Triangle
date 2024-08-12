using BenchmarkDotNet.Attributes;
using System;
using BenchmarkDotNet.Running;

namespace ClassLibrary1
{
    public static class TriangleStr
    {
        //Погрешность
        const double eps = double.Epsilon * 10;

        public static string DetermineTriangleType(double a, double b, double c)
        {
            // Валидация входных данных
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return "Не является треугольником";
            }

            // Сортировка сторон для удобства
            double[] sides = { a, b, c };
            Array.Sort(sides);

            double x = sides[0];
            double y = sides[1];
            double z = sides[2];

            // Проверка типа треугольника
            double x2 = x * x;
            double y2 = y * y;
            double z2 = z * z;

            if (x2 + y2 > z2)
            {
                return "Остроугольный";
            }
            else if ((z2 - x2 - y2) < eps)
            {
                return "Прямоугольный";
            }
            else
            {
                return "Тупоугольный";
            }
        }
    }
}