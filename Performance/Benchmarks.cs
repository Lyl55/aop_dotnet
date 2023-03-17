using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Performance
{
    public class Benchmarks
    {
        private readonly RestClient _restClient = new();

        [Benchmark]
        public async Task Normal() => await _restClient.CallNormal();

        [Benchmark]
        public async Task Intercepted() => await _restClient.CallIntercepted();
    }
}
