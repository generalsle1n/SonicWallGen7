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
    ///  Class for testing TsrOptionsTechSupportReportOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TsrOptionsTechSupportReportOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TsrOptionsTechSupportReportOptions
        //private TsrOptionsTechSupportReportOptions instance;

        public TsrOptionsTechSupportReportOptionsTests()
        {
            // TODO uncomment below to create an instance of TsrOptionsTechSupportReportOptions
            //instance = new TsrOptionsTechSupportReportOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TsrOptionsTechSupportReportOptions
        /// </summary>
        [Fact]
        public void TsrOptionsTechSupportReportOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TsrOptionsTechSupportReportOptions
            //Assert.IsType<TsrOptionsTechSupportReportOptions>(instance);
        }

        /// <summary>
        /// Test the property 'SensitiveKeys'
        /// </summary>
        [Fact]
        public void SensitiveKeysTest()
        {
            // TODO unit test for the property 'SensitiveKeys'
        }

        /// <summary>
        /// Test the property 'ArpCache'
        /// </summary>
        [Fact]
        public void ArpCacheTest()
        {
            // TODO unit test for the property 'ArpCache'
        }

        /// <summary>
        /// Test the property 'DhcpBindings'
        /// </summary>
        [Fact]
        public void DhcpBindingsTest()
        {
            // TODO unit test for the property 'DhcpBindings'
        }

        /// <summary>
        /// Test the property 'IkeInfo'
        /// </summary>
        [Fact]
        public void IkeInfoTest()
        {
            // TODO unit test for the property 'IkeInfo'
        }

        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }

        /// <summary>
        /// Test the property 'IpStackInfo'
        /// </summary>
        [Fact]
        public void IpStackInfoTest()
        {
            // TODO unit test for the property 'IpStackInfo'
        }

        /// <summary>
        /// Test the property 'SonicDnsProxyCache'
        /// </summary>
        [Fact]
        public void SonicDnsProxyCacheTest()
        {
            // TODO unit test for the property 'SonicDnsProxyCache'
        }

        /// <summary>
        /// Test the property 'DebugInfo'
        /// </summary>
        [Fact]
        public void DebugInfoTest()
        {
            // TODO unit test for the property 'DebugInfo'
        }

        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

        /// <summary>
        /// Test the property 'Ipv6'
        /// </summary>
        [Fact]
        public void Ipv6Test()
        {
            // TODO unit test for the property 'Ipv6'
        }

        /// <summary>
        /// Test the property 'GeoIpCache'
        /// </summary>
        [Fact]
        public void GeoIpCacheTest()
        {
            // TODO unit test for the property 'GeoIpCache'
        }

        /// <summary>
        /// Test the property 'ExtraRouting'
        /// </summary>
        [Fact]
        public void ExtraRoutingTest()
        {
            // TODO unit test for the property 'ExtraRouting'
        }

        /// <summary>
        /// Test the property 'AtpCache'
        /// </summary>
        [Fact]
        public void AtpCacheTest()
        {
            // TODO unit test for the property 'AtpCache'
        }

        /// <summary>
        /// Test the property 'VendorOui'
        /// </summary>
        [Fact]
        public void VendorOuiTest()
        {
            // TODO unit test for the property 'VendorOui'
        }

        /// <summary>
        /// Test the property 'IpReport'
        /// </summary>
        [Fact]
        public void IpReportTest()
        {
            // TODO unit test for the property 'IpReport'
        }

        /// <summary>
        /// Test the property 'ApplicationSignature'
        /// </summary>
        [Fact]
        public void ApplicationSignatureTest()
        {
            // TODO unit test for the property 'ApplicationSignature'
        }

        /// <summary>
        /// Test the property 'AbrEntries'
        /// </summary>
        [Fact]
        public void AbrEntriesTest()
        {
            // TODO unit test for the property 'AbrEntries'
        }

        /// <summary>
        /// Test the property 'SecuredCrashAnalysis'
        /// </summary>
        [Fact]
        public void SecuredCrashAnalysisTest()
        {
            // TODO unit test for the property 'SecuredCrashAnalysis'
        }

        /// <summary>
        /// Test the property 'SecureBackup'
        /// </summary>
        [Fact]
        public void SecureBackupTest()
        {
            // TODO unit test for the property 'SecureBackup'
        }

        /// <summary>
        /// Test the property 'CscReportTimeInterval'
        /// </summary>
        [Fact]
        public void CscReportTimeIntervalTest()
        {
            // TODO unit test for the property 'CscReportTimeInterval'
        }

        /// <summary>
        /// Test the property 'SendRawFlowData'
        /// </summary>
        [Fact]
        public void SendRawFlowDataTest()
        {
            // TODO unit test for the property 'SendRawFlowData'
        }
    }
}
