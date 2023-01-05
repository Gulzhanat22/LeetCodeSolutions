using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LengthOfLastWord
    {
        public static int FindLengthOfLastWord(string s)
        {
            var words=s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var length = words[words.Length-1].Length;
            return length;
        }
    }
}
