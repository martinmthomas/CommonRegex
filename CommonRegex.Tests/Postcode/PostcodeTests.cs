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
            new CommonRegexAssert("Australian Postcode", Postcode.Australia)
                .IsValid("2000")
                .IsValid("4200")
                .IsValid("0832")
                .IsInvalid("900")
                .IsInvalid("80001")
                .IsInvalid("100a")
                .IsInvalid("")
                .IsInvalid("0032")
                ;
        }

        [TestMethod]
        public void NZ_postcode()
        {
            new CommonRegexAssert("New Zealand Postcode", Postcode.NewZealand)
                .IsValid("0626")
                .IsValid("7110")
                .IsValid("0832")
                .IsInvalid("900")
                .IsInvalid("80001")
                .IsInvalid("100a")
                .IsInvalid("0032")
                ;
        }

        [TestMethod]
        public void Singapore_postcode()
        {
            new CommonRegexAssert("Singapore Postcode", Postcode.Singapore)
                .IsValid("758391")
                .IsValid("099253")
                .IsInvalid("2000")
                .IsInvalid("7583910")
                .IsInvalid("post11")
                .IsInvalid("000999")
                ;
        }
    }
}
