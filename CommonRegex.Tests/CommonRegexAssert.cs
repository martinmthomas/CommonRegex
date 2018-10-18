using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonRegex.Tests
{
    public class CommonRegexAssert
    {
        public string RegexName { get; private set; }
        public string Pattern { get; private set; }
        public CommonRegexAssert(string regexName, string pattern)
        {
            RegexName = regexName;
            Pattern = pattern;
        }

        void AssertRegex(string input, bool expectedResult)
        {
            var actual = Regex.IsMatch(input, Pattern);
            var validationMesg = $"{input} is {(expectedResult ? "not " : "")}a valid {RegexName}";
            Assert.AreEqual(expectedResult, actual, validationMesg);
        }

        public CommonRegexAssert IsValid(string input)
        {
            AssertRegex(input, true);
            return this;
        }

        public CommonRegexAssert IsInvalid(string input)
        {
            AssertRegex(input, false);
            return this;
        }
    }
}
