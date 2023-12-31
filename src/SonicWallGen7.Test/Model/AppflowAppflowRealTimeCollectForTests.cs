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
    ///  Class for testing AppflowAppflowRealTimeCollectFor
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppflowAppflowRealTimeCollectForTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppflowAppflowRealTimeCollectFor
        //private AppflowAppflowRealTimeCollectFor instance;

        public AppflowAppflowRealTimeCollectForTests()
        {
            // TODO uncomment below to create an instance of AppflowAppflowRealTimeCollectFor
            //instance = new AppflowAppflowRealTimeCollectFor();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppflowAppflowRealTimeCollectFor
        /// </summary>
        [Fact]
        public void AppflowAppflowRealTimeCollectForInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppflowAppflowRealTimeCollectFor
            //Assert.IsType<AppflowAppflowRealTimeCollectFor>(instance);
        }

        /// <summary>
        /// Test the property 'TopApplications'
        /// </summary>
        [Fact]
        public void TopApplicationsTest()
        {
            // TODO unit test for the property 'TopApplications'
        }

        /// <summary>
        /// Test the property 'BitsPerSecond'
        /// </summary>
        [Fact]
        public void BitsPerSecondTest()
        {
            // TODO unit test for the property 'BitsPerSecond'
        }

        /// <summary>
        /// Test the property 'PacketsPerSecond'
        /// </summary>
        [Fact]
        public void PacketsPerSecondTest()
        {
            // TODO unit test for the property 'PacketsPerSecond'
        }

        /// <summary>
        /// Test the property 'AveragePacketSize'
        /// </summary>
        [Fact]
        public void AveragePacketSizeTest()
        {
            // TODO unit test for the property 'AveragePacketSize'
        }

        /// <summary>
        /// Test the property 'ConnectionsPerSecond'
        /// </summary>
        [Fact]
        public void ConnectionsPerSecondTest()
        {
            // TODO unit test for the property 'ConnectionsPerSecond'
        }

        /// <summary>
        /// Test the property 'CoreUtilization'
        /// </summary>
        [Fact]
        public void CoreUtilizationTest()
        {
            // TODO unit test for the property 'CoreUtilization'
        }

        /// <summary>
        /// Test the property 'InterfaceProtocols'
        /// </summary>
        [Fact]
        public void InterfaceProtocolsTest()
        {
            // TODO unit test for the property 'InterfaceProtocols'
        }

        /// <summary>
        /// Test the property 'MemoryUtilization'
        /// </summary>
        [Fact]
        public void MemoryUtilizationTest()
        {
            // TODO unit test for the property 'MemoryUtilization'
        }
    }
}
