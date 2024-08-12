using BenchmarkDotNet.Attributes;
using System;
using BenchmarkDotNet.Running;

namespace ClassLibrary1
{
    public class Class1
    {
        [Benchmark]
        public void TestMethodPerformance1a()
        {
            Triangle1.DetermineTriangleType(1, 1, 1);
        }

    }
}
