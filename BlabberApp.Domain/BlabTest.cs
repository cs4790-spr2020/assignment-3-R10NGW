using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{

    [TestClass]
    public class BlabTest
    {

        Blab harness;
        string expected;
        string actual;

        [TestMethod]
        public void TestSetGetMessage()
        {
            Blab harness = new Blab();
            string expected = "neque porro quisquam est qui dolorem isum quia dolor sit amet, consectetur, adips";
            harness.Message = "neque porro quisquam est qui dolorem isum quia dolor sit amet, consectetur, adips";
            string actual = harness.Message;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserID()
        {
            Blab harness = new Blab();
            string expected = "e20c277c-9cec-4131-9bf7-9eeb43f9a114";
            harness.UserID = "e20c277c-9cec-4131-9bf7-9eeb43f9a114";
            string actual = harness.UserID;
            Assert.AreEqual(actual,expected);
        }
    }

}