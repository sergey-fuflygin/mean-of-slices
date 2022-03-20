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
        public void GetMean_Fails_When_Slice_Does_Not_Belong_To_Array()
        {
            //Arrange
            var array = new[] { 1, 2, 3 };
            var meansBySlice = new MeansBySlice(array);
            var slice = new ArraySlice(3, 3);

            //Act
            var _ = meansBySlice[slice];

            //Assert

        }
    }
}