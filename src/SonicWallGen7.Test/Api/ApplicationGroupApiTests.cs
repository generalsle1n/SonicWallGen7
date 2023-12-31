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
    ///  Class for testing ApplicationGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationGroupApiTests : IDisposable
    {
        private ApplicationGroupApi instance;

        public ApplicationGroupApiTests()
        {
            instance = new ApplicationGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApplicationGroupApi
            //Assert.IsType<ApplicationGroupApi>(instance);
        }

        /// <summary>
        /// Test ApplicationGroupsGet
        /// </summary>
        [Fact]
        public void ApplicationGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApplicationGroupsGet();
            //Assert.IsType<ApplicationGroupCollection>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void ApplicationGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ApplicationGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void ApplicationGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ApplicationGroupsNameNAMEGet(NAME);
            //Assert.IsType<ApplicationGroupCollection>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsNameNAMEPatch
        /// </summary>
        [Fact]
        public void ApplicationGroupsNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsNameNAMEPatch(NAME, applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void ApplicationGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsNameNAMEPut(NAME, applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsPatch
        /// </summary>
        [Fact]
        public void ApplicationGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsPatch(applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsPost
        /// </summary>
        [Fact]
        public void ApplicationGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsPost(applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsPut
        /// </summary>
        [Fact]
        public void ApplicationGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsPut(applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsUuidUUIDDelete
        /// </summary>
        [Fact]
        public void ApplicationGroupsUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ApplicationGroupsUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsUuidUUIDGet
        /// </summary>
        [Fact]
        public void ApplicationGroupsUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ApplicationGroupsUuidUUIDGet(UUID);
            //Assert.IsType<ApplicationGroupCollection>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsUuidUUIDPatch
        /// </summary>
        [Fact]
        public void ApplicationGroupsUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsUuidUUIDPatch(UUID, applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ApplicationGroupsUuidUUIDPut
        /// </summary>
        [Fact]
        public void ApplicationGroupsUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ApplicationGroupCollection? applicationGroupCollection = null;
            //var response = instance.ApplicationGroupsUuidUUIDPut(UUID, applicationGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
