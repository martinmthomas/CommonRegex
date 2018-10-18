using System;
using System.Collections.Generic;
using System.Text;

namespace CommonRegex
{
    public static class Postcode
    {
        public const string Australia = @"^(([1-9]\d{3})|(0[1-9]\d{2}))$";
        public const string NewZealand = @"^(([1-9]\d{3})|(0[1-9]\d{2}))$";
        public const string Singapore = @"^(([1-9]\d{5})|(0[1-9]\d{4}))$";
    }
}
