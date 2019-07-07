using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    public class FirstCharToUpper
    {
        private const string Input = "donderdag 21 april 2017";

        [Benchmark]
        public string FirstCharToUpper1()
        {
            return char.ToUpper(Input[0]) + Input.Substring(1);
        }

        [Benchmark]
        public string FirstCharToUpper2()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(char.ToUpper(Input[0]));
            stringBuilder.Append(Input.Substring(1));

            return stringBuilder.ToString();
        }

        [Benchmark]
        public string FirstCharToUpper3()
        {
            var sb = new StringBuilder(Input);
            sb[0] = char.ToUpper(sb[0]);

            return sb.ToString();
        }

        [Benchmark]
        public string FirstCharToUpper4()
        {
            var output = Input.ToCharArray();
            output[0] = char.ToUpper(Input[0]);

            return output.ToString();
        }
    }
}
