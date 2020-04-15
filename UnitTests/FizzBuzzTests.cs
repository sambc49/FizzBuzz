using FizzBuzz.Services;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        private int _maxCount = 100;
        [SetUp]
        public void Setup()
        {
        }

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

        private FizzBuzzProvider BuildService()
        {
            return new FizzBuzzProvider();
        }
    }
}