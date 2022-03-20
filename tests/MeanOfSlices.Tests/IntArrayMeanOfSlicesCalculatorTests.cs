using System;
using MeanOfSlices.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeanOfSlices.Tests
{
    [TestClass]
    public class IntArrayMeanOfSlicesCalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Failed_When_Array_Is_Null()
        {
            //Arrange
            
            //Act
            // ReSharper disable once ObjectCreationAsStatement
            new IntArrayMeanOfSlicesCalculator(null);

            //Assert
        }
        
        // public void GetMean_
    }
}