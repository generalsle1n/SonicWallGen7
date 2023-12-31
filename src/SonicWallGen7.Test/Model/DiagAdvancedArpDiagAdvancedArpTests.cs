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
    ///  Class for testing DiagAdvancedArpDiagAdvancedArp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedArpDiagAdvancedArpTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedArpDiagAdvancedArp
        //private DiagAdvancedArpDiagAdvancedArp instance;

        public DiagAdvancedArpDiagAdvancedArpTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedArpDiagAdvancedArp
            //instance = new DiagAdvancedArpDiagAdvancedArp();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedArpDiagAdvancedArp
        /// </summary>
        [Fact]
        public void DiagAdvancedArpDiagAdvancedArpInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedArpDiagAdvancedArp
            //Assert.IsType<DiagAdvancedArpDiagAdvancedArp>(instance);
        }

        /// <summary>
        /// Test the property 'Bridging'
        /// </summary>
        [Fact]
        public void BridgingTest()
        {
            // TODO unit test for the property 'Bridging'
        }

        /// <summary>
        /// Test the property 'OpenArpBehavior'
        /// </summary>
        [Fact]
        public void OpenArpBehaviorTest()
        {
            // TODO unit test for the property 'OpenArpBehavior'
        }

        /// <summary>
        /// Test the property 'SourceIpValidation'
        /// </summary>
        [Fact]
        public void SourceIpValidationTest()
        {
            // TODO unit test for the property 'SourceIpValidation'
        }

        /// <summary>
        /// Test the property 'OnlyUnicast'
        /// </summary>
        [Fact]
        public void OnlyUnicastTest()
        {
            // TODO unit test for the property 'OnlyUnicast'
        }

        /// <summary>
        /// Test the property 'LimitNonresponsive'
        /// </summary>
        [Fact]
        public void LimitNonresponsiveTest()
        {
            // TODO unit test for the property 'LimitNonresponsive'
        }

        /// <summary>
        /// Test the property 'RedundantIpResolutionRate'
        /// </summary>
        [Fact]
        public void RedundantIpResolutionRateTest()
        {
            // TODO unit test for the property 'RedundantIpResolutionRate'
        }

        /// <summary>
        /// Test the property 'GratuitousArpCompatibility'
        /// </summary>
        [Fact]
        public void GratuitousArpCompatibilityTest()
        {
            // TODO unit test for the property 'GratuitousArpCompatibility'
        }

        /// <summary>
        /// Test the property 'SecondarySubnet'
        /// </summary>
        [Fact]
        public void SecondarySubnetTest()
        {
            // TODO unit test for the property 'SecondarySubnet'
        }

        /// <summary>
        /// Test the property 'GratuitousArpLimit'
        /// </summary>
        [Fact]
        public void GratuitousArpLimitTest()
        {
            // TODO unit test for the property 'GratuitousArpLimit'
        }

        /// <summary>
        /// Test the property 'SystemBroadcast'
        /// </summary>
        [Fact]
        public void SystemBroadcastTest()
        {
            // TODO unit test for the property 'SystemBroadcast'
        }

        /// <summary>
        /// Test the property 'IgnoreArpsWithPrimaryMacFromOtherIf'
        /// </summary>
        [Fact]
        public void IgnoreArpsWithPrimaryMacFromOtherIfTest()
        {
            // TODO unit test for the property 'IgnoreArpsWithPrimaryMacFromOtherIf'
        }

        /// <summary>
        /// Test the property 'DisplayMacTracking'
        /// </summary>
        [Fact]
        public void DisplayMacTrackingTest()
        {
            // TODO unit test for the property 'DisplayMacTracking'
        }
    }
}
