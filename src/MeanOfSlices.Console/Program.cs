using System;
using MeanOfSlices.Core;

namespace MeanOfSlices
{
    internal static class Program
    {
        private static void Main()
        {
            int[] arr = { 1, 1, 2, 3, 1, 4 };

            var calculator = new IntArrayMeanOfSlicesCalculator(arr);
            Console.WriteLine(calculator.GetMean(new ArraySlice(2, 3)));
        }
    }
}