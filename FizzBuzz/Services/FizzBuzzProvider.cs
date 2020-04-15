using System;
namespace FizzBuzz.Services
{
    public class FizzBuzzProvider
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}
