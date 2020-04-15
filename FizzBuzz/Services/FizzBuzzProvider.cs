using System;
namespace FizzBuzz.Services
{
    public class FizzBuzzProvider
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public string Fizz(int number)
        {
            return IsFizz(number) ? "Fizz" : number.ToString();
        }
    }
}
