﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Iced.Intel;

namespace AdventOfCode.Benchmark
{
    [MemoryDiagnoser()]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn()]
    public class Benchmarks
    {

        static readonly TestSuite TestSuite = new ();

        [Benchmark]
        public void TestParallel()
        {
            TestSuite.TestParralel(TestString);
        }

        [Benchmark]
        public void TestConsecutive()
        {
            TestSuite.TestSquential(TestString);
        }
    }
}