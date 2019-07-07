using System;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    public class EnumToInt
    {
        private static readonly Enum Foo = TestEnum.Three;

        [Benchmark]
        public void T1()
        {
            int i = Convert.ToInt32(Foo);
        }

        [Benchmark]
        public void T2()
        {
            int i = (int)(object)Foo;
        }

        [Benchmark]
        public void T3()
        {
            int i = (int)Enum.Parse(Foo.GetType(), Foo.ToString());
        }

        [Benchmark]
        public void T4()
        {
            int i = (int)Enum.ToObject(Foo.GetType(), Foo);
        }

        public enum TestEnum
        {
            One = 1,
            Two = 2,
            Three = 3
        }
    }
}