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
    ///  Class for testing ZoneGuestServicesExternalAuth
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ZoneGuestServicesExternalAuthTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ZoneGuestServicesExternalAuth
        //private ZoneGuestServicesExternalAuth instance;

        public ZoneGuestServicesExternalAuthTests()
        {
            // TODO uncomment below to create an instance of ZoneGuestServicesExternalAuth
            //instance = new ZoneGuestServicesExternalAuth();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZoneGuestServicesExternalAuth
        /// </summary>
        [Fact]
        public void ZoneGuestServicesExternalAuthInstanceTest()
        {
            // TODO uncomment below to test "IsType" ZoneGuestServicesExternalAuth
            //Assert.IsType<ZoneGuestServicesExternalAuth>(instance);
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
        /// Test the property 'ClientRedirect'
        /// </summary>
        [Fact]
        public void ClientRedirectTest()
        {
            // TODO unit test for the property 'ClientRedirect'
        }

        /// <summary>
        /// Test the property 'WebServer1'
        /// </summary>
        [Fact]
        public void WebServer1Test()
        {
            // TODO unit test for the property 'WebServer1'
        }

        /// <summary>
        /// Test the property 'WebServer2'
        /// </summary>
        [Fact]
        public void WebServer2Test()
        {
            // TODO unit test for the property 'WebServer2'
        }

        /// <summary>
        /// Test the property 'WebServer'
        /// </summary>
        [Fact]
        public void WebServerTest()
        {
            // TODO unit test for the property 'WebServer'
        }

        /// <summary>
        /// Test the property 'MessageAuth'
        /// </summary>
        [Fact]
        public void MessageAuthTest()
        {
            // TODO unit test for the property 'MessageAuth'
        }

        /// <summary>
        /// Test the property 'SocialNetwork'
        /// </summary>
        [Fact]
        public void SocialNetworkTest()
        {
            // TODO unit test for the property 'SocialNetwork'
        }

        /// <summary>
        /// Test the property 'AuthPages'
        /// </summary>
        [Fact]
        public void AuthPagesTest()
        {
            // TODO unit test for the property 'AuthPages'
        }

        /// <summary>
        /// Test the property 'WebContent'
        /// </summary>
        [Fact]
        public void WebContentTest()
        {
            // TODO unit test for the property 'WebContent'
        }

        /// <summary>
        /// Test the property 'LogoutExpired'
        /// </summary>
        [Fact]
        public void LogoutExpiredTest()
        {
            // TODO unit test for the property 'LogoutExpired'
        }

        /// <summary>
        /// Test the property 'StatusCheck'
        /// </summary>
        [Fact]
        public void StatusCheckTest()
        {
            // TODO unit test for the property 'StatusCheck'
        }

        /// <summary>
        /// Test the property 'SessionSync'
        /// </summary>
        [Fact]
        public void SessionSyncTest()
        {
            // TODO unit test for the property 'SessionSync'
        }
    }
}
