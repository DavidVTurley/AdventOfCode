// See https://aka.ms/new-console-template for more information
using AdventOfCode._2021;
using AdventOfCode.Benchmark;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngine;


_03_SubmarineDiagnostics program = new();
program.Run();
program.RunSecond();

BenchmarkRunner.Run<Benchmarks>();


