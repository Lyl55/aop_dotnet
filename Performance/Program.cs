using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<Benchmarks>();
            Console.WriteLine(result);
        }
    }
}
