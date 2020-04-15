using System;
using FizzBuzz.Providers;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzProvider();
            for (int i = 1; i < 101; i++)
            {
                var output = fizzBuzzService.FizzBuzz(i);
                Console.WriteLine(output);
            }
        }
    }
}
