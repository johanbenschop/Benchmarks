``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5), VM=Hyper-V
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=2.2.105
  [Host]     : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT


```
| Method |      Mean |     Error |    StdDev |
|------- |----------:|----------:|----------:|
|     T1 |  43.67 ns | 0.6281 ns | 0.5245 ns |
|     T2 |  13.76 ns | 0.2995 ns | 0.2802 ns |
|     T3 | 314.51 ns | 5.2064 ns | 4.8701 ns |
|     T4 | 156.59 ns | 2.9441 ns | 2.7539 ns |
