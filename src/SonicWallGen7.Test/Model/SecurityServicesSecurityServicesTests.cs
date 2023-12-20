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
    ///  Class for testing SecurityServicesSecurityServices
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SecurityServicesSecurityServicesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecurityServicesSecurityServices
        //private SecurityServicesSecurityServices instance;

        public SecurityServicesSecurityServicesTests()
        {
            // TODO uncomment below to create an instance of SecurityServicesSecurityServices
            //instance = new SecurityServicesSecurityServices();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityServicesSecurityServices
        /// </summary>
        [Fact]
        public void SecurityServicesSecurityServicesInstanceTest()
        {
            // TODO uncomment below to test "IsType" SecurityServicesSecurityServices
            //Assert.IsType<SecurityServicesSecurityServices>(instance);
        }

        /// <summary>
        /// Test the property 'Security'
        /// </summary>
        [Fact]
        public void SecurityTest()
        {
            // TODO unit test for the property 'Security'
        }

        /// <summary>
        /// Test the property 'ReduceIsdnAntivirusTraffic'
        /// </summary>
        [Fact]
        public void ReduceIsdnAntivirusTrafficTest()
        {
            // TODO unit test for the property 'ReduceIsdnAntivirusTraffic'
        }

        /// <summary>
        /// Test the property 'DropPacketsAtReload'
        /// </summary>
        [Fact]
        public void DropPacketsAtReloadTest()
        {
            // TODO unit test for the property 'DropPacketsAtReload'
        }

        /// <summary>
        /// Test the property 'HttpClientlessNotificationTimeout'
        /// </summary>
        [Fact]
        public void HttpClientlessNotificationTimeoutTest()
        {
            // TODO unit test for the property 'HttpClientlessNotificationTimeout'
        }

        /// <summary>
        /// Test the property 'ProxyServer'
        /// </summary>
        [Fact]
        public void ProxyServerTest()
        {
            // TODO unit test for the property 'ProxyServer'
        }
    }
}