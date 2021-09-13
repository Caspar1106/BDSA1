using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void splitLine_returns_stream_of_words() {

            var input = new List<string>(){"Hello World", "Hello", "Hello great world123"};
            var output = Assignment1.RegExpr.SplitLine(input);

            Assert.Equal(new List<string>() {"Hello", "World", "Hello", "Hello", "great", "world123" }, output);
        }

    }
}
