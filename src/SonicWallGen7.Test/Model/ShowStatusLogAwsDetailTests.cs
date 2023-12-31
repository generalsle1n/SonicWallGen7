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
    ///  Class for testing ShowStatusLogAwsDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusLogAwsDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusLogAwsDetail
        //private ShowStatusLogAwsDetail instance;

        public ShowStatusLogAwsDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusLogAwsDetail
            //instance = new ShowStatusLogAwsDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusLogAwsDetail
        /// </summary>
        [Fact]
        public void ShowStatusLogAwsDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusLogAwsDetail
            //Assert.IsType<ShowStatusLogAwsDetail>(instance);
        }

        /// <summary>
        /// Test the property 'LogEnabled'
        /// </summary>
        [Fact]
        public void LogEnabledTest()
        {
            // TODO unit test for the property 'LogEnabled'
        }

        /// <summary>
        /// Test the property 'LogEnabledConfig'
        /// </summary>
        [Fact]
        public void LogEnabledConfigTest()
        {
            // TODO unit test for the property 'LogEnabledConfig'
        }

        /// <summary>
        /// Test the property 'LogSyncInProgress'
        /// </summary>
        [Fact]
        public void LogSyncInProgressTest()
        {
            // TODO unit test for the property 'LogSyncInProgress'
        }

        /// <summary>
        /// Test the property 'LogPushStatus'
        /// </summary>
        [Fact]
        public void LogPushStatusTest()
        {
            // TODO unit test for the property 'LogPushStatus'
        }

        /// <summary>
        /// Test the property 'LogPushRequests'
        /// </summary>
        [Fact]
        public void LogPushRequestsTest()
        {
            // TODO unit test for the property 'LogPushRequests'
        }

        /// <summary>
        /// Test the property 'LogMessagesSent'
        /// </summary>
        [Fact]
        public void LogMessagesSentTest()
        {
            // TODO unit test for the property 'LogMessagesSent'
        }

        /// <summary>
        /// Test the property 'LogPushBytesSent'
        /// </summary>
        [Fact]
        public void LogPushBytesSentTest()
        {
            // TODO unit test for the property 'LogPushBytesSent'
        }

        /// <summary>
        /// Test the property 'LogPushConnectionFailed'
        /// </summary>
        [Fact]
        public void LogPushConnectionFailedTest()
        {
            // TODO unit test for the property 'LogPushConnectionFailed'
        }
    }
}
