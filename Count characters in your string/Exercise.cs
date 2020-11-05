using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Count_characters_in_your_string
{
    public class Exercise
    {
        public static Dictionary<char, int> Count(string stringy)
        {
            string word = stringy;
            var Result = new Dictionary<char, int>();
            var Result2 = new object();
            int indexer = 1;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                var letter = word[i];
                if(!Result.Keys.Contains(letter))
                {
                    Result.Add(letter, indexer);
                }
                else
                {
                    Result[letter] += 1;
                }
            }
            return Result;
        }
    }
}