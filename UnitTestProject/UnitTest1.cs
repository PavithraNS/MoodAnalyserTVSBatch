using System;
using GenericsDemoTVSBatch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        GenericClass<int> genericClass;
        MaximuxAmongThree three;
        MaximuxGenericClass<int> maxInt;

        [TestInitialize]
       public void SetUp()
        {
            int first = 30, second = 25, third = 40;
            genericClass = new GenericClass<int>();
            three = new MaximuxAmongThree();
            maxInt = new MaximuxGenericClass<int>(first,second,third);
        }

        [TestMethod]
        public void TestToPrintMethod()
        {
            //AAA methodology
            //Arrange
            int[] intArray = new int[] { 12, 34, 56 };
            double[] doubleArray = new double[] { 12.23, 12.34, 23.56 };
            char[] charArray = new char[] { 'H', 'E', 'L', 'L', 'O' };
            //GenericClass<int> genericClass = new GenericClass<int>();
            int[] expected= new int[] { 12, 34, 56 }; 

            //Act
            int[] actual=genericClass.ToPrint(intArray);

            //Assert
           
            bool obj= intArray.Equals(actual);
        }

        [TestMethod]
        public void TestMaximumValueofInt()
        {
            //AAA methodology

            //Arrange
            int first = 20, second = 45, third = 30;
            int expected = second;

            //Act 
            int actual=three.FindMaxValueOfInt(first,second,third);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMaximumValueofFloat()
        {
            //AAA methodology

            //Arrange
            float first = 20.23f, second = 45.2f, third = 30.12f;
            float expected = second;

            //Act 
            float actual = three.FindMaxValueOfFloat(first, second, third);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMaximumValueofString()
        {
            //AAA methodology

            //Arrange
           string first = "xyz", second = "abc", third = "pqr";
            string expected = first;

            //Act 
            string actual = three.FindMaxValueOfString(first, second, third);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMaximumValueUsingGenercisConcept()
        {
            //AAA methodology

            //Arrange
           
            int expected = 40;

            //Act 
            int actual=maxInt.TestMax();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
