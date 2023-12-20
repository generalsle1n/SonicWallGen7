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
    ///  Class for testing ShowStatusSonicDnsProxyServerListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusSonicDnsProxyServerListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusSonicDnsProxyServerListInner
        //private ShowStatusSonicDnsProxyServerListInner instance;

        public ShowStatusSonicDnsProxyServerListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusSonicDnsProxyServerListInner
            //instance = new ShowStatusSonicDnsProxyServerListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusSonicDnsProxyServerListInner
        /// </summary>
        [Fact]
        public void ShowStatusSonicDnsProxyServerListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusSonicDnsProxyServerListInner
            //Assert.IsType<ShowStatusSonicDnsProxyServerListInner>(instance);
        }

        /// <summary>
        /// Test the property 'SonicDnsServer'
        /// </summary>
        [Fact]
        public void SonicDnsServerTest()
        {
            // TODO unit test for the property 'SonicDnsServer'
        }

        /// <summary>
        /// Test the property 'ServerIp'
        /// </summary>
        [Fact]
        public void ServerIpTest()
        {
            // TODO unit test for the property 'ServerIp'
        }

        /// <summary>
        /// Test the property 'ServerStatus'
        /// </summary>
        [Fact]
        public void ServerStatusTest()
        {
            // TODO unit test for the property 'ServerStatus'
        }

        /// <summary>
        /// Test the property 'ProxiedSonicDnsPacketsSent'
        /// </summary>
        [Fact]
        public void ProxiedSonicDnsPacketsSentTest()
        {
            // TODO unit test for the property 'ProxiedSonicDnsPacketsSent'
        }

        /// <summary>
        /// Test the property 'SuccessfulSonicDnsProxy'
        /// </summary>
        [Fact]
        public void SuccessfulSonicDnsProxyTest()
        {
            // TODO unit test for the property 'SuccessfulSonicDnsProxy'
        }
    }
}
