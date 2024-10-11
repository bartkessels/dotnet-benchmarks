namespace DotNetBenchmarks;

internal class Calculator
{
    internal int AddUsingLinq(int[] numbers)
    {
        return numbers.Sum();
    }

    internal int AddUsingForLoop(int[] numbers)
    {
        var sum = 0;
            
        for (var i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
           
        return sum;
    }
}
