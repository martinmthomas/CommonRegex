using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CommonRegex.Tests
{
    [TestClass]
    public class PostcodeTests
    {
        [TestMethod]
        public void AUS_postcode()
        {
            new CommonRegexAssert("Australian Postcode", Postcode.AUSTRALIA)
                .IsValid(new string[] { "2000", "4200", "0832" })
                .IsInvalid(new string[] { "", "900", "80001", "100a", "0032" });
        }

        [TestMethod]
        public void NZ_postcode()
        {
            new CommonRegexAssert("New Zealand Postcode", Postcode.NEWZEALAND)
                .IsValid(new string[] { "0626", "7110", "0832" })
                .IsInvalid(new string[] { "", "900", "80001", "100a", "0032" });
        }

        [TestMethod]
        public void Singapore_postcode()
        {
            new CommonRegexAssert("Singapore Postcode", Postcode.SINGAPORE)
                .IsValid(new string[] { "758391", "099253" })
                .IsInvalid(new string[] { "", "2000", "7583910", "post11", "000999" });
        }

        [TestMethod]
        public void Israel_postcode()
        {
            new CommonRegexAssert("Israel Postcode", Postcode.ISRAEL)
                .IsValid(new string[] { "7583912", "9925000" })
                .IsInvalid(new string[] { "", "2000", "75839101", "0112999" });
        }

        [TestMethod]
        public void US_postcode()
        {
            new CommonRegexAssert("US Postcode", Postcode.US)
                .IsValid(new string[] { "01501", "00501", "10003" })
                .IsInvalid(new string[] { "", "00051", "3245" });
        }
    }
}
