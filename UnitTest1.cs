using Microsoft.VisualStudio.TestTools.UnitTesting;
using P1;
using System;

namespace NumsUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AverageTest1()
        {
            //Arrange 
            double expectedResult = 28.2;
            double actualResult;
            int[] numArrTest = { 50, 10, 20, 33, 4, 60, 88, 7, 9, 1 };
            Nums num = new Nums(numArrTest);
            
            //Act
            actualResult = num.Calculate_avg(numArrTest);

            //Assert
            //If the expectedResult and actualResult are different, fail the test
            Assert.IsTrue((actualResult == expectedResult), "Average was not collected correctly.");

            
        }

        [TestMethod]
        public void AverageTest2()
        {
            //Arrange 
            double expectedResult = 91.4;
            double actualResult;
            int[] numArrTest = { 6, 56, 70, 14, 420, 60, 88, 70, 59, 71 };
            Nums num = new Nums(numArrTest);

            //Act
            actualResult = num.Calculate_avg(numArrTest);

            //Assert
            //If the expectedResult and actualResult are different, fail the test
            Assert.IsTrue((actualResult == expectedResult), "Average was not collected correctly.");


        }

        [TestMethod]
        public void AboveTest1()
        {
            int expectedAboveResult = 4;
            int actualAboveResult;
            double avg = 28.2;
            int[] numArr = { 50, 10, 20, 33, 4, 60, 88, 7, 9, 1 };
            Nums num = new Nums(numArr);

            //Act
            actualAboveResult = num.AboveAverage(numArr, avg);
            Console.WriteLine(actualAboveResult);

            //Assert
            //If the expected and actual are different from each other, fail the test
            Assert.IsTrue((actualAboveResult == expectedAboveResult), "Numbers above average calculated incorrectly");

        }

        [TestMethod]
        public void AboveTest2()
        {
            int expectedAboveResult = 1;
            int actualAboveResult;
            double avg = 91.4;
            int[] numArr = { 6, 56, 70, 14, 420, 60, 88, 70, 59, 71 };
            Nums num = new Nums(numArr);

            //Act
            actualAboveResult = num.AboveAverage(numArr, avg);
            Console.WriteLine(actualAboveResult);

            //Assert
            //If the expected and actual are different from each other, fail the test
            Assert.IsTrue((actualAboveResult == expectedAboveResult), "Numbers above average calculated incorrectly");

        }

        [TestMethod]
        public void BelowTest1()
        {
            //Arrange 
            int expectedBelowResult = 6;
            int actualBelowResult;
            double avg = 28.2;
            int[] numArr = { 50, 10, 20, 33, 4, 60, 88, 7, 9, 1 };
            Nums num = new Nums(numArr);

            //Act
            actualBelowResult = num.BelowAverage(numArr, avg);
            Console.WriteLine(actualBelowResult);

            //Assert
            //If the expected and actual are different from each other, fail the test
            Assert.AreEqual(expectedBelowResult, actualBelowResult);
        }

        [TestMethod]
        public void BelowTest2()
        {
            //Arrange 
            int expectedBelowResult = 9;
            int actualBelowResult;
            double avg = 91.4;
            int[] numArr = { 6, 56, 70, 14, 420, 60, 88, 70, 59, 71 };
            Nums num = new Nums(numArr);

            //Act
            actualBelowResult = num.BelowAverage(numArr, avg);
            Console.WriteLine(actualBelowResult);

            //Assert
            //If the expected and actual are different from each other, fail the test
            Assert.AreEqual(expectedBelowResult, actualBelowResult);
        }
    }
}
