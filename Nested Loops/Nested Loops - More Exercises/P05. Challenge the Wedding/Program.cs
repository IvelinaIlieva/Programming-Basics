﻿using System;

namespace P05._Challenge_the_Wedding
{
    class Program
    {
        static void Main()
        {
            int countOfMen = int.Parse(Console.ReadLine());
            int countOfWomen = int.Parse(Console.ReadLine());
            int maxCountOfTables = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int men = 1; men <= countOfMen; men++)
            {
                for (int women = 1; women <= countOfWomen; women++)
                {
                    counter++;
                    if (counter <= maxCountOfTables)
                    {
                        Console.Write($"({men} <-> {women}) ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
