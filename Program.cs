using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var summary = BenchmarkRunner.Run<EnumToInt>();
        }
    }

    public class EnumToInt
    {
        private static readonly Enum foo = TestEnum.Three;

        [Benchmark]
        public void T1()
        {
            int i = Convert.ToInt32(foo);
        }

        [Benchmark]
        public void T2()
        {
            int i = (int)(object)foo;
        }

        [Benchmark]
        public void T3()
        {
            int i = (int)Enum.Parse(foo.GetType(), foo.ToString());
        }

        [Benchmark]
        public void T4()
        {
            int i = (int)Enum.ToObject(foo.GetType(), foo);
        }
    }

    public enum TestEnum
    {
        One = 1,
        Two = 2,
        Three = 3
    }
}
