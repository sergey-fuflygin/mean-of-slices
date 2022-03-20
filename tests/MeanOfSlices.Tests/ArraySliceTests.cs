using System;
using MeanOfSlices.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeanOfSlices.Tests
{
    [TestClass]
    public class ArraySliceTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(-1, 0)]
        [DataRow(0, -1)]
        [DataRow(1, 0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_Failed_When_Array_Is_Null(int start, int end)
        {
            //Arrange

            //Act
            // ReSharper disable once ObjectCreationAsStatement
            new ArraySlice(start, end);

            //Asse
        }
    }
}