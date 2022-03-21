using System;
using System.Collections.Generic;
using System.Linq;
using MeanOfSlices.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeanOfSlices.Tests
{
    [TestClass]
    public class ThroughputTests
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(10)]
        [DataRow(100)]
        [DataRow(1000)]
        [DataRow(10000)]
        [DataRow(100000)]
        [DataRow(1000000)]
        [DataRow(10000000)]
        [DataRow(100000000)]
        [DataRow(1000000000)]
        [DataRow(2146435071)] // Maximum index is 0X7FEFFFFF
        public void Succeeds_When_Array_Is_Huge(int arraySize)
        {
            //Arrange
            var random = new Random();
            
            var array = Enumerable
                .Repeat(0, arraySize)
                .Select(i => random.Next(int.MinValue, int.MaxValue))
                .ToArray();

            var meansBySlice = new MeansBySlice(array);
            var slice = new Slice(0, arraySize - 1);
        
            //Act
            var _ = meansBySlice[slice];
        
            //Assert
        }
        
        [DataTestMethod]
        [DataRow(1)]    // 1 slice
        [DataRow(10)]   // 55 slices
        [DataRow(100)]  // 5050 slices
        [DataRow(1000)] // 500500 slices
        public void Succeeds_When_Requesting_Means_For_All_Possible_Slices(int arraySize)
        {
            //Arrange
            var random = new Random();
            
            var array = Enumerable
                .Repeat(0, arraySize)
                .Select(i => random.Next(int.MinValue, int.MaxValue))
                .ToArray();

            var meansBySlice = new MeansBySlice(array);

            //Act
            foreach (var slice in GetAllPossibleSlices(arraySize))
            {
                var _ = meansBySlice[slice];
            }

            //Assert
        }

        private static IEnumerable<Slice> GetAllPossibleSlices(int arrayLength)
        {
            for (var i = 0; i < arrayLength; i++)
            {
                for (var j = i; j < arrayLength; j++)
                {
                    yield return new Slice(i, j);
                }
            }
        }
    }
}