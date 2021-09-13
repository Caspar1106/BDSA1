using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            string pattern = @"[a-zA-Z0-9]+";
            foreach (var line in lines)
            {
                string input = line;
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    yield return m.ToString();
                }
            }

        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            foreach (Match m in Regex.Matches(resolutions, @"(\d+)x(\d+)"))
            {
                var width = Int32.Parse(m.Groups[1].Value);
                var height = Int32.Parse(m.Groups[2].Value);
                yield return (width, height);
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            string pattern = @".*<" + @tag + @".*> (.*)\</" + @tag + @">.*";

            foreach (Match m in Regex.Matches(html, pattern))
            {
                yield return m.Groups[1].Value.Trim();
            }

        }
    }
}