using DataHub.Eventing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataHub.BackgroundService.Models;

namespace TestDataHub
{
    /// <summary>
    ///This is a test class for ProcessFileUploadStatusQueueTest and is intended
    ///to contain all ProcessFileUploadStatusQueueTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcessFileUploadStatusQueueTest
    {
        /// <summary>
        ///A test for StatusMessageProcessing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DataHub.Eventing.dll")]
        public void StatusMessageProcessingTest()
        {
            ProcessFileUploadStatusQueue_Accessor target = new ProcessFileUploadStatusQueue_Accessor(); // TODO: Initialize to an appropriate value
            string tenantID = string.Empty; // TODO: Initialize to an appropriate value
            string fileID = string.Empty; // TODO: Initialize to an appropriate value
            string fileUploadStatus = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;

            tenantID = "C428C08B-A863-4814-A250-58F7421F5FF0";
            fileID = "F15BF469-1D9C-49FE-AE18-638D7BAFF053";
            fileUploadStatus = "Success";

            actual = target.StatusMessageProcessing(tenantID, fileID, fileUploadStatus);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for WriteNotificationToStorage
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DataHub.Eventing.dll")]
        public void WriteNotificationToStorageTest()
        {
            ProcessFileUploadStatusQueue_Accessor target = new ProcessFileUploadStatusQueue_Accessor(); // TODO: Initialize to an appropriate value
            Tenant tenantClient = null; // TODO: Initialize to an appropriate value
            string fileID = string.Empty; // TODO: Initialize to an appropriate value
            string fileUploadStatus = string.Empty; // TODO: Initialize to an appropriate value

            fileID = "F15BF469-1D9C-49FE-AE18-638D7BAFF053";
            fileUploadStatus = "Success";

            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.WriteNotificationToStorage(tenantClient, fileID, fileUploadStatus);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
