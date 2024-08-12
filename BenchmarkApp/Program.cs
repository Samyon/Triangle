using BenchmarkApp;
using BenchmarkDotNet.Running;



//BenchmarkDotNet.Running.BenchmarkRunner.Run<DateTimeParserBenchmark>()
Console.WriteLine("---");
Test.TestMethodPerformance();
Test.TestMethodPerformance2();
Console.WriteLine("---");
Test.TestMethodPerformance();
Test.TestMethodPerformance2();
Console.WriteLine("---");
Test.TestMethodPerformance();
Test.TestMethodPerformance2();
Console.WriteLine("---");


var summary = BenchmarkRunner.Run(typeof(Program).Assembly);








