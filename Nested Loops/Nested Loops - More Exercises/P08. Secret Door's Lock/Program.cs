﻿using System;

namespace P08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main()
        {
            int hundredsMax = int.Parse(Console.ReadLine());
            int tensMax = int.Parse(Console.ReadLine());
            int unitsMax = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int hundreds = 1; hundreds <= hundredsMax; hundreds++)
            {
                if (hundreds % 2 == 0)
                {
                    int number1 = hundreds;

                    for (int tens = 2; tens <= tensMax; tens++)
                    {
                        for (int i = 1; i <= tens; i++)
                        {
                            if (tens % i == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter > 2)
                        {
                            counter = 0;
                            continue;
                        }
                        else if (counter == 2)
                        {
                            int number2 = tens;
                            counter = 0;

                            for (int units = 1; units <= unitsMax; units++)
                            {
                                if (units % 2 == 0)
                                {
                                    int number3 = units;

                                    Console.WriteLine($"{number1} {number2} {number3}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
