﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.UnitTests
{
    public class PlusOneTests
    {
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9, 9 }, new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
        [TestCase(new int[] { 9, 8, 9 }, new int[] { 9, 9, 0})]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
        [TestCase(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 },
            new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7 })]
        public void AddPlusOne_ValidParams_ReturnCorrectResult(int[] digits, int[] expectedResult)
        {
            var actualResult = PlusOne.AddPlusOne(digits);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
