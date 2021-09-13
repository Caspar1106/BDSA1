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

        [Fact]
        public void InnerText_One_Tag_Test()
        {

            var input = "<a href=someHref :) sasdasasfa filler text > This seems to work </a>";
            var output = Assignment1.RegExpr.InnerText(input, "a");

            Assert.Equal(new List<string>() { "This seems to work" }, output);
        }
        [Fact]
        public void InnerText_3_Tag_Test()
        {

            var input = "<a href=someHref :) sasdasasfa filler text > This seems to work </a><i> This should be ignored </i> <a asd asd sdas> Round 2</a>";
            var output = Assignment1.RegExpr.InnerText(input, "a");

            Assert.Equal(new List<string>() { "This seems to work", "Round 2" }, output);
        }

        [Fact]
        public void InnerText_Full_Div_Test()
        {

            var input = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=/wiki/Theoretical_computer_science title=Theoretical computer science>theoretical computer science</a> and <a href=/wiki/Formal_language title=Formal language>formal language</a> theory, a sequence of <a href=/wiki/Character_(computing) title=Character (computing)>characters</a> that define a <i>search <a href=/wiki/Pattern_matching title=Pattern matching>pattern</a></i>. Usually this pattern is then used by <a href=/wiki/String_searching_algorithm title=String searching algorithm>string searching algorithms</a> for find or find and replace operations on <a href=/wiki/String_(computer_science) title=String (computer science)>strings</a>.</p></div>";
            var output = Assignment1.RegExpr.InnerText(input, "a");

            Assert.Equal(new List<string>() { "theoretical computer science",
            "formal language", "characters", "pattern", "string searching algorithms", "strings" }, output);
        }

        [Fact]
        public void InnerText_Nested_Tags()
        {

            var input = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
           var output = Assignment1.RegExpr.InnerText(input, "p");

            Assert.Equal(new List<string>() { "The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to." }, output);
        }
    }
}
