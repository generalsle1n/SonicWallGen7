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
    ///  Class for testing DynamicDnsProfileIpv4ProfileIpv4OfflineSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DynamicDnsProfileIpv4ProfileIpv4OfflineSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DynamicDnsProfileIpv4ProfileIpv4OfflineSettings
        //private DynamicDnsProfileIpv4ProfileIpv4OfflineSettings instance;

        public DynamicDnsProfileIpv4ProfileIpv4OfflineSettingsTests()
        {
            // TODO uncomment below to create an instance of DynamicDnsProfileIpv4ProfileIpv4OfflineSettings
            //instance = new DynamicDnsProfileIpv4ProfileIpv4OfflineSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DynamicDnsProfileIpv4ProfileIpv4OfflineSettings
        /// </summary>
        [Fact]
        public void DynamicDnsProfileIpv4ProfileIpv4OfflineSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" DynamicDnsProfileIpv4ProfileIpv4OfflineSettings
            //Assert.IsType<DynamicDnsProfileIpv4ProfileIpv4OfflineSettings>(instance);
        }

        /// <summary>
        /// Test the property 'DoNothing'
        /// </summary>
        [Fact]
        public void DoNothingTest()
        {
            // TODO unit test for the property 'DoNothing'
        }

        /// <summary>
        /// Test the property 'UsePrevious'
        /// </summary>
        [Fact]
        public void UsePreviousTest()
        {
            // TODO unit test for the property 'UsePrevious'
        }

        /// <summary>
        /// Test the property 'MakeHostUnknown'
        /// </summary>
        [Fact]
        public void MakeHostUnknownTest()
        {
            // TODO unit test for the property 'MakeHostUnknown'
        }

        /// <summary>
        /// Test the property 'Manual'
        /// </summary>
        [Fact]
        public void ManualTest()
        {
            // TODO unit test for the property 'Manual'
        }
    }
}