using BenchmarkDotNet.Attributes;
using FastEnumUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsBenchTest
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        [Benchmark]
        public String EnumToString()
        {
            return Color.Lime.ToString();
        }

        [Benchmark]
        public bool EnumIsDefined()
        {
            return Enum.IsDefined(typeof(Color), Color.Lime);
        }

        [Benchmark]
        public bool EnumCouldParse()
        {
            return Enum.TryParse("Lime", false, out Color type);
        }

        [Benchmark]
        public String EnumToStringFast()
        {
            return FastEnum.GetName<Color>(Color.Lime);
        }

        [Benchmark]
        public bool EnumIsDefinedFast()
        {
            return FastEnum.IsDefined<Color>(Color.Lime);
        }

        [Benchmark]
        public bool EnumCouldParseFast()
        {
            return FastEnum.TryParse<Color>("Lime", out Color type);
        }
    }
}
