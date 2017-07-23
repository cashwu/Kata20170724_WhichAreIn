using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170724_WhichAreIn
{
    [TestClass]
    public class WhichAreInTests
    {
        [TestMethod]
        public void Input_s1_bull_s2_lively_harp_Should_return_empty()
        {
            var a1 = new[] { "bull" };
            var a2 = new[] { "lively", "harp" };
            var expected = new string[] { };

            var whichAreIn = new WhichAreIn();
            var actual = whichAreIn.inArray(a1, a2);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class WhichAreIn
    {
        public string[] inArray(string[] array1, string[] array2)
        {
            return new string[] {};
        }
    }
}
