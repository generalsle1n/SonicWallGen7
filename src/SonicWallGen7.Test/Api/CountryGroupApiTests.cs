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
    ///  Class for testing CountryGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CountryGroupApiTests : IDisposable
    {
        private CountryGroupApi instance;

        public CountryGroupApiTests()
        {
            instance = new CountryGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CountryGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CountryGroupApi
            //Assert.IsType<CountryGroupApi>(instance);
        }

        /// <summary>
        /// Test CountryGroupsGet
        /// </summary>
        [Fact]
        public void CountryGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CountryGroupsGet();
            //Assert.IsType<CountryGroupCollection>(response);
        }

        /// <summary>
        /// Test CountryGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void CountryGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.CountryGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void CountryGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.CountryGroupsNameNAMEGet(NAME);
            //Assert.IsType<CountryGroupCollection>(response);
        }

        /// <summary>
        /// Test CountryGroupsNameNAMEPatch
        /// </summary>
        [Fact]
        public void CountryGroupsNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsNameNAMEPatch(NAME, countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void CountryGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsNameNAMEPut(NAME, countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsPatch
        /// </summary>
        [Fact]
        public void CountryGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsPatch(countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsPost
        /// </summary>
        [Fact]
        public void CountryGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsPost(countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsPut
        /// </summary>
        [Fact]
        public void CountryGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsPut(countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsUuidUUIDDelete
        /// </summary>
        [Fact]
        public void CountryGroupsUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.CountryGroupsUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsUuidUUIDGet
        /// </summary>
        [Fact]
        public void CountryGroupsUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.CountryGroupsUuidUUIDGet(UUID);
            //Assert.IsType<CountryGroupCollection>(response);
        }

        /// <summary>
        /// Test CountryGroupsUuidUUIDPatch
        /// </summary>
        [Fact]
        public void CountryGroupsUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsUuidUUIDPatch(UUID, countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test CountryGroupsUuidUUIDPut
        /// </summary>
        [Fact]
        public void CountryGroupsUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //CountryGroupCollection? countryGroupCollection = null;
            //var response = instance.CountryGroupsUuidUUIDPut(UUID, countryGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
