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
    ///  Class for testing AppflowAppflow
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppflowAppflowTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppflowAppflow
        //private AppflowAppflow instance;

        public AppflowAppflowTests()
        {
            // TODO uncomment below to create an instance of AppflowAppflow
            //instance = new AppflowAppflow();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppflowAppflow
        /// </summary>
        [Fact]
        public void AppflowAppflowInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppflowAppflow
            //Assert.IsType<AppflowAppflow>(instance);
        }

        /// <summary>
        /// Test the property 'RealTime'
        /// </summary>
        [Fact]
        public void RealTimeTest()
        {
            // TODO unit test for the property 'RealTime'
        }

        /// <summary>
        /// Test the property 'Aggregate'
        /// </summary>
        [Fact]
        public void AggregateTest()
        {
            // TODO unit test for the property 'Aggregate'
        }

        /// <summary>
        /// Test the property 'Report'
        /// </summary>
        [Fact]
        public void ReportTest()
        {
            // TODO unit test for the property 'Report'
        }

        /// <summary>
        /// Test the property 'FlowsTo'
        /// </summary>
        [Fact]
        public void FlowsToTest()
        {
            // TODO unit test for the property 'FlowsTo'
        }

        /// <summary>
        /// Test the property 'IncludeUrlTypes'
        /// </summary>
        [Fact]
        public void IncludeUrlTypesTest()
        {
            // TODO unit test for the property 'IncludeUrlTypes'
        }

        /// <summary>
        /// Test the property 'GeoIpResolution'
        /// </summary>
        [Fact]
        public void GeoIpResolutionTest()
        {
            // TODO unit test for the property 'GeoIpResolution'
        }
    }
}
