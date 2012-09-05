using DataHub.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDataHub
{

    /// <summary>
    ///This is a test class for DataHubTraceListenerTest and is intended
    ///to contain all DataHubTraceListenerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataHubTraceListenerTest
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
        ///A test for WriteLog
        ///</summary>
        [TestMethod()]
        public void WriteLogTest()
        {
            DataHubTraceListener target = new DataHubTraceListener(); // TODO: Initialize to an appropriate value
            string roleInstanceId = string.Empty; // TODO: Initialize to an appropriate value
            string deploymentId = string.Empty; // TODO: Initialize to an appropriate value
            string category = string.Empty; // TODO: Initialize to an appropriate value
            string loggingModule = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            string stackTrace = string.Empty; // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value

            roleInstanceId = "String1";
            deploymentId = "String1";
            category = "String1";
            loggingModule = "String1";
            message = "String1";
            stackTrace = "String1";
            tenantId = "F15BF469-1D9C-49FE-AE18-638D7BAFF053";

            target.WriteLog(roleInstanceId, deploymentId, category, loggingModule, message, stackTrace, tenantId);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DataHubTraceListener Constructor
        ///</summary>
        [TestMethod()]
        public void DataHubTraceListenerConstructorTest()
        {
            DataHubTraceListener target = new DataHubTraceListener();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            DataHubTraceListener target = new DataHubTraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            message = "Message1";

            target.Write(message);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for WriteLine
        ///</summary>
        [TestMethod()]
        public void WriteLineTest()
        {
            DataHubTraceListener target = new DataHubTraceListener(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            message = "Message1";
            target.WriteLine(message);
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
