using DataHub.Notification.Gateway;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace TestDataHub
{
    /// <summary>
    ///This is a test class for GatewayFactoryTest and is intended
    ///to contain all GatewayFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GatewayFactoryTest
    {
        /// <summary>
        ///A test for GetGateway
        ///</summary>
        [TestMethod()]
        public void GetGatewayTest()
        {
            GatewayFactory_Accessor target = new GatewayFactory_Accessor(); // TODO: Initialize to an appropriate value
            string gatewayCode = string.Empty; // TODO: Initialize to an appropriate value
            INotificationGateway expected = null; // TODO: Initialize to an appropriate value

            gatewayCode = "001";
            expected.Attachments.Add(null);
            expected.Bcc = "manjuse@gmail.com";
            expected.Body = "message";
            expected.BodyContentPath = "path";
            expected.CC = "manjuse@gmail.com";
            expected.Subject = "message";
            expected.To = "manjuse@gmail.com";

            INotificationGateway actual;
            actual = target.GetGateway(gatewayCode);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
