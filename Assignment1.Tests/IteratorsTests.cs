using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void flatten_return_yield_returns_1_2_3_4_5_3times()
        {
            var input = new List<List<int>>(){ new List<int>(){ 1, 2, 3, 4, 5 }, new List<int>(){ 1, 2, 3, 4, 5 }, new List<int>(){ 1, 2, 3, 4, 5 } };


            var output = Assignment1.Iterators.Flatten<int>(input);
            var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            Assert.Equal(expected, output);
        }
    }
}
