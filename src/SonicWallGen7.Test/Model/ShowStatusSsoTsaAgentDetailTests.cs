/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SonicWallGen7.Model;
using SonicWallGen7.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SonicWallGen7.Test.Model
{
    /// <summary>
    ///  Class for testing ShowStatusSsoTsaAgentDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusSsoTsaAgentDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusSsoTsaAgentDetail
        //private ShowStatusSsoTsaAgentDetail instance;

        public ShowStatusSsoTsaAgentDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusSsoTsaAgentDetail
            //instance = new ShowStatusSsoTsaAgentDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusSsoTsaAgentDetail
        /// </summary>
        [Fact]
        public void ShowStatusSsoTsaAgentDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusSsoTsaAgentDetail
            //Assert.IsType<ShowStatusSsoTsaAgentDetail>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Port'
        /// </summary>
        [Fact]
        public void PortTest()
        {
            // TODO unit test for the property 'Port'
        }

        /// <summary>
        /// Test the property 'IpAddress'
        /// </summary>
        [Fact]
        public void IpAddressTest()
        {
            // TODO unit test for the property 'IpAddress'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'MessagesReceivedFromAgent'
        /// </summary>
        [Fact]
        public void MessagesReceivedFromAgentTest()
        {
            // TODO unit test for the property 'MessagesReceivedFromAgent'
        }

        /// <summary>
        /// Test the property 'OpenNotificationsReceived'
        /// </summary>
        [Fact]
        public void OpenNotificationsReceivedTest()
        {
            // TODO unit test for the property 'OpenNotificationsReceived'
        }

        /// <summary>
        /// Test the property 'CloseNotificationsReceived'
        /// </summary>
        [Fact]
        public void CloseNotificationsReceivedTest()
        {
            // TODO unit test for the property 'CloseNotificationsReceived'
        }

        /// <summary>
        /// Test the property 'BadMessagesReceived'
        /// </summary>
        [Fact]
        public void BadMessagesReceivedTest()
        {
            // TODO unit test for the property 'BadMessagesReceived'
        }

        /// <summary>
        /// Test the property 'ConnectionsReceivedNeedingIdentification'
        /// </summary>
        [Fact]
        public void ConnectionsReceivedNeedingIdentificationTest()
        {
            // TODO unit test for the property 'ConnectionsReceivedNeedingIdentification'
        }

        /// <summary>
        /// Test the property 'ConnectionsReturnedNewUser'
        /// </summary>
        [Fact]
        public void ConnectionsReturnedNewUserTest()
        {
            // TODO unit test for the property 'ConnectionsReturnedNewUser'
        }

        /// <summary>
        /// Test the property 'ConnectionsReturnedExistingUser'
        /// </summary>
        [Fact]
        public void ConnectionsReturnedExistingUserTest()
        {
            // TODO unit test for the property 'ConnectionsReturnedExistingUser'
        }

        /// <summary>
        /// Test the property 'TimedOutConnections'
        /// </summary>
        [Fact]
        public void TimedOutConnectionsTest()
        {
            // TODO unit test for the property 'TimedOutConnections'
        }

        /// <summary>
        /// Test the property 'ConnectionsWithErrorNotification'
        /// </summary>
        [Fact]
        public void ConnectionsWithErrorNotificationTest()
        {
            // TODO unit test for the property 'ConnectionsWithErrorNotification'
        }

        /// <summary>
        /// Test the property 'ConnectionsWithCloseWithNoOpen'
        /// </summary>
        [Fact]
        public void ConnectionsWithCloseWithNoOpenTest()
        {
            // TODO unit test for the property 'ConnectionsWithCloseWithNoOpen'
        }

        /// <summary>
        /// Test the property 'DiscardedRepeatedAttempts'
        /// </summary>
        [Fact]
        public void DiscardedRepeatedAttemptsTest()
        {
            // TODO unit test for the property 'DiscardedRepeatedAttempts'
        }

        /// <summary>
        /// Test the property 'SuccessesWithNoWaitForAgent'
        /// </summary>
        [Fact]
        public void SuccessesWithNoWaitForAgentTest()
        {
            // TODO unit test for the property 'SuccessesWithNoWaitForAgent'
        }
    }
}
