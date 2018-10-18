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
                .IsValid("2000")
                .IsValid("4200")
                .IsValid("0832")
                .IsInvalid("900")
                .IsInvalid("80001")
                .IsInvalid("100a")
                .IsInvalid("")
                .IsInvalid("0032")
                .IsInvalid("")
                ;
        }

        [TestMethod]
        public void NZ_postcode()
        {
            new CommonRegexAssert("New Zealand Postcode", Postcode.NEWZEALAND)
                .IsValid("0626")
                .IsValid("7110")
                .IsValid("0832")
                .IsInvalid("900")
                .IsInvalid("80001")
                .IsInvalid("100a")
                .IsInvalid("0032")
                .IsInvalid("")
                ;
        }

        [TestMethod]
        public void Singapore_postcode()
        {
            new CommonRegexAssert("Singapore Postcode", Postcode.SINGAPORE)
                .IsValid("758391")
                .IsValid("099253")
                .IsInvalid("2000")
                .IsInvalid("7583910")
                .IsInvalid("post11")
                .IsInvalid("000999")
                .IsInvalid("")
                ;
        }

        [TestMethod]
        public void Israel_postcode()
        {
            new CommonRegexAssert("Israel Postcode", Postcode.ISRAEL)
                .IsValid("7583912")
                .IsValid("9925000")
                .IsInvalid("2000")
                .IsInvalid("75839101")
                .IsInvalid("0112999")
                .IsInvalid("")
                ;
        }

        [TestMethod]
        public void US_postcode()
        {
            new CommonRegexAssert("US Postcode", Postcode.US)
                .IsValid("01501")
                .IsValid("00501")
                .IsValid("10003")
                .IsInvalid("00051")
                .IsInvalid("3245")
                .IsInvalid("")
                ;
        }
    }
}
