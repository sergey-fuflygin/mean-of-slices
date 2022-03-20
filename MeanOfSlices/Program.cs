using System;
using System.Collections.Generic;

namespace MeanOfSlices
{
    internal static class Program
    {
        private static void Main()
        {
            // int[] arr = { 1, 2, 3, 4 };
            int[] arr = { 1, 1, 2, 3, 1, 4 };

            var meansCalculator = new MeansCalculator(arr);
            Console.WriteLine(meansCalculator.GetMean(new Slice(2, 3)));
        }
        
        private static Dictionary<Slice, double> CalculateSliceMeans(int[] arr)
        {
            var n = arr.Length;

            var sliceMeans = new Dictionary<Slice, double>(n * (n + 1) / 2);
            
            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    var sum = 0;
                    
                    for (var k = i; k <= j; k++)
                    {
                        sum += arr[k];
                        Console.Write(arr[k] + " ");
                    }

                    var avg = (double)sum / (j - i + 1);
                    sliceMeans.Add(new Slice(i, j), avg);
                    
                    Console.WriteLine($"| Start = {i} | End = {j} | Avg = {avg}");
                }
            }

            return sliceMeans;
        }

        // private static void PrintSubArrays(int[] arr)
        // {
        //     var n = arr.Length;
        //     
        //     for (var i = 0; i < n; i++)
        //     {
        //         for (var j = i; j < n; j++)
        //         {
        //             for (var k = i; k <= j; k++)
        //             {
        //                 Console.Write(arr[k] + " ");
        //             }
        //             
        //             Console.WriteLine();
        //         }
        //     }
        // }
    }
}