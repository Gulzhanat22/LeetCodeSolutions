using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.UnitTests
{
    public class LengthOfLastWordTests
    {
        [TestCase("Hello World", 5)]
        [TestCase("   fly me   to   the moon  ", 4)]
        public void FindLengthOfLastWord_ValidString_ReturnCorrectResult(string s, int expectedResult)
        {
            var actualResult = LengthOfLastWord.FindLengthOfLastWord(s);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
