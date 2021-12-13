using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.Clr;

namespace AdventOfCode.Benchmark
{
    public class TestSuite
    {
        
        public List<String> TestSquential(String value)
        {
            return value.Split(',').ToList();
        }

        public List<String> TestParralel(String value)
        {
            return value
            .Split(',')
            .AsParallel()
            .ToList();
        }

    }
}
