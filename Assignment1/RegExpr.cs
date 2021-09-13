using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
        string pattern = @"[a-zA-Z0-9]+";
        foreach(var line in lines) {
            string input = line;
            foreach (Match m in Regex.Matches(input, pattern))
        {
            yield return m.ToString();
        }
        }

        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            string pattern = @"<" + @tag + @".*?>(.*?)</" + @tag + @">";

            foreach (Match m in Regex.Matches(html, pattern))
            {
                var temp = Regex.Replace(m.Groups[1].Value.Trim(), @"(<.*?>)", "");
                yield return temp;
            }

        }
    }
}
