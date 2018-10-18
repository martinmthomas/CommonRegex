using System;
using System.Collections.Generic;
using System.Text;

namespace CommonRegex
{
    public static class Postcode
    {
        public const string AUSTRALIA = @"^(([1-9]\d{3})|(0[1-9]\d{2}))$";
        public const string NEWZEALAND = @"^(([1-9]\d{3})|(0[1-9]\d{2}))$";
        public const string SINGAPORE = @"^(([1-9]\d{5})|(0[1-9]\d{4}))$";
        public const string ISRAEL = @"^([1-9]\d{6})$";
        public const string US = @"^(([1-9]\d{4})|(0[1-9]\d{3})|(00[1-9]\d{2}))$";
    }
}
