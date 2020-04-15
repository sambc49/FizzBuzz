﻿using System;
using FizzBuzz.Services;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzProvider();
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(fizzBuzzService.FizzBuzz(i));
            }
        }
    }
}
