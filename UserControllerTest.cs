using DataHub.CloudService.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using DataHub.CloudService.Web.Models;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for UserControllerTest and is intended
    ///to contain all UserControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserControllerTest
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
        ///A test for CreateTenant
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void CreateTenantTest()
        {
            UserController target = new UserController(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string organization = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.CreateTenant(name, email, organization);

            name = "Manjunath SiddeGowda";
            email = "manjuse@gmail.com";
            organization = "Aditi";

            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateTenantContainer
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        [DeploymentItem("DataHub.CloudService.Web.dll")]
        public void CreateTenantContainerTest()
        {
            UserController_Accessor target = new UserController_Accessor(); // TODO: Initialize to an appropriate value
            string containerName = string.Empty; // TODO: Initialize to an appropriate value
            containerName = "Conatainer1";
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CreateTenantContainer(containerName);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateUser
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        [DeploymentItem("DataHub.CloudService.Web.dll")]
        public void CreateUserTest()
        {

            UserController_Accessor target = new UserController_Accessor(); // TODO: Initialize to an appropriate value
            Tenant model = null; // TODO: Initialize to an appropriate value
            model.AuthorizationId = "1463015163";
            model.Email = "manjuse@gmail.com";
            model.IdentityProvider = "Facebook-394677297264828";
            model.IsActive = true;
            model.Name = "Manjunath SiddeGowda";
            model.Organization = "Aditi";
            model.RegistrationDate = DateTime.Today;
            model.SecretKey = "6kcezHL10vNJc/byVDgQLnSoXeZBo4Vb2SR+6V5cFGA=";
            model.SubscriptionTypeId = 0;
            model.TenantId = Guid.NewGuid();

            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CreateUser(model);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DownloadSetup
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void DownloadSetupTest()
        {
            UserController target = new UserController(); // TODO: Initialize to an appropriate value
            target.DownloadSetup();
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


        /// <summary>
        ///A test for Downloads
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void DownloadsTest()
        {
            UserController target = new UserController(); // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            tenantId = "ECC849C3-7ECD-45BA-BBAF-8DC4F95FA4A8";

            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Downloads(tenantId);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateSecretKey
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        [DeploymentItem("DataHub.CloudService.Web.dll")]
        public void GenerateSecretKeyTest()
        {
            UserController_Accessor target = new UserController_Accessor(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value


            string actual;
            actual = target.GenerateSecretKey();
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void IndexTest()
        {
            UserController target = new UserController(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value

            email = "manjuse@gmail.com";
            name = "Manjunath SiddeGowda";
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index(name, email);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
