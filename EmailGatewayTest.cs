using DataHub.Notification.Gateway;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for EmailGatewayTest and is intended
    ///to contain all EmailGatewayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmailGatewayTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SendAndLog
        ///</summary>
        [TestMethod()]
        public void SendAndLogTest()
        {
            EmailGateway target = new EmailGateway(); // TODO: Initialize to an appropriate value
            string messageToLog = string.Empty; // TODO: Initialize to an appropriate value
            messageToLog = "Message1";
            target.SendAndLog(messageToLog);
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EmailGateway Constructor
        ///</summary>
        [TestMethod()]
        public void EmailGatewayConstructorTest()
        {
            EmailGateway target = new EmailGateway();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetMailAddress
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DataHub.Notification.Gateway.dll")]
        public void GetMailAddressTest()
        {
            string mailAddress = string.Empty; // TODO: Initialize to an appropriate value
            mailAddress = "manjuse@gmail.com";
            MailAddress expected = null; // TODO: Initialize to an appropriate value
            MailAddress actual;
            actual = EmailGateway_Accessor.GetMailAddress(mailAddress);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Send
        ///</summary>
        [TestMethod()]
        public void SendTest()
        {
            EmailGateway target = new EmailGateway(); // TODO: Initialize to an appropriate value
            target.Send();
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
