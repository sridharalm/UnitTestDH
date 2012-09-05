using DataHub.CloudService.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using DataHub.CloudService.Web.Models;
using System.Collections.Generic;

namespace TestDataHub
{
    
    
    /// <summary>
    ///This is a test class for DashboardControllerTest and is intended
    ///to contain all DashboardControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DashboardControllerTest
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
        ///A test for GetFiles
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void GetFilesTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            tenantId = "C428C08B-A863-4814-A250-58F7421F5FF0";
            int pageNumber = 1; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.GetFiles(tenantId, pageNumber);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetUploadedFilesDetails
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void GetUploadedFilesDetailsTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            tenantId = "C428C08B-A863-4814-A250-58F7421F5FF0";
            int pageNumber = 1; // TODO: Initialize to an appropriate value
            int recordsPerPage = 1; // TODO: Initialize to an appropriate value
            List<FileDetails> expected = null; // TODO: Initialize to an appropriate value
            List<FileDetails> actual;
            actual = target.GetUploadedFilesDetails(tenantId, pageNumber, recordsPerPage);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DownloadFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void DownloadFileTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            string fileId = string.Empty; // TODO: Initialize to an appropriate value
            string fileName = string.Empty; // TODO: Initialize to an appropriate value

            fileName = "DataHub.WindowsService.vshost.exe";
            tenantId =  "C428C08B-A863-4814-A250-58F7421F5FF0";
            fileId = "F15BF469-1D9C-49FE-AE18-638D7BAFF053";

            target.DownloadFile(tenantId, fileId, fileName);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetAllMetadata
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void GetAllMetadataTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string tenantID = string.Empty; // TODO: Initialize to an appropriate value
            List<FileMetadata> expected = null; // TODO: Initialize to an appropriate value
            List<FileMetadata> actual;
            actual = target.GetAllMetadata(tenantID);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFileMetaData
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void GetFileMetaDataTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string fileId = string.Empty; // TODO: Initialize to an appropriate value
            FileMetadata expected = null; // TODO: Initialize to an appropriate value
            FileMetadata actual;
            actual = target.GetFileMetaData(fileId);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for SearchFile
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\ALM\\DataHub2\\src\\DataHub.CloudService.Web", "/")]
        [UrlToTest("http://localhost:62369/")]
        public void SearchFileTest()
        {
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string searchText = string.Empty; // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.SearchFile(searchText, tenantId);
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
            DashboardController target = new DashboardController(); // TODO: Initialize to an appropriate value
            string tenantId = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index(tenantId);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

    }
}
