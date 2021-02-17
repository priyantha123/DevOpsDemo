using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace DevOpsDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Time {0} ", DateTime.Now);
            System.Threading.Thread.Sleep(300000);
            Debug.WriteLine("Time {0} ", DateTime.Now);
        }
    }
}
