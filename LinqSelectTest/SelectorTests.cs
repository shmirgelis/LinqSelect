using System;
using Xunit;
using LinqSelect;
using System.Collections.Generic;

namespace LinqSelectTest
{
    public class SelectorTests
    {
        [Fact]
        public void Adds_One_To_Each_List_Item()
        {
            //Arrange
            var numbers = new List<int> { 1, 2, 3 };

            //Act
            var numbersAddOne = numbers.Transform(num => num + 1);
            var convertedNumbers = new List<int> { 2, 3, 4 };

            //Assert
            Assert.Equal(convertedNumbers, numbersAddOne);

            //int TransformNum(int num)  //veliau galima sukurt anonimus, pakolkas pasizaist su debugeriu
            //{
            //    int transformedNumber = num + 1;
            //    return transformedNumber;
            //}
        }

        [Fact]
        public void Adds_One_To_Each_Array_Item()
        {
            //Arrange
            var numbers = new int[] { 1, 2, 3 };

            //Act
            var numbersAddOne = numbers.Transform(num => num + 1);
            var convertedNumbers = new int[] { 2, 3, 4 };

            //Assert
            Assert.Equal(convertedNumbers, numbersAddOne);
        }

        [Fact]
        public void Multiply_Each_Array_Item_By_5()
        {
            //Arrange
            var numbers = new int[] { 1, 2, 3 };

            //Act
            var multipliedNumbers = numbers.Transform(num => num * 5);
            var convertedNumbers = new int[] { 5, 10, 15 };

            //Assert
            Assert.Equal(convertedNumbers, multipliedNumbers);
        }

        [Fact]
        public void Find_Division_By_3_Remainder_Of_Each_Array_Item()
        {
            //Arrange
            var numbers = new int[] { 2, 3, 4 };

            //Act
            var numberRemainders = numbers.Transform(num => num % 3);
            var convertedNumbers = new int[] { 2, 0, 1 };

            //Assert
            Assert.Equal(convertedNumbers, numberRemainders);
        }

        [Fact]
        public void Integer_To_String()
        {
            //Arrange
            var numbers = new int[] { 1, 2, 3 };

            //Act
            var converted = numbers.Transform(x => x.ToString());
            var convertedNumbers = new string[] { "1", "2", "3" };

            //Assert
            Assert.Equal(convertedNumbers, converted);
        }

        [Fact]
        public void Add_Exclamation_Mark_To_String()
        {
            //Arrange
            var numbers = new string[] { "One", "Two", "Three" };

            //Act
            var converted = numbers.Transform(x => x + "!");
            var convertedNumbers = new string[] { "One!", "Two!", "Three!" };

            //Assert
            Assert.Equal(convertedNumbers, converted);
        }

        [Fact]
        public void Check_If_String_Has_All_Capitals()
        {
            //Arrange
            var strings = new string[] { "A", "Ab", "BC" };

            //Act
            var isCapital = strings.Transform(x => x == x.ToUpper());
            var isCapitalResult = new bool[] { true, false, true };

            //Assert
            Assert.Equal(isCapitalResult, isCapital);

        }
    }
}



