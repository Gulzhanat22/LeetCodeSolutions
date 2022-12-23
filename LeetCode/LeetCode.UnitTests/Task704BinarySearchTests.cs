namespace LeetCode.UnitTests
{
    public class Task704BinarySearchTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [TestCase(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [TestCase(new int[] {-1, 0, 2, 3, 5, 6, 8, 10, 11, 12}, 8, 6)]
        [TestCase(new int[] { 2, 5 }, 5, 1)]
        [TestCase(new int[] {2}, 2, 0)]
        [TestCase(new int[] { 2 }, 3, -1)]
        public void Search_SendParams_ReturnRightValue(int[] nums, int target, int expectedResult)
        {
            
            int actualResult=Task704BinarySearch.Search(nums, target);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}