``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i5-4670 CPU 3.40GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
|                  Method |     Mean |   Error |  StdDev | Ratio |
|------------------------ |---------:|--------:|--------:|------:|
| StringConcatenationTest | 448.6 ns | 5.42 ns | 4.23 ns |  1.00 |
|       StringBuilderTest | 333.6 ns | 2.56 ns | 2.39 ns |  0.74 |
