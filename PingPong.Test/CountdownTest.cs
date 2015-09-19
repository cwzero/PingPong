using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Test
{
    [TestClass]
    public class CountdownTest
    {        
        [TestMethod]
        [TestCategory("Countdown")]
        public void countdownTest()
        {
            Countdown countdown = new Countdown();
            int[] cd = countdown.countdown(4);
            Assert.AreEqual(cd.Length, 5);
            Assert.AreEqual(cd[0], 4);
            Assert.AreEqual(cd[1], 3);
            Assert.AreEqual(cd[2], 2);
            Assert.AreEqual(cd[3], 1);
            Assert.AreEqual(cd[4], 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("Countdown"), TestCategory("Argument")]
        public void countdownArgumentTest()
        {
            new Countdown().countdown(-1);
        }
    }
}
