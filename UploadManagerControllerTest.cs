using DataHub.CloudService.Web.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Net.Http;

namespace TestDataHub
{

    /// <summary>
    ///This is a test class for UploadManagerControllerTest and is intended
    ///to contain all UploadManagerControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UploadManagerControllerTest
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


        /// <summary>
        ///A test for PostFileStatus
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void PostFileStatusTest()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            HttpContent content = null;
            content.Headers.Add("string1", "string1");

            System.Net.Http.Headers.HttpResponseHeaders header = null;
            header.Add("string1", "string1");

            response.Content = content;
            response.Headers.Add("string1", "string1");
            response.IsSuccessStatusCode.Equals(true);
            response.ReasonPhrase.Equals("string1");
            response.RequestMessage.Content.Headers.Add("string1", "string1");
            response.StatusCode.Equals("Success");
            response.Version.Major.Equals(1);

            UploadManagerController target = new UploadManagerController(); // TODO: Initialize to an appropriate value
            HttpResponseMessage expected = null; // TODO: Initialize to an appropriate value
            HttpResponseMessage actual;
            actual = target.PostFileStatus();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
