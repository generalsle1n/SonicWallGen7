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
    ///  Class for testing DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
        //private DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication instance;

        public DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
            //instance = new DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
        /// </summary>
        [Fact]
        public void DiagAdvancedUserAuthenticationDiagAdvancedUserAuthenticationInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication
            //Assert.IsType<DiagAdvancedUserAuthenticationDiagAdvancedUserAuthentication>(instance);
        }

        /// <summary>
        /// Test the property 'PostAuthenticationRedirectUrl'
        /// </summary>
        [Fact]
        public void PostAuthenticationRedirectUrlTest()
        {
            // TODO unit test for the property 'PostAuthenticationRedirectUrl'
        }

        /// <summary>
        /// Test the property 'LogAllSsoAttempts'
        /// </summary>
        [Fact]
        public void LogAllSsoAttemptsTest()
        {
            // TODO unit test for the property 'LogAllSsoAttempts'
        }

        /// <summary>
        /// Test the property 'UserIp'
        /// </summary>
        [Fact]
        public void UserIpTest()
        {
            // TODO unit test for the property 'UserIp'
        }

        /// <summary>
        /// Test the property 'IncludeSsoBypass'
        /// </summary>
        [Fact]
        public void IncludeSsoBypassTest()
        {
            // TODO unit test for the property 'IncludeSsoBypass'
        }

        /// <summary>
        /// Test the property 'IncludeSsoPolling'
        /// </summary>
        [Fact]
        public void IncludeSsoPollingTest()
        {
            // TODO unit test for the property 'IncludeSsoPolling'
        }

        /// <summary>
        /// Test the property 'IncludeAdditionalNonInitiation'
        /// </summary>
        [Fact]
        public void IncludeAdditionalNonInitiationTest()
        {
            // TODO unit test for the property 'IncludeAdditionalNonInitiation'
        }

        /// <summary>
        /// Test the property 'SsoAgentVersionNegotiation'
        /// </summary>
        [Fact]
        public void SsoAgentVersionNegotiationTest()
        {
            // TODO unit test for the property 'SsoAgentVersionNegotiation'
        }

        /// <summary>
        /// Test the property 'RedirectHttps'
        /// </summary>
        [Fact]
        public void RedirectHttpsTest()
        {
            // TODO unit test for the property 'RedirectHttps'
        }

        /// <summary>
        /// Test the property 'HttpsRedirectPort'
        /// </summary>
        [Fact]
        public void HttpsRedirectPortTest()
        {
            // TODO unit test for the property 'HttpsRedirectPort'
        }
    }
}
