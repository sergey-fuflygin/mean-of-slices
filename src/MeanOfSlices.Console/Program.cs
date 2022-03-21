using System;
using MeanOfSlices.Core;

namespace MeanOfSlices
{
    internal static class Program
    {
        private static void Main()
        {
            int[] arr = { 1, 1, 2, 3, 1, 4 };

            var meansBySlice = new MeansBySlice(arr);
            Console.WriteLine(meansBySlice[new Slice(2, 3)]);
        }
    }
}