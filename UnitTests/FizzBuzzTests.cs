using FizzBuzz.Providers;
using NUnit.Framework;

namespace UnitTests
{
    public class FizzBuzzTests
    {
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

        [Test]
        public void OutputShouldBeFizz()
        {
            //arrange
            var service = BuildService();
            var expected = "Fizz";

            //act
            var result = service.FizzBuzz(3);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OutputShouldBeBuzz()
        {
            //arrange
            var service = BuildService();
            var expected = "Buzz";

            //act
            var result = service.FizzBuzz(5);

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void OutputShouldBeNumber()
        {
            //arrange
            var service = BuildService();
            var expected = "4";

            //act
            var result = service.FizzBuzz(4);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OutputShouldBeFizzBuzz()
        {
            //arrange
            var service = BuildService();
            var expected = "FizzBuzz";

            //act
            var result = service.FizzBuzz(15);

            //assert
            Assert.AreEqual(expected, result);
        }

        private FizzBuzzProvider BuildService()
        {
            return new FizzBuzzProvider();
        }
    }
}