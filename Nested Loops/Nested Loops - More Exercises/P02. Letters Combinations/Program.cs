﻿using System;

namespace P02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char finishLetter = char.Parse(Console.ReadLine());
            char excludeLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = startLetter; i <= finishLetter; i++)
            {
                for (char j = startLetter; j <= finishLetter; j++)
                {
                    for (char l = startLetter; l <= finishLetter; l++)
                    {
                        if (i == excludeLetter || j == excludeLetter || l == excludeLetter)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write($"{i}{j}{l} ");
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
