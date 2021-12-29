﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var nums = new long[n];
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                var sum = 0L;
                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += nums[prev];
                    }
                }
                nums[i] = sum;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
