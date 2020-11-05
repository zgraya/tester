using System;
using System.Collections.Generic;

namespace Count_characters_in_your_string
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Exercise checker = new Exercise();
            var result = Exercise.Count("");
            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}