using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using KataConsole.Sorting;

namespace Kata.Tests.Sorting
{
    public class BubbleSortTests
    {

        [Theory]
        [InlineData(new int[] { 1, 10, 11, 15, 4, 6 })]
        [InlineData(new int[] { -1, 10, 11, 15, 4, 6, 0, int.MinValue })]
        [InlineData(new int[] { 1, 10, 11, 15, 4, 6, 1 })]
        public void ElementsShouldBeSorted(int[] toSort)
        {
            //Arrange
            var bubbleSort = new BubbleSort();
            //Act
            bubbleSort.Sort(ref toSort);

            //Assert
            toSort.Should().BeInAscendingOrder();
        }
    }
}
