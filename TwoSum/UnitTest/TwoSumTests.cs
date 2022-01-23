using System;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTest
{
    public class TwoSumTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null, 1, null)]
        [TestCase(new[] { 1 }, 1, null)]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        public void Can_get_answer(int[] input, int target, int[] expect)
        {
            var result = TwoSum.TwoSum.GetAnswer(input, target);
            result.Should().Equal(expect);
        }
    }
}