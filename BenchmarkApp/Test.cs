using ClassLibrary1;
using System.Diagnostics;


namespace BenchmarkApp
{
    public static class Test
    {
        static int count = 1000000;
        public static void TestMethodPerformance()
        {
            long[] longs = { 0, 0, 0, 0 };
            var triangles = Enum.GetNames(typeof(Triangle.TriangleType));
            Triangle.DetermineTriangleType(1, 1, 1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 100; i < count; i++)
            {
                longs[(long)Triangle.DetermineTriangleType(i, i + 11, i + 19)]++;
                longs[(long)Triangle.DetermineTriangleType(i + 11, i + 19, i)]++;
                longs[(long)Triangle.DetermineTriangleType(i + 11, i + 19, i + 15)]++;
                longs[(long)Triangle.DetermineTriangleType(i, i, 200)]++;
                longs[(long)Triangle.DetermineTriangleType(i, i, i)]++;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Время выполнения Triangle: {ts.TotalMilliseconds} миллисекунд");
            Console.WriteLine(triangles[0] + ": " + longs[0] + "; " +
                "  " + triangles[1] + ": " + longs[1] + "; " +
                triangles[2] + ": " + longs[2] + "; " +
                triangles[3] + ": " + longs[3]);
        }


        public static void TestMethodPerformance2()
        {
            long[] longs = { 0, 0, 0, 0 };
            var triangles = Enum.GetNames(typeof(Triangle.TriangleType));
            Triangle2.DetermineTriangleType(1, 1, 1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 100; i < count; i++)
            {
                longs[(long)Triangle2.DetermineTriangleType(i, i + 11, i + 19)]++;
                longs[(long)Triangle2.DetermineTriangleType(i + 11, i + 19, i)]++;
                longs[(long)Triangle2.DetermineTriangleType(i + 11, i + 19, i + 15)]++;
                longs[(long)Triangle2.DetermineTriangleType(i, i, 200)]++;
                longs[(long)Triangle2.DetermineTriangleType(i, i, i)]++;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            Console.WriteLine($"Время выполнения Triangle2: {ts.TotalMilliseconds} миллисекунд");
            Console.WriteLine(triangles[0] + ": " + longs[0] + "; " +
                "  " + triangles[1] + ": " + longs[1] + "; " +
                triangles[2] + ": " + longs[2] + "; " +
                triangles[3] + ": " + longs[3]);
        }


    }
}
