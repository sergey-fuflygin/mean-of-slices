using System;
using MeanOfSlices.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeanOfSlices.Tests
{
    [TestClass]
    public class MeansBySliceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Fails_When_Array_Is_Null()
        {
            //Arrange
            
            //Act
            // ReSharper disable once ObjectCreationAsStatement
            new MeansBySlice(null);

            //Assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Iterator_Fails_When_Slice_Does_Not_Belong_To_Array()
        {
            //Arrange
            var array = new[] { 1, 2, 3 };
            var meansBySlice = new MeansBySlice(array);
            var slice = new Slice(3, 3);

            //Act
            var _ = meansBySlice[slice];

            //Assert
        }
        
        [DataTestMethod]
        [DataRow(new[] { 1 }, 0, 0, 1)]
        [DataRow(new[] { 1, 2 }, 0, 1, 1.5)]
        [DataRow(new[] { 1, 1, 2, 3, 1, 4 }, 2, 3, 2.5)]
        [DataRow(new[] { 1, 1, 2, 3, 1, 4 }, 0, 0, 1)]
        [DataRow(new[] { 1, 1, 2, 3, 1, 4 }, 5, 5, 4)]
        [DataRow(new[] { 1, 1, 2, 3, 1, 4 }, 0, 5, 2)]
        public void Indexer_Successfully_Returns_Correct_Mean(int[] array, int start, int end, double expectedMean)
        {
            //Arrange
            var meansBySlice = new MeansBySlice(array);
            var slice = new Slice(start, end);
        
            //Act
            var actualMean = meansBySlice[slice];
        
            //Assert
            Assert.AreEqual(expectedMean, actualMean);
        }
    }
}