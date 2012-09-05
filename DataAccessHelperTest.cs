using DataHub.BackgroundService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataHub.BackgroundService.Models;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for DataAccessHelperTest and is intended
    ///to contain all DataAccessHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataAccessHelperTest
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
        ///A test for GetTenantDetails
        ///</summary>
        [TestMethod()]
        public void GetTenantDetailsTest()
        {
            DataAccessHelper target = new DataAccessHelper(); // TODO: Initialize to an appropriate value
            string strTenantID = string.Empty; // TODO: Initialize to an appropriate value
            Tenant expected = null; // TODO: Initialize to an appropriate value
            Tenant actual;

            strTenantID = "C428C08B-A863-4814-A250-58F7421F5FF0";
            
            actual = target.GetTenantDetails(strTenantID);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
