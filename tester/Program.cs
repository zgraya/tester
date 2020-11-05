using System;
using System.Collections.Generic;

namespace tester
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Exercise checker = new Exercise();
            var result = Exercise.Solution(new List<string>{"a", "b", "c"});
            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}