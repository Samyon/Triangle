namespace ClassLibrary1
{
    public static class Triangle2
    {
        //Погрешность
        const double eps = 0.00000001;

        public enum TriangleType
        {
            AcuteTriangle, //Остроугольный треугольник
            RightTriangle, //Прямоугольный треугольник
            DummyTriangle, //Тупоугольный треугольник
            IncorrectInputData
        }

        static void SortThree(ref double a, ref double b, ref double c)
        {
            if (a > b)
                Swap(ref a, ref b);
            if (a > c)
                Swap(ref a, ref c);
            if (b > c)
                Swap(ref b, ref c);
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static TriangleType DetermineTriangleType(double a, double b, double c)
        {
            // Валидация входных данных
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return TriangleType.IncorrectInputData;
            }

            // Сортировка сторон для удобства
            SortThree(ref a, ref b, ref c);

            // Проверка типа треугольника
            double a2 = a * a;
            double b2 = b * b;
            double hypotenuseSq = c * c;

            double cathetesSq = a2 + b2;

            if (cathetesSq > hypotenuseSq)
            {
                return TriangleType.AcuteTriangle;
            }
            else if (hypotenuseSq - cathetesSq < eps)
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