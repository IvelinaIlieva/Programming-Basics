﻿using System;

namespace P10._Profit
{
    class Program
    {
        static void Main()
        {
            int countOf1Lev = int.Parse(Console.ReadLine());
            int countOf2Leva = int.Parse(Console.ReadLine());
            int countOf5Leva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int oneLev = 0; oneLev <= countOf1Lev; oneLev++)
            {
                for (int twoLeva = 0; twoLeva <= countOf2Leva; twoLeva++)
                {
                    for (int fiveLeva = 0; fiveLeva <= countOf5Leva; fiveLeva++)
                    {
                        if (oneLev * 1 + twoLeva * 2 + fiveLeva * 5 == sum)
                        {
                            Console.WriteLine($"{oneLev} * 1 lv. + {twoLeva} * 2 lv. + {fiveLeva} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
