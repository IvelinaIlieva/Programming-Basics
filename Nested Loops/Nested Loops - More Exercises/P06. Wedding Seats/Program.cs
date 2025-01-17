﻿using System;

namespace P06._Wedding_Seats
{
    class Program
    {
        static void Main()
        {
            char lastSector = char.Parse(Console.ReadLine());
            int countOfRowsFirstSector = int.Parse(Console.ReadLine());
            int countOfSeatsOddRow = int.Parse(Console.ReadLine());

            int countOfRowsNextSector = countOfRowsFirstSector;
            int counter = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int rows = 1; rows <= countOfRowsNextSector; rows++)
                {
                    int seats = countOfSeatsOddRow;
                    if (rows % 2 != 0)
                    {
                        for (char places = 'a'; places < 97+seats; places++)
                        {
                            counter++;
                            Console.WriteLine($"{sector}{rows}{places}");
                        }
                    }
                    else
                    {
                        seats +=2;
                        for (char places = 'a'; places < 97 + seats; places++)
                        {
                            counter++;
                            Console.WriteLine($"{sector}{rows}{places}");
                        }
                    }
                }
                countOfRowsNextSector++;
            }
            Console.WriteLine(counter);
        }
    }
}
