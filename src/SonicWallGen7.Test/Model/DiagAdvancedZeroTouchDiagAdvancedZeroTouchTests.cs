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
    ///  Class for testing DiagAdvancedZeroTouchDiagAdvancedZeroTouch
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedZeroTouchDiagAdvancedZeroTouchTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedZeroTouchDiagAdvancedZeroTouch
        //private DiagAdvancedZeroTouchDiagAdvancedZeroTouch instance;

        public DiagAdvancedZeroTouchDiagAdvancedZeroTouchTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedZeroTouchDiagAdvancedZeroTouch
            //instance = new DiagAdvancedZeroTouchDiagAdvancedZeroTouch();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedZeroTouchDiagAdvancedZeroTouch
        /// </summary>
        [Fact]
        public void DiagAdvancedZeroTouchDiagAdvancedZeroTouchInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedZeroTouchDiagAdvancedZeroTouch
            //Assert.IsType<DiagAdvancedZeroTouchDiagAdvancedZeroTouch>(instance);
        }

        /// <summary>
        /// Test the property 'FqSonicDnserver'
        /// </summary>
        [Fact]
        public void FqSonicDnserverTest()
        {
            // TODO unit test for the property 'FqSonicDnserver'
        }

        /// <summary>
        /// Test the property 'ServerIpUseMode'
        /// </summary>
        [Fact]
        public void ServerIpUseModeTest()
        {
            // TODO unit test for the property 'ServerIpUseMode'
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
        /// Test the property 'ReconnectingDelay'
        /// </summary>
        [Fact]
        public void ReconnectingDelayTest()
        {
            // TODO unit test for the property 'ReconnectingDelay'
        }

        /// <summary>
        /// Test the property 'ReconnectingAttempt'
        /// </summary>
        [Fact]
        public void ReconnectingAttemptTest()
        {
            // TODO unit test for the property 'ReconnectingAttempt'
        }

        /// <summary>
        /// Test the property 'SkipCertificate'
        /// </summary>
        [Fact]
        public void SkipCertificateTest()
        {
            // TODO unit test for the property 'SkipCertificate'
        }

        /// <summary>
        /// Test the property 'ShowDiagnosticPage'
        /// </summary>
        [Fact]
        public void ShowDiagnosticPageTest()
        {
            // TODO unit test for the property 'ShowDiagnosticPage'
        }

        /// <summary>
        /// Test the property 'DebugLevel'
        /// </summary>
        [Fact]
        public void DebugLevelTest()
        {
            // TODO unit test for the property 'DebugLevel'
        }
    }
}
