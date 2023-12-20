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
    ///  Class for testing CustomMatchGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomMatchGroupApiTests : IDisposable
    {
        private CustomMatchGroupApi instance;

        public CustomMatchGroupApiTests()
        {
            instance = new CustomMatchGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomMatchGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomMatchGroupApi
            //Assert.IsType<CustomMatchGroupApi>(instance);
        }

        /// <summary>
        /// Test CustomMatchGroupsGet
        /// </summary>
        [Fact]
        public void CustomMatchGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CustomMatchGroupsGet();
            //Assert.IsType<CustomMatchGroupCollection>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void CustomMatchGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.CustomMatchGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void CustomMatchGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.CustomMatchGroupsNameNAMEGet(NAME);
            //Assert.IsType<CustomMatchGroupCollection>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void CustomMatchGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //CustomMatchGroupCollection? customMatchGroupCollection = null;
            //var response = instance.CustomMatchGroupsNameNAMEPut(NAME, customMatchGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsPost
        /// </summary>
        [Fact]
        public void CustomMatchGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomMatchGroupCollection? customMatchGroupCollection = null;
            //var response = instance.CustomMatchGroupsPost(customMatchGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsPut
        /// </summary>
        [Fact]
        public void CustomMatchGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomMatchGroupCollection? customMatchGroupCollection = null;
            //var response = instance.CustomMatchGroupsPut(customMatchGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsUuidUUIDDelete
        /// </summary>
        [Fact]
        public void CustomMatchGroupsUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.CustomMatchGroupsUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsUuidUUIDGet
        /// </summary>
        [Fact]
        public void CustomMatchGroupsUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.CustomMatchGroupsUuidUUIDGet(UUID);
            //Assert.IsType<CustomMatchGroupCollection>(response);
        }

        /// <summary>
        /// Test CustomMatchGroupsUuidUUIDPut
        /// </summary>
        [Fact]
        public void CustomMatchGroupsUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //CustomMatchGroupCollection? customMatchGroupCollection = null;
            //var response = instance.CustomMatchGroupsUuidUUIDPut(UUID, customMatchGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}