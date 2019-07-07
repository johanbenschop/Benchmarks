``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5), VM=Hyper-V
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT


```
| Method |      Mean |     Error |    StdDev |
|------- |----------:|----------:|----------:|
|     T1 |  49.10 ns | 0.5719 ns | 0.5349 ns |
|     T2 |  15.16 ns | 0.1938 ns | 0.1813 ns |
|     T3 | 357.73 ns | 7.1485 ns | 6.6867 ns |
|     T4 | 173.26 ns | 3.3338 ns | 3.4236 ns |
