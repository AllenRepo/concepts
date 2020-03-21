using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class BitManipulationTest
    {
        [TestMethod]
        public void should_evaluate_for_even()
        {
            //Arrange
            var var1 = 100;
            var var2 = 101;

            //Act
            var isOdd1 = (var1 & 1) == 1;
            var isOdd2 = (var2 & 1) == 1;

            var isEven1 = (var1 & 1) == 0;
            var isEven2 = (var2 & 1) == 0;

            //Assert
            Assert.IsFalse(isOdd1);
            Assert.IsTrue(isOdd2);
            Assert.IsTrue(isEven1);
            Assert.IsFalse(isEven2);
        }

        [TestMethod]
        public void should_compliment_negative_value()
        {
            //Arrange
            var negative37 = -37;
            var positive36 = ~negative37;

            //Assert
            Assert.IsTrue(positive36 == 36);
        }

        [TestMethod]
        public void should_evaluate_for_power_of_2()
        {
            //Arrange
            var isPowerOfTwo = (Func<int, bool>)((int z) => z != 0 && (z & z - 1) == 0);

            //Assert
            Assert.IsTrue(isPowerOfTwo(2));
            Assert.IsTrue(isPowerOfTwo(256));
            Assert.IsFalse(isPowerOfTwo(3));
        }
    }
}
