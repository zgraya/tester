using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace BITCounting
{
    
    
    public class BitCounting {

        public static int countBits(int n)
        {
            int convert = n;
            int result = 0;

            while (convert > 0)
            {
                if ((convert % 2) == 1)
                {
                    result++;
                }

                convert >>= 1;
            }

            return result;
        }

    }
}