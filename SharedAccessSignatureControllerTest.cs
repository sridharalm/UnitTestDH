using DataHub.CloudService.Web.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Net.Http;
using System.Collections.Generic;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for SharedAccessSignatureControllerTest and is intended
    ///to contain all SharedAccessSignatureControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SharedAccessSignatureControllerTest
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
        ///A test for SharedAccessSignatureController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void SharedAccessSignatureControllerConstructorTest()
        {
            SharedAccessSignatureController target = new SharedAccessSignatureController();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void GetTest()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            //var formVars = new Dictionary<string,string>();
            //formVars.Add("message", "Some Value");
            //var content = new FormUrlEncodedContent(formVars);
            HttpContent content = null;
            content.Headers.Add("string1", "string1");

            System.Net.Http.Headers.HttpResponseHeaders header = null;
            header.Add("string1", "string1");

            response.Content = content;
            response.Headers.Add("string1", "string1");
            response.IsSuccessStatusCode.Equals(true);
            response.ReasonPhrase.Equals("string1");
            response.RequestMessage.Content.Headers.Add("string1", "string1");
            response.StatusCode.Equals(null);
            response.Version.Major.Equals(1);

            SharedAccessSignatureController target = new SharedAccessSignatureController(); // TODO: Initialize to an appropriate value
            HttpResponseMessage expected = response; // TODO: Initialize to an appropriate value
            HttpResponseMessage actual;
            actual = target.Get();
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
