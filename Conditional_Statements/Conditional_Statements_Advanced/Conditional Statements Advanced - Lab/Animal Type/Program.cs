﻿using System;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.dog -> mammal
            //2.crocodile, tortoise, snake->reptile
            //3.others->unknown

            //input data:
            string animal = Console.ReadLine();

            //calculations:
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
