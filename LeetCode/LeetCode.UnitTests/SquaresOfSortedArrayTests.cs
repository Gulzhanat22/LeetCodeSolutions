using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.UnitTests
{
    public class SquaresOfSortedArrayTests
    {
        [TestCase(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
        [TestCase(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
        public void SortedSquares_ValidArray_ReturnsCorrectResult(int[] nums, int[] expectedResult)
        {
            var actualResult = SquaresOfSortedArray.SortedSquares(nums);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
