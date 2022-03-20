using System;
using MeanOfSlices.Core;

namespace MeanOfSlices
{
    internal static class Program
    {
        private static void Main()
        {
            int[] arr = { 1, 1, 2, 3, 1, 4 };

            var calculator = new MeansBySlice(arr);
            Console.WriteLine(calculator[new ArraySlice(2, 3)]);
        }
    }
}