using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Moq;
using MOQPractice;
using Assert = NUnit.Framework.Assert;

namespace MoqTesting
{
    [TestClass()]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod()]
        public void Test1()
        {
            var process = new Process();


            //without MOQ   , test case fail 

            SubProcess mailObject = new SubProcess();
            var response = process.AddProcess(mailObject);
            Assert.AreEqual(response, true);


            //with MOQ , test success 

            //Mock<SubProcess> mailObject = new Mock<SubProcess>();
            //mailObject.Setup(x => x.AnotherProcess()).Returns(1);
            //var response = process.AddProcess(mailObject.Object);
            //Assert.AreEqual(response, true);
        }
    }
}