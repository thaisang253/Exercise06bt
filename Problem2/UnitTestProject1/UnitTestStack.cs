using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestProblem2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCount()
        {
            Stack s1 = new Stack(10);
            s1.push("1");
            s1.push("2");
            s1.push("3");
            Assert.AreEqual(3, s1.count());
        }
        [TestMethod]
        public void CheckPop()
        {
            Stack s2 = new Stack(10);
            s2.push("1");
            s2.push("2");
            s2.push("3");
            Assert.AreEqual(3, s2.pop());
        }
        [TestMethod]
        public void CheckPeek()
        {
            Stack s3 = new Stack(10);
            s3.push("1");
            s3.push("2");
            s3.push("3");
            Assert.AreEqual(3, s3.peek());
        }
    }
}
