﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtAmpDotNet.Extensions
{
    public static class ValueExtensions
    {
        public static float Remap(this float from, float fromMin, float fromMax, float toMin, float toMax)
        {
            var fromAbs = (from - fromMin);
            var fromMaxAbs = (fromMax - fromMin);
            var normal = (fromAbs / fromMaxAbs);
            var toMaxAbs = (toMax - toMin);
            var toAbs = (toMaxAbs * normal);
            var to = (toAbs + toMin);
            return to;
        }
    }
}
