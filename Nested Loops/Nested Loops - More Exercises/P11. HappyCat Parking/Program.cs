﻿using System;

namespace P11._HappyCat_Parking
{
    class Program
    {
        static void Main()
        {
            const double EVEN_DAY_ODD_HOUR = 2.5;
            const double ODD_DAY_EVEN_HOUR = 1.25;
            const double ODDEVEN_DAY_ODDEVEN_HOUR = 1;

            int countOfDays = int.Parse(Console.ReadLine());
            int countOfHours = int.Parse(Console.ReadLine());

            double sumToPayForDay = 0;
            double totalSum = 0;

            for (int day = 1; day <= countOfDays; day++)
            {
                for (int hour = 1; hour <= countOfHours; hour++)
                {
                    while (hour <= countOfHours)
                    {
                        if (day % 2 == 0 && hour % 2 != 0)
                        {
                            sumToPayForDay += EVEN_DAY_ODD_HOUR;
                        }
                        else if (day % 2 != 0 && hour % 2 == 0)
                        {
                            sumToPayForDay += ODD_DAY_EVEN_HOUR;
                        }
                        else
                        {
                            sumToPayForDay += ODDEVEN_DAY_ODDEVEN_HOUR;
                        }
                        break;
                    }
                }
                totalSum += sumToPayForDay;
                Console.WriteLine($"Day: {day} - {sumToPayForDay:f2} leva");
                sumToPayForDay = 0;
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
