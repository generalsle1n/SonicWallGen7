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
    ///  Class for testing MacIpAntiSpoofIpv4
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MacIpAntiSpoofIpv4Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MacIpAntiSpoofIpv4
        //private MacIpAntiSpoofIpv4 instance;

        public MacIpAntiSpoofIpv4Tests()
        {
            // TODO uncomment below to create an instance of MacIpAntiSpoofIpv4
            //instance = new MacIpAntiSpoofIpv4();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MacIpAntiSpoofIpv4
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4InstanceTest()
        {
            // TODO uncomment below to test "IsType" MacIpAntiSpoofIpv4
            //Assert.IsType<MacIpAntiSpoofIpv4>(instance);
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
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }

        /// <summary>
        /// Test the property 'StaticArp'
        /// </summary>
        [Fact]
        public void StaticArpTest()
        {
            // TODO unit test for the property 'StaticArp'
        }

        /// <summary>
        /// Test the property 'DhcpServer'
        /// </summary>
        [Fact]
        public void DhcpServerTest()
        {
            // TODO unit test for the property 'DhcpServer'
        }

        /// <summary>
        /// Test the property 'DhcpRelay'
        /// </summary>
        [Fact]
        public void DhcpRelayTest()
        {
            // TODO unit test for the property 'DhcpRelay'
        }

        /// <summary>
        /// Test the property 'ArpLock'
        /// </summary>
        [Fact]
        public void ArpLockTest()
        {
            // TODO unit test for the property 'ArpLock'
        }

        /// <summary>
        /// Test the property 'ArpWatch'
        /// </summary>
        [Fact]
        public void ArpWatchTest()
        {
            // TODO unit test for the property 'ArpWatch'
        }

        /// <summary>
        /// Test the property 'EnforceIngress'
        /// </summary>
        [Fact]
        public void EnforceIngressTest()
        {
            // TODO unit test for the property 'EnforceIngress'
        }

        /// <summary>
        /// Test the property 'SpoofDetection'
        /// </summary>
        [Fact]
        public void SpoofDetectionTest()
        {
            // TODO unit test for the property 'SpoofDetection'
        }

        /// <summary>
        /// Test the property 'AllowManagement'
        /// </summary>
        [Fact]
        public void AllowManagementTest()
        {
            // TODO unit test for the property 'AllowManagement'
        }
    }
}
