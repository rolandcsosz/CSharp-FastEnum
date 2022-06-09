using System;
using BenchmarkDotNet.Running;

namespace EnumsBenchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
