using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void splitLine_for_Hello_World_Hello_And_Hello_Great_World()
        {

            var input = new List<string>() { "Hello World", "Hello", "Hello great world" };
            var output = Assignment1.RegExpr.SplitLine(input);

            Assert.Equal(new List<string>() { "Hello", "World", "Hello", "Hello", "great", "world" }, output);
        }

        [Fact]
        public void Resolution_single_line_input_1920x1080()
        {

            var input = "1920x1080";
            var output = Assignment1.RegExpr.Resolution(input);

            Assert.Equal(new List<(int, int)>() { (1920, 1080) }, output);
        }

        [Fact]
        public void Resolution_Multiple_Resolutions_In_One_String()
        {

            var input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";
            var output = Assignment1.RegExpr.Resolution(input);

            Assert.Equal(new List<(int, int)>() {(1920, 1080), (1024, 768), (800, 600),
            (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)}, output);
        }
    }
}
