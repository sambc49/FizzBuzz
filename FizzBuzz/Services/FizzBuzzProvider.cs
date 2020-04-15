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
            var isFizz = IsFizz(number);
            var isBuzz = IsBuzz(number);

            if(isFizz && isBuzz)
            {
                return "FizzBuzz";
            }
            if (isFizz)
            {
                return "Fizz";
            }
            if (isBuzz)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
