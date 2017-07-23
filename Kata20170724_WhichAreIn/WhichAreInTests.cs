using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        public void Input_s1_arp_s2_lively_harp_Should_return_arp()
        {
            var a1 = new[] { "arp" };
            var a2 = new[] { "lively", "harp" };
            var expected = new[] { "arp" };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_arp_live_s2_lively_harp_Should_return_arp_live()
        {
            var a1 = new[] { "arp", "live" };
            var a2 = new[] { "lively", "harp" };
            var expected = new[] { "arp", "live" };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_arp_live_s2_lively_harp_Should_return_live()
        {
            var a1 = new[] { "bull", "live" };
            var a2 = new[] { "lively", "harp" };
            var expected = new[] { "live" };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_arp_live_strong_live_s2_lively_alive_harp_sharp_armstrong_Should_return_arp_live_strong()
        {
            var a1 = new[] { "arp", "live", "strong" };
            var a2 = new[] { "lively", "alive", "harp", "sharp", "armstrong" };
            var expected = new[] { "arp", "live", "strong" };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_tarp_mice_bull_live_s2_lively_alive_harp_sharp_armstrong_Should_return_empty()
        {
            var a1 = new[] { "tarp", "mice", "bull" };
            var a2 = new[] { "lively", "alive", "harp", "sharp", "armstrong" };
            var expected = new string[] { };

            AssertWhichAreInShouldBe(a1, a2, expected);
        }

        [TestMethod]
        public void Input_s1_live_arp_strong_live_s2_lively_alive_harp_sharp_armstrong_Should_return_arp_live_strong()
        {
            var a1 = new[] { "live", "arp", "strong" };
            var a2 = new[] { "lively", "alive", "harp", "sharp", "armstrong" };
            var expected = new[] { "arp", "live", "strong" };

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
            return array1.Where(a => array2.Any(a2 => a2.Contains(a))).Distinct().OrderBy(a => a).ToArray();
        }
    }
}