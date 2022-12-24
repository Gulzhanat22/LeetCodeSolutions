using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.UnitTests
{
    public class SearchInsertPositionTests
    {
        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void SearchInsert_ReceivesValidArray_ReturnCorrectResult(int[] nums, int target, int expectedResult)
        {
            var actualResult = SearchInsertPosition.SearchInsert(nums, target);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
