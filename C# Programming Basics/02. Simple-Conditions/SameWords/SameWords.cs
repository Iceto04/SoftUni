﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameWords
{
    class SameWords
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine().ToLower();
            var word2 = Console.ReadLine().ToLower();
            if (word1 == word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
