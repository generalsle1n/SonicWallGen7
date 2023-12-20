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
    ///  Class for testing AdministrationGmsManagementIpsecTunnelIpsecTunnel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdministrationGmsManagementIpsecTunnelIpsecTunnelTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdministrationGmsManagementIpsecTunnelIpsecTunnel
        //private AdministrationGmsManagementIpsecTunnelIpsecTunnel instance;

        public AdministrationGmsManagementIpsecTunnelIpsecTunnelTests()
        {
            // TODO uncomment below to create an instance of AdministrationGmsManagementIpsecTunnelIpsecTunnel
            //instance = new AdministrationGmsManagementIpsecTunnelIpsecTunnel();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdministrationGmsManagementIpsecTunnelIpsecTunnel
        /// </summary>
        [Fact]
        public void AdministrationGmsManagementIpsecTunnelIpsecTunnelInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdministrationGmsManagementIpsecTunnelIpsecTunnel
            //Assert.IsType<AdministrationGmsManagementIpsecTunnelIpsecTunnel>(instance);
        }

        /// <summary>
        /// Test the property 'HostName'
        /// </summary>
        [Fact]
        public void HostNameTest()
        {
            // TODO unit test for the property 'HostName'
        }

        /// <summary>
        /// Test the property 'SyslogServerPort'
        /// </summary>
        [Fact]
        public void SyslogServerPortTest()
        {
            // TODO unit test for the property 'SyslogServerPort'
        }

        /// <summary>
        /// Test the property 'HeartbeatStatusOnly'
        /// </summary>
        [Fact]
        public void HeartbeatStatusOnlyTest()
        {
            // TODO unit test for the property 'HeartbeatStatusOnly'
        }

        /// <summary>
        /// Test the property 'BehindNatDevice'
        /// </summary>
        [Fact]
        public void BehindNatDeviceTest()
        {
            // TODO unit test for the property 'BehindNatDevice'
        }

        /// <summary>
        /// Test the property 'Spi'
        /// </summary>
        [Fact]
        public void SpiTest()
        {
            // TODO unit test for the property 'Spi'
        }

        /// <summary>
        /// Test the property 'EncryptionType'
        /// </summary>
        [Fact]
        public void EncryptionTypeTest()
        {
            // TODO unit test for the property 'EncryptionType'
        }

        /// <summary>
        /// Test the property 'EncryptionKey'
        /// </summary>
        [Fact]
        public void EncryptionKeyTest()
        {
            // TODO unit test for the property 'EncryptionKey'
        }

        /// <summary>
        /// Test the property 'AuthenticationKey'
        /// </summary>
        [Fact]
        public void AuthenticationKeyTest()
        {
            // TODO unit test for the property 'AuthenticationKey'
        }
    }
}
