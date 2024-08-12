﻿using BenchmarkDotNet.Attributes;
using System;
using BenchmarkDotNet.Running;

namespace ClassLibrary1
{
    public static class Triangle1
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

            // Проверка типа треугольника
            double sa2 = sides[0] * sides[0];
            double sb2 = sides[1] * sides[1];
            double sc2 = sides[2] * sides[2];

            if (sa2 + sb2 > sc2)
            {
                return TriangleType.AcuteTriangle;
            }
            else if ((sc2 -sa2 -sb2) < eps)
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