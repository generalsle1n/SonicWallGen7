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
    ///  Class for testing DiagAdvancedCtaReportDiagAdvancedCtaReport
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedCtaReportDiagAdvancedCtaReportTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedCtaReportDiagAdvancedCtaReport
        //private DiagAdvancedCtaReportDiagAdvancedCtaReport instance;

        public DiagAdvancedCtaReportDiagAdvancedCtaReportTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedCtaReportDiagAdvancedCtaReport
            //instance = new DiagAdvancedCtaReportDiagAdvancedCtaReport();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedCtaReportDiagAdvancedCtaReport
        /// </summary>
        [Fact]
        public void DiagAdvancedCtaReportDiagAdvancedCtaReportInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedCtaReportDiagAdvancedCtaReport
            //Assert.IsType<DiagAdvancedCtaReportDiagAdvancedCtaReport>(instance);
        }

        /// <summary>
        /// Test the property 'ServiceAddress'
        /// </summary>
        [Fact]
        public void ServiceAddressTest()
        {
            // TODO unit test for the property 'ServiceAddress'
        }

        /// <summary>
        /// Test the property 'ServiceHttpsPort'
        /// </summary>
        [Fact]
        public void ServiceHttpsPortTest()
        {
            // TODO unit test for the property 'ServiceHttpsPort'
        }

        /// <summary>
        /// Test the property 'UploadToCloudService'
        /// </summary>
        [Fact]
        public void UploadToCloudServiceTest()
        {
            // TODO unit test for the property 'UploadToCloudService'
        }

        /// <summary>
        /// Test the property 'UploadToYamlFormat'
        /// </summary>
        [Fact]
        public void UploadToYamlFormatTest()
        {
            // TODO unit test for the property 'UploadToYamlFormat'
        }

        /// <summary>
        /// Test the property 'SupportForCtav1Only'
        /// </summary>
        [Fact]
        public void SupportForCtav1OnlyTest()
        {
            // TODO unit test for the property 'SupportForCtav1Only'
        }

        /// <summary>
        /// Test the property 'CscReportingCloudFqdn'
        /// </summary>
        [Fact]
        public void CscReportingCloudFqdnTest()
        {
            // TODO unit test for the property 'CscReportingCloudFqdn'
        }
    }
}
