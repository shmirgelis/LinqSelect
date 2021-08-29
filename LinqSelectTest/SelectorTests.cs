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
            var numbersAddOne = numbers.AddsOne();
            var convertedNumbers = new List<int> { 2, 3, 4 };
            //Assert
            Assert.Equal(convertedNumbers, numbersAddOne);

        }

        [Fact]
        public void Adds_One_To_Each_Array_Item()
        {
            //Arrange
            var numbers = new int[] { 1, 2, 3 };

            //Act
            var numbersAddOne = numbers.AddsOne();
            var convertedNumbers = new int[] { 2, 3, 4 };
            //Assert
            Assert.Equal(convertedNumbers, numbersAddOne);

        }
    }
}
