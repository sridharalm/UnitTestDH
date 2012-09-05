using DataHub.CloudService.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace TestDataHub
{
       
    /// <summary>
    ///This is a test class for AccountControllerTest and is intended
    ///to contain all AccountControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountControllerTest
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
        ///A test for LoginResponse
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void LoginResponseTest()
        {
            AccountController target = new AccountController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            expected.Equals(true);

            ActionResult actual;
            actual = target.LoginResponse();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogOff
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void LogOffTest()
        {
            AccountController target = new AccountController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.LogOff();
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LoginError
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void LoginErrorTest()
        {
            AccountController target = new AccountController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.LoginError();
            Assert.AreEqual(expected, actual);
          //  Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CheckIfTenantExist
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        [DeploymentItem("DataHub.CloudService.Web.dll")]
        public void CheckIfTenantExistTest()
        {
            AccountController_Accessor target = new AccountController_Accessor(); // TODO: Initialize to an appropriate value
            string provider = string.Empty; // TODO: Initialize to an appropriate value
            string authorizationId = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value

            provider = "Facebook-394677297264828";
            authorizationId="1463015163";
            expected = "";

            string actual;
            actual = target.CheckIfTenantExist(provider, authorizationId);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
