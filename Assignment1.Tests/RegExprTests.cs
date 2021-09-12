using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void regTest() {

            var input = new List<string>(){"Hello World", "Hello", "Hello great world"};
            var output = Assignment1.RegExpr.SplitLine(input);

            Assert.Equal(new List<string>() {"Hello", "World", "Hello", "Hello", "great", "world" }, output);
        }

    }
}
