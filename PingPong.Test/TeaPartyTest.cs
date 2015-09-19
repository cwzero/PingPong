using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PingPong.Test
{
    [TestClass]
    public class TeaPartyTest
    {
        [TestMethod]
        [TestCategory("TeaParty")]
        public void ladyTest()
        {
            TeaParty teaParty = new TeaParty();
            Assert.AreEqual(teaParty.welcome("Smith", true, false), "Hello Ms. Smith");
        }

        [TestMethod]
        [TestCategory("TeaParty")]
        public void knightTest()
        {
            TeaParty teaParty = new TeaParty();
            Assert.AreEqual(teaParty.welcome("Smith", false, true), "Hello Sir Smith");
        }

        [TestMethod]
        [TestCategory("TeaParty")]
        public void dudeTest()
        {
            TeaParty teaParty = new TeaParty();
            Assert.AreEqual(teaParty.welcome("Smith", false, false), "Hello Mr. Smith");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("TeaParty"), TestCategory("Argument")]
        public void teaPartyArgumentTest()
        {
            TeaParty teaParty = new TeaParty();
            teaParty.welcome("Smith", true, true);
        }
    }
}
