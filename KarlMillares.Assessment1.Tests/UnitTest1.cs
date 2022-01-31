using KarlMillares_Assessment1.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace KarlMillares.Assessment1.Tests
{
    public class UnitTest1
    {
        public static List<object[]> GetNumbers()
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new Numbers(25)
                }
            };

            return data;
        }

        [InlineData(25)]
        [InlineData(50)]
        [InlineData(5)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(1)]
        [InlineData(99)]
        [Theory]
        public void GetRemovedNumberInSorted_ShouldCallMethodAndReturnResult_WhenRequestIsValid(int removedNumber)
        {
            var numbers = new Numbers(removedNumber);
            int removedNumberWhenSorted = numbers.GetRemovedNumberInSorted();
            Assert.Equal(removedNumber, removedNumberWhenSorted);
        }

        
    }
}
