﻿using System;

namespace T03._Combinations
{
    class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (int x1 = 0; x1 <= sum; x1++)
            {
                for (int x2 = 0; x2 <= sum; x2++)
                {
                    for (int x3 = 0; x3 <= sum; x3++)
                    {
                        if (x1 + x2 + x3 == sum)
                        {
                            combinations++;                            
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
