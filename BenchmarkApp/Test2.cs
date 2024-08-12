using ClassLibrary1;

using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkApp
{

    public class Test2
    {
        //static void SortThree(ref double a, ref double b, ref double c)
        //{
        //    if (a > b)
        //        Swap(ref a, ref b);
        //    if (a > c)
        //        Swap(ref a, ref c);
        //    if (b > c)
        //        Swap(ref b, ref c);
        //}

        //static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}

        //[Benchmark]
        //public void TestMethodThree()
        //{
        //    double x = 3.1;
        //    double y = 1;
        //    double z = 2;

        //    SortThree(ref x, ref y, ref z);
        //}

        //[Benchmark]
        //public void TestMethodArray()
        //{
        //    double[] sides = { 3.1, 2, 1 };
        //    Array.Sort(sides);
        //}

        [Benchmark]
        public void Benchmark1()
        {
            Triangle1.DetermineTriangleType(1, 1, 1);
        }

        [Benchmark(Baseline = true)]
        public void Benchmark2()
        {
            Triangle2.DetermineTriangleType(1, 1, 1);
        }

        [Benchmark]
        public void Benchmark()
        {
            Triangle.DetermineTriangleType(1, 1, 1);
        }

        [Benchmark]
        public void BenchmarkStr()
        {
            TriangleStr.DetermineTriangleType(1, 1, 1);
        }





    }
}
