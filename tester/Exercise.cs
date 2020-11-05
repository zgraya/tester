using System;
using System.Collections.Generic;
using System.Linq;

namespace tester
{
    public class Exercise
    {
        public static List<string> Solution(List<string> lines)
        {
            var addings = lines;
            int counter = 1;
            for (int i = 0; i < addings.Count; i++)
            {
                addings[i] = addings[i].Insert(0, $"{counter}: ");
                counter += 1;
            }

            return addings;


        }



    }
}