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

        public string Buzz(int number)
        {
            return IsBuzz(number) ? "Buzz" : number.ToString();
        }

        public string FizzBuzz(int number)
        {
            var stringToReturn = string.Empty;
            if (IsFizz(number))
            {
                stringToReturn = "Fizz";
            }
            if (IsBuzz(number))
            {
                stringToReturn += "Buzz";
            }
            else
            {
                stringToReturn = number.ToString();
            }
            return stringToReturn;
        }
    }
}
