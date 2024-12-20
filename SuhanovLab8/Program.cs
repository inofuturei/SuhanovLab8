
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var performanceTest = new PerformanceTest();
        performanceTest.RunTest();
    }
}

public class PerformanceTest
{
    public void RunTest()
    {
        var numbers = Enumerable.Range(1, 1000000).ToList();
        var evenNumbers = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        Console.WriteLine($"Total even numbers: {evenNumbers.Count}");
    }
}