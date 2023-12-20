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
    ///  Class for testing ShowStatusRadiusAcctClientListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusRadiusAcctClientListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusRadiusAcctClientListInner
        //private ShowStatusRadiusAcctClientListInner instance;

        public ShowStatusRadiusAcctClientListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusRadiusAcctClientListInner
            //instance = new ShowStatusRadiusAcctClientListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusRadiusAcctClientListInner
        /// </summary>
        [Fact]
        public void ShowStatusRadiusAcctClientListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusRadiusAcctClientListInner
            //Assert.IsType<ShowStatusRadiusAcctClientListInner>(instance);
        }

        /// <summary>
        /// Test the property 'VarClient'
        /// </summary>
        [Fact]
        public void VarClientTest()
        {
            // TODO unit test for the property 'VarClient'
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
        /// Test the property 'TimeIdleSeconds'
        /// </summary>
        [Fact]
        public void TimeIdleSecondsTest()
        {
            // TODO unit test for the property 'TimeIdleSeconds'
        }

        /// <summary>
        /// Test the property 'TotalAccountingRequests'
        /// </summary>
        [Fact]
        public void TotalAccountingRequestsTest()
        {
            // TODO unit test for the property 'TotalAccountingRequests'
        }

        /// <summary>
        /// Test the property 'GoodAccountingRequests'
        /// </summary>
        [Fact]
        public void GoodAccountingRequestsTest()
        {
            // TODO unit test for the property 'GoodAccountingRequests'
        }

        /// <summary>
        /// Test the property 'BadAccountingRequests'
        /// </summary>
        [Fact]
        public void BadAccountingRequestsTest()
        {
            // TODO unit test for the property 'BadAccountingRequests'
        }

        /// <summary>
        /// Test the property 'NonAccountingRequestsReceivedDropped'
        /// </summary>
        [Fact]
        public void NonAccountingRequestsReceivedDroppedTest()
        {
            // TODO unit test for the property 'NonAccountingRequestsReceivedDropped'
        }

        /// <summary>
        /// Test the property 'StartUserRequestsRcvd'
        /// </summary>
        [Fact]
        public void StartUserRequestsRcvdTest()
        {
            // TODO unit test for the property 'StartUserRequestsRcvd'
        }

        /// <summary>
        /// Test the property 'StopUserRequestsReceived'
        /// </summary>
        [Fact]
        public void StopUserRequestsReceivedTest()
        {
            // TODO unit test for the property 'StopUserRequestsReceived'
        }

        /// <summary>
        /// Test the property 'ProxyForwardingRequestsSent'
        /// </summary>
        [Fact]
        public void ProxyForwardingRequestsSentTest()
        {
            // TODO unit test for the property 'ProxyForwardingRequestsSent'
        }

        /// <summary>
        /// Test the property 'ProxyForwardingRequestsResponsesRcvd'
        /// </summary>
        [Fact]
        public void ProxyForwardingRequestsResponsesRcvdTest()
        {
            // TODO unit test for the property 'ProxyForwardingRequestsResponsesRcvd'
        }

        /// <summary>
        /// Test the property 'ProxyForwardingResponseErrors'
        /// </summary>
        [Fact]
        public void ProxyForwardingResponseErrorsTest()
        {
            // TODO unit test for the property 'ProxyForwardingResponseErrors'
        }

        /// <summary>
        /// Test the property 'ProxyForwardingResponseTimeouts'
        /// </summary>
        [Fact]
        public void ProxyForwardingResponseTimeoutsTest()
        {
            // TODO unit test for the property 'ProxyForwardingResponseTimeouts'
        }

        /// <summary>
        /// Test the property 'ResponseTimeToProxyForwardedRqstAvg'
        /// </summary>
        [Fact]
        public void ResponseTimeToProxyForwardedRqstAvgTest()
        {
            // TODO unit test for the property 'ResponseTimeToProxyForwardedRqstAvg'
        }

        /// <summary>
        /// Test the property 'ResponseTimeToProxyForwardedRqstMax'
        /// </summary>
        [Fact]
        public void ResponseTimeToProxyForwardedRqstMaxTest()
        {
            // TODO unit test for the property 'ResponseTimeToProxyForwardedRqstMax'
        }

        /// <summary>
        /// Test the property 'StartUserRequestsRepeats'
        /// </summary>
        [Fact]
        public void StartUserRequestsRepeatsTest()
        {
            // TODO unit test for the property 'StartUserRequestsRepeats'
        }

        /// <summary>
        /// Test the property 'StartUserRequestsErrors'
        /// </summary>
        [Fact]
        public void StartUserRequestsErrorsTest()
        {
            // TODO unit test for the property 'StartUserRequestsErrors'
        }

        /// <summary>
        /// Test the property 'StopUserRequestsErrors'
        /// </summary>
        [Fact]
        public void StopUserRequestsErrorsTest()
        {
            // TODO unit test for the property 'StopUserRequestsErrors'
        }

        /// <summary>
        /// Test the property 'SuccessfulUserLogins'
        /// </summary>
        [Fact]
        public void SuccessfulUserLoginsTest()
        {
            // TODO unit test for the property 'SuccessfulUserLogins'
        }

        /// <summary>
        /// Test the property 'FailedUserLogins'
        /// </summary>
        [Fact]
        public void FailedUserLoginsTest()
        {
            // TODO unit test for the property 'FailedUserLogins'
        }

        /// <summary>
        /// Test the property 'UserLogouts'
        /// </summary>
        [Fact]
        public void UserLogoutsTest()
        {
            // TODO unit test for the property 'UserLogouts'
        }

        /// <summary>
        /// Test the property 'UserNotFoundErrorsWithStopUser'
        /// </summary>
        [Fact]
        public void UserNotFoundErrorsWithStopUserTest()
        {
            // TODO unit test for the property 'UserNotFoundErrorsWithStopUser'
        }
    }
}