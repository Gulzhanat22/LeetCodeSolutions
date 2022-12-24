using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SquaresOfSortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            var indexOfZero=SearchInsertPosition.SearchInsert(nums, 0);

            for (int i = 0; i < indexOfZero; i++)
            {
                nums[i] = Math.Abs(nums[i]);
            }
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            return nums;
        }
    }
}
