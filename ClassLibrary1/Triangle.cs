using BenchmarkDotNet.Attributes;
using System;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.NETCore.Client;

namespace ClassLibrary1
{
    public static class Triangle
    {
        //Погрешность
        const double eps = 0.00000001;

        public enum TriangleType
        {
            AcuteTriangle, //Остроугольный треугольник
            RightTriangle, //Прямоугольный треугольник
            DummyTriangle, //Тупогольный треугольник
            IncorrectInputData
        }

        public static TriangleType DetermineTriangleType(double a, double b, double c)
        {

            // Валидация входных данных
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return TriangleType.IncorrectInputData;
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
                return TriangleType.AcuteTriangle;
            }
            else if ((z2 - x2 - y2) < eps)
            {
                return TriangleType.RightTriangle;
            }
            else
            {
                return TriangleType.DummyTriangle;
            }
        }
    }
}