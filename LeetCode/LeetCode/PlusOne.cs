using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class PlusOne
    {
        public static int[] AddPlusOne(int[] digits)
        {
            int lastindex = digits.Length - 1;
            if (digits[lastindex] != 9)
            {
                digits[lastindex]++;
            }
            else
            {
                if (lastindex == 0)
                {
                    return new int[] { 1, 0 };
                }
                while (digits[lastindex] == 9 && lastindex > 0)
                {
                    digits[lastindex] = 0;
                    lastindex--;
                }
                digits[lastindex]++;
                if (digits[0] == 10)
                {
                    var result = new int[digits.Length + 1];
                    result[0] = 1;
                    result[1] = 0;
                    for (int i = 2; i < result.Length; i++)
                    {
                        int j = 1;
                        result[i] = digits[j];
                        j++;
                    }
                    return result;
                }
            }
            return digits;
        }
    }
}
