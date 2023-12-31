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
    ///  Class for testing DiagAdvancedDiagnosticsDiagAdvancedDiagnostics
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedDiagnosticsDiagAdvancedDiagnosticsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedDiagnosticsDiagAdvancedDiagnostics
        //private DiagAdvancedDiagnosticsDiagAdvancedDiagnostics instance;

        public DiagAdvancedDiagnosticsDiagAdvancedDiagnosticsTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedDiagnosticsDiagAdvancedDiagnostics
            //instance = new DiagAdvancedDiagnosticsDiagAdvancedDiagnostics();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedDiagnosticsDiagAdvancedDiagnostics
        /// </summary>
        [Fact]
        public void DiagAdvancedDiagnosticsDiagAdvancedDiagnosticsInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedDiagnosticsDiagAdvancedDiagnostics
            //Assert.IsType<DiagAdvancedDiagnosticsDiagAdvancedDiagnostics>(instance);
        }

        /// <summary>
        /// Test the property 'TraceMessageLevel'
        /// </summary>
        [Fact]
        public void TraceMessageLevelTest()
        {
            // TODO unit test for the property 'TraceMessageLevel'
        }

        /// <summary>
        /// Test the property 'AutoRestart'
        /// </summary>
        [Fact]
        public void AutoRestartTest()
        {
            // TODO unit test for the property 'AutoRestart'
        }

        /// <summary>
        /// Test the property 'SetupToolServer'
        /// </summary>
        [Fact]
        public void SetupToolServerTest()
        {
            // TODO unit test for the property 'SetupToolServer'
        }

        /// <summary>
        /// Test the property 'ShowUserDiagnostics'
        /// </summary>
        [Fact]
        public void ShowUserDiagnosticsTest()
        {
            // TODO unit test for the property 'ShowUserDiagnostics'
        }

        /// <summary>
        /// Test the property 'WanConnectivityTest'
        /// </summary>
        [Fact]
        public void WanConnectivityTestTest()
        {
            // TODO unit test for the property 'WanConnectivityTest'
        }

        /// <summary>
        /// Test the property 'MemoryFreeCallTracking'
        /// </summary>
        [Fact]
        public void MemoryFreeCallTrackingTest()
        {
            // TODO unit test for the property 'MemoryFreeCallTracking'
        }

        /// <summary>
        /// Test the property 'LogLdapMirror'
        /// </summary>
        [Fact]
        public void LogLdapMirrorTest()
        {
            // TODO unit test for the property 'LogLdapMirror'
        }
    }
}
