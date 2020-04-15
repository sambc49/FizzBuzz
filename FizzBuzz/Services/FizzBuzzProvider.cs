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

        public string FizzBuzz(int number)
        {
            if(IsFizz(number) && IsBuzz(number))
            {
                return "FizzBuzz";
            }
            if (IsFizz(number))
            {
                return "Fizz";
            }
            if (IsBuzz(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
