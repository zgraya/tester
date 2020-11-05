using System;
using System.Collections.Generic;

namespace BITCounting
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            var result = BitCounting.countBits(12345);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}