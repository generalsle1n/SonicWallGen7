/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SonicWallGen7.Client;
using SonicWallGen7.Api;
// uncomment below to import models
//using SonicWallGen7.Model;

namespace SonicWallGen7.Test.Api
{
    /// <summary>
    ///  Class for testing FlbGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FlbGroupApiTests : IDisposable
    {
        private FlbGroupApi instance;

        public FlbGroupApiTests()
        {
            instance = new FlbGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FlbGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FlbGroupApi
            //Assert.IsType<FlbGroupApi>(instance);
        }

        /// <summary>
        /// Test FailoverLbGroupsGet
        /// </summary>
        [Fact]
        public void FailoverLbGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FailoverLbGroupsGet();
            //Assert.IsType<FlbGroupCollection>(response);
        }

        /// <summary>
        /// Test FailoverLbGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void FailoverLbGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.FailoverLbGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test FailoverLbGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void FailoverLbGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.FailoverLbGroupsNameNAMEGet(NAME);
            //Assert.IsType<FlbGroupCollection>(response);
        }

        /// <summary>
        /// Test FailoverLbGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void FailoverLbGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //FlbGroupCollection? flbGroupCollection = null;
            //var response = instance.FailoverLbGroupsNameNAMEPut(NAME, flbGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test FailoverLbGroupsPut
        /// </summary>
        [Fact]
        public void FailoverLbGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FlbGroupCollection? flbGroupCollection = null;
            //var response = instance.FailoverLbGroupsPut(flbGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}