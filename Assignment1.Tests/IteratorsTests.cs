using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class Given_stream_of_T_return_Stream_T
    {
        [Fact]
        public void flatten_return_yield_returns_1_2_3_4_5_3times()
        {
            var input = new List<List<int>>() { new List<int>() { 1, 2, 3, 4, 5 }, new List<int>() { 1, 2, 3, 4, 5 }, new List<int>() { 1, 2, 3, 4, 5 } };


            var output = Assignment1.Iterators.Flatten<int>(input);
            var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            Assert.Equal(expected, output);

        }

        [Fact]
        public void filter_returns_2_4_6_from_1_to_6()
        {
            Predicate<int> even = Even;
            var input = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var output = Assignment1.Iterators.Filter<int>(input, even);

            Assert.Equal(new List<int>() { 2, 4, 6 }, output);


        }

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
