using System;
using System.Collections;
using System.Linq;
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

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_arp_s2_lively_harp_Should_return_empty()
        {
            var a1 = new[] { "arp" };
            var a2 = new[] { "lively", "harp" };
            var expected = new [] { "arp" };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        private static void AssertWhichAreInShouldBe(string[] a1, string[] a2, string[] expected)
        {
            var whichAreIn = new WhichAreIn();
            var actual = whichAreIn.inArray(a1, a2);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class WhichAreIn
    {
        public string[] inArray(string[] array1, string[] array2)
        {
            var item = array1[0];
            if (array2.Any(a => a.Contains(item)))
            {
                return array1;
            }

            return new string[]{};
        }
    }
}
