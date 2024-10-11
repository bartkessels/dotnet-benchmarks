using BenchmarkDotNet.Attributes;

namespace DotNetBenchmarks;

public class CalculatorBenchmark
{
    private readonly Calculator _calculator = new();
    
    [Benchmark]
    public void AddUsingLinq()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        _calculator.AddUsingLinq(numbers);
    }

    [Benchmark]
    public void AddUsingForLoop()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        _calculator.AddUsingForLoop(numbers);
    }
}
