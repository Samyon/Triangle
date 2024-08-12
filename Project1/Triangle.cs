using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class Triangle
    {
        public enum TriangleType
        {
            AcuteTriangle, //Остроугольный треугольник
            RightTriangle, //Прямоугольный треугольник
            DummyTriangle,              //Тупогольный треугольник
            IncorrectInputData
        }

        public static TriangleType DetermineTriangleType(double a, double b, double c)
        {

            // Валидация входных данных
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return TriangleType.IncorrectInputData;
            }


            //var w =  new[] {a, b, c };
            

            // Сортировка сторон для удобства
            double[] sides = { a, b, c };
            Array.Sort(sides);

            // Проверка типа треугольника
            double sa2 = sides[0]* sides[0];
            double sb2 = sides[1] * sides[1];
            double sc2 = sides[2] * sides[2];

            if (sa2 + sb2 > sc2)
            {
                return TriangleType.AcuteTriangle;
            }
            else if (sa2 + sb2 == sc2)
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