using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebhookTestApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookTestApplication.Tests
{
    [TestClass()]
    public class TestClassTests
    {
        [TestMethod()]
        public void TestedMethodTest()
        {
            TestClass tc = new TestClass();
            tc.TestedMethod("Test 3!");
        }
    }
}