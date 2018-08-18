using NUnit.Framework;

namespace FizzBuzz2.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void SetUp()
        {
           fizzBuzzer = new FizzBuzzer();
        }

        [Test]
        public void FizzBuzzer_Returns_1_For_1()
        {
            var result = fizzBuzzer.FizzBuzz(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void FizzBuzzer_Returns_2_For_2()
        {
            var result = fizzBuzzer.FizzBuzz(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void FizzBuzzer_Returns_Fizz_For_3()
        {
            var result = fizzBuzzer.FizzBuzz(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Fizz_For_6()
        {
            var result = fizzBuzzer.FizzBuzz(6);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Buzz_For_5()
        {
            var result = fizzBuzzer.FizzBuzz(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_Buzz_For_Mod_5()
        {
            var result = fizzBuzzer.FizzBuzz(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_FizzBuzz_For_15()
        {
            var result = fizzBuzzer.FizzBuzz(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void FizzBuzzer_Returns_FizzBuzz_For_30()
        {
            var result = fizzBuzzer.FizzBuzz(30);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}