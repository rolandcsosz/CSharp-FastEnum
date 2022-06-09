``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1706 (20H2/October2020Update)
Intel Core i5-9400F CPU 2.90GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK=6.0.201
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|             Method |        Mean |     Error |    StdDev | Allocated |
|------------------- |------------:|----------:|----------:|----------:|
|       EnumToString |  37.5129 ns | 0.2039 ns | 0.1807 ns |      24 B |
|      EnumIsDefined | 125.1260 ns | 0.3931 ns | 0.3283 ns |      24 B |
|     EnumCouldParse | 171.6448 ns | 0.2579 ns | 0.2413 ns |         - |
|   EnumToStringFast |   0.0269 ns | 0.0041 ns | 0.0036 ns |         - |
|  EnumIsDefinedFast |   0.5374 ns | 0.0084 ns | 0.0078 ns |         - |
| EnumCouldParseFast |  18.1923 ns | 0.0804 ns | 0.0712 ns |         - |
