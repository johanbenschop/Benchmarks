using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public static class Program
    {
        private static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
