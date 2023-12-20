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
    ///  Class for testing SslVpnServerSslVpnServer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SslVpnServerSslVpnServerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SslVpnServerSslVpnServer
        //private SslVpnServerSslVpnServer instance;

        public SslVpnServerSslVpnServerTests()
        {
            // TODO uncomment below to create an instance of SslVpnServerSslVpnServer
            //instance = new SslVpnServerSslVpnServer();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SslVpnServerSslVpnServer
        /// </summary>
        [Fact]
        public void SslVpnServerSslVpnServerInstanceTest()
        {
            // TODO uncomment below to test "IsType" SslVpnServerSslVpnServer
            //Assert.IsType<SslVpnServerSslVpnServer>(instance);
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
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }

        /// <summary>
        /// Test the property 'UseRadius'
        /// </summary>
        [Fact]
        public void UseRadiusTest()
        {
            // TODO unit test for the property 'UseRadius'
        }

        /// <summary>
        /// Test the property 'UserDomain'
        /// </summary>
        [Fact]
        public void UserDomainTest()
        {
            // TODO unit test for the property 'UserDomain'
        }

        /// <summary>
        /// Test the property 'Management'
        /// </summary>
        [Fact]
        public void ManagementTest()
        {
            // TODO unit test for the property 'Management'
        }

        /// <summary>
        /// Test the property 'Ccp'
        /// </summary>
        [Fact]
        public void CcpTest()
        {
            // TODO unit test for the property 'Ccp'
        }

        /// <summary>
        /// Test the property 'SessionTimeout'
        /// </summary>
        [Fact]
        public void SessionTimeoutTest()
        {
            // TODO unit test for the property 'SessionTimeout'
        }

        /// <summary>
        /// Test the property 'InactivityCheck'
        /// </summary>
        [Fact]
        public void InactivityCheckTest()
        {
            // TODO unit test for the property 'InactivityCheck'
        }

        /// <summary>
        /// Test the property 'AutoRule'
        /// </summary>
        [Fact]
        public void AutoRuleTest()
        {
            // TODO unit test for the property 'AutoRule'
        }

        /// <summary>
        /// Test the property 'DownloadUrl'
        /// </summary>
        [Fact]
        public void DownloadUrlTest()
        {
            // TODO unit test for the property 'DownloadUrl'
        }
    }
}