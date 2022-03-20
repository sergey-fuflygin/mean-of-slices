using System.Linq;
using MeanOfSlices.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MeanOfSlices.Tests
{
    [TestClass]
    public class ThroughputTests
    {
        [DataTestMethod]
        [DataRow(10, 1)]
        [DataRow(100, 1)]
        [DataRow(1000, 1)]
        //TODO: It's too long when array length > 1000
        public void Succeeds_When_Array_Is_Huge(int arraySize, int maxTimeoutInSeconds)
        {
            //Arrange
            var array = Enumerable.Range(0, arraySize).ToArray();
            var meansBySlice = new MeansBySlice(array);
            var slice = new Slice(0, 0);
        
            //Act
            var _ = meansBySlice[slice];
        
            //Assert
        }
    }
}