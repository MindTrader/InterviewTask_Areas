﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public static class Utils
    {
        public static void Swap<T>(ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
