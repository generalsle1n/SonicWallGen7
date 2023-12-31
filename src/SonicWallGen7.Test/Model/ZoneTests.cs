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
    ///  Class for testing Zone
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ZoneTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Zone
        //private Zone instance;

        public ZoneTests()
        {
            // TODO uncomment below to create an instance of Zone
            //instance = new Zone();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Zone
        /// </summary>
        [Fact]
        public void ZoneInstanceTest()
        {
            // TODO uncomment below to test "IsType" Zone
            //Assert.IsType<Zone>(instance);
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
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

        /// <summary>
        /// Test the property 'SecurityType'
        /// </summary>
        [Fact]
        public void SecurityTypeTest()
        {
            // TODO unit test for the property 'SecurityType'
        }

        /// <summary>
        /// Test the property 'InterfaceTrust'
        /// </summary>
        [Fact]
        public void InterfaceTrustTest()
        {
            // TODO unit test for the property 'InterfaceTrust'
        }

        /// <summary>
        /// Test the property 'AutoGenerateAccessRules'
        /// </summary>
        [Fact]
        public void AutoGenerateAccessRulesTest()
        {
            // TODO unit test for the property 'AutoGenerateAccessRules'
        }

        /// <summary>
        /// Test the property 'WebsenseContentFiltering'
        /// </summary>
        [Fact]
        public void WebsenseContentFilteringTest()
        {
            // TODO unit test for the property 'WebsenseContentFiltering'
        }

        /// <summary>
        /// Test the property 'GatewayAntiVirus'
        /// </summary>
        [Fact]
        public void GatewayAntiVirusTest()
        {
            // TODO unit test for the property 'GatewayAntiVirus'
        }

        /// <summary>
        /// Test the property 'IntrusionPrevention'
        /// </summary>
        [Fact]
        public void IntrusionPreventionTest()
        {
            // TODO unit test for the property 'IntrusionPrevention'
        }

        /// <summary>
        /// Test the property 'AppControl'
        /// </summary>
        [Fact]
        public void AppControlTest()
        {
            // TODO unit test for the property 'AppControl'
        }

        /// <summary>
        /// Test the property 'AntiSpyware'
        /// </summary>
        [Fact]
        public void AntiSpywareTest()
        {
            // TODO unit test for the property 'AntiSpyware'
        }

        /// <summary>
        /// Test the property 'CreateGroupVpn'
        /// </summary>
        [Fact]
        public void CreateGroupVpnTest()
        {
            // TODO unit test for the property 'CreateGroupVpn'
        }

        /// <summary>
        /// Test the property 'SslControl'
        /// </summary>
        [Fact]
        public void SslControlTest()
        {
            // TODO unit test for the property 'SslControl'
        }

        /// <summary>
        /// Test the property 'SslvpnAccess'
        /// </summary>
        [Fact]
        public void SslvpnAccessTest()
        {
            // TODO unit test for the property 'SslvpnAccess'
        }

        /// <summary>
        /// Test the property 'DpiSslClient'
        /// </summary>
        [Fact]
        public void DpiSslClientTest()
        {
            // TODO unit test for the property 'DpiSslClient'
        }

        /// <summary>
        /// Test the property 'DpiSslServer'
        /// </summary>
        [Fact]
        public void DpiSslServerTest()
        {
            // TODO unit test for the property 'DpiSslServer'
        }

        /// <summary>
        /// Test the property 'GuestServices'
        /// </summary>
        [Fact]
        public void GuestServicesTest()
        {
            // TODO unit test for the property 'GuestServices'
        }
    }
}
