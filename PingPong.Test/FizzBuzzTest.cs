using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [TestCategory("FizzBuzz")]
        public void fizzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.answer(3), "Fizz");
        }

        [TestMethod]
        [TestCategory("FizzBuzz")]
        public void buzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.answer(5), "Buzz");
        }

        [TestMethod]
        [TestCategory("FizzBuzz")]
        public void fizzBuzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.answer(15), "FizzBuzz");
        }

        [TestMethod]
        [TestCategory("FizzBuzz")]
        public void numberTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.answer(2), "2");
        }
    }
}
