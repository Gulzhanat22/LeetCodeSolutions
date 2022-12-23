namespace LeetCode
{
    public static class Task704BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int lastIndex = nums.Length - 1;
            int startIndex = 0;
            int mid;
            while(startIndex <= lastIndex)
            {
                mid = (lastIndex + startIndex) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    lastIndex = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    startIndex = mid + 1;
                }
            } 

            
            return -1;
        }

    }
}