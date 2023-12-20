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
    ///  Class for testing AppflowServerAppflowAppflowServerServerIp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppflowServerAppflowAppflowServerServerIpTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppflowServerAppflowAppflowServerServerIp
        //private AppflowServerAppflowAppflowServerServerIp instance;

        public AppflowServerAppflowAppflowServerServerIpTests()
        {
            // TODO uncomment below to create an instance of AppflowServerAppflowAppflowServerServerIp
            //instance = new AppflowServerAppflowAppflowServerServerIp();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppflowServerAppflowAppflowServerServerIp
        /// </summary>
        [Fact]
        public void AppflowServerAppflowAppflowServerServerIpInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppflowServerAppflowAppflowServerServerIp
            //Assert.IsType<AppflowServerAppflowAppflowServerServerIp>(instance);
        }

        /// <summary>
        /// Test the property 'Server'
        /// </summary>
        [Fact]
        public void ServerTest()
        {
            // TODO unit test for the property 'Server'
        }

        /// <summary>
        /// Test the property 'VpnSourceIp'
        /// </summary>
        [Fact]
        public void VpnSourceIpTest()
        {
            // TODO unit test for the property 'VpnSourceIp'
        }

        /// <summary>
        /// Test the property 'MaxFlows'
        /// </summary>
        [Fact]
        public void MaxFlowsTest()
        {
            // TODO unit test for the property 'MaxFlows'
        }

        /// <summary>
        /// Test the property 'CommunicationTimeout'
        /// </summary>
        [Fact]
        public void CommunicationTimeoutTest()
        {
            // TODO unit test for the property 'CommunicationTimeout'
        }

        /// <summary>
        /// Test the property 'FirewallName'
        /// </summary>
        [Fact]
        public void FirewallNameTest()
        {
            // TODO unit test for the property 'FirewallName'
        }

        /// <summary>
        /// Test the property 'Passphrase'
        /// </summary>
        [Fact]
        public void PassphraseTest()
        {
            // TODO unit test for the property 'Passphrase'
        }
    }
}