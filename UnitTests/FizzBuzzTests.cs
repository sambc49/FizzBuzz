using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        private int _maxCount = 100;

        [Test]
        public void IsFizzShouldBeTrue()
        {
            //arrange
            var service = BuildService();
            bool expected = true;

            //act
            var result = service.IsFizz(3);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsFizzShouldNotBeTrue()
        {
            //arrange
            var service = BuildService();
            bool expected = false;

            //act
            var result = service.IsFizz(1);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsBuzzShouldBeTrue()
        {
            //arrange
            var service = BuildService();
            bool expected = true;

            //act
            var result = service.IsBuzz(5);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsBuzzShouldBeFalse()
        {
            //arrange
            var service = BuildService();
            bool expected = false;

            //act
            var result = service.IsBuzz(1);

            //assert
            Assert.AreEqual(expected, result);
        }

        private FizzBuzzProvider BuildService()
        {
            return new FizzBuzzProvider();
        }
    }
}