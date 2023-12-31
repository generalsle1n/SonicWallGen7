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
    ///  Class for testing HaBaseHighAvailabilityL3Mode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HaBaseHighAvailabilityL3ModeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HaBaseHighAvailabilityL3Mode
        //private HaBaseHighAvailabilityL3Mode instance;

        public HaBaseHighAvailabilityL3ModeTests()
        {
            // TODO uncomment below to create an instance of HaBaseHighAvailabilityL3Mode
            //instance = new HaBaseHighAvailabilityL3Mode();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HaBaseHighAvailabilityL3Mode
        /// </summary>
        [Fact]
        public void HaBaseHighAvailabilityL3ModeInstanceTest()
        {
            // TODO uncomment below to test "IsType" HaBaseHighAvailabilityL3Mode
            //Assert.IsType<HaBaseHighAvailabilityL3Mode>(instance);
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
        /// Test the property 'PrimaryIp'
        /// </summary>
        [Fact]
        public void PrimaryIpTest()
        {
            // TODO unit test for the property 'PrimaryIp'
        }

        /// <summary>
        /// Test the property 'SecondaryIp'
        /// </summary>
        [Fact]
        public void SecondaryIpTest()
        {
            // TODO unit test for the property 'SecondaryIp'
        }

        /// <summary>
        /// Test the property 'PrimaryGateway'
        /// </summary>
        [Fact]
        public void PrimaryGatewayTest()
        {
            // TODO unit test for the property 'PrimaryGateway'
        }

        /// <summary>
        /// Test the property 'SecondaryGateway'
        /// </summary>
        [Fact]
        public void SecondaryGatewayTest()
        {
            // TODO unit test for the property 'SecondaryGateway'
        }
    }
}
