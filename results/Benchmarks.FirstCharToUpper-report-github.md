``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5), VM=Hyper-V
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT


```
|            Method |      Mean |     Error |    StdDev |
|------------------ |----------:|----------:|----------:|
| FirstCharToUpper1 |  75.79 ns | 1.5701 ns | 2.0416 ns |
| FirstCharToUpper2 | 128.63 ns | 2.5431 ns | 2.6115 ns |
| FirstCharToUpper3 |  70.66 ns | 1.3301 ns | 1.2442 ns |
| FirstCharToUpper4 |  48.13 ns | 0.8303 ns | 0.7767 ns |
