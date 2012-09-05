using DataHub.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for LogEntityTest and is intended
    ///to contain all LogEntityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogEntityTest
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
        ///A test for LogEntity Constructor
        ///</summary>
        [TestMethod()]
        public void LogEntityConstructorTest()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            string category = string.Empty; // TODO: Initialize to an appropriate value
            string roleInstanceId = string.Empty; // TODO: Initialize to an appropriate value
            string deploymentId = string.Empty; // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value

            roleInstanceId = "String1";
            category = "String1";
            message = "String1";
            tenantId = "ECC849C3-7ECD-45BA-BBAF-8DC4F95FA4A8";
            LogEntity target = new LogEntity(message, category, roleInstanceId, deploymentId, tenantId);
           // Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
