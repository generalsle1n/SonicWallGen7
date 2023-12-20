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
    ///  Class for testing SdwanGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SdwanGroupApiTests : IDisposable
    {
        private SdwanGroupApi instance;

        public SdwanGroupApiTests()
        {
            instance = new SdwanGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SdwanGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SdwanGroupApi
            //Assert.IsType<SdwanGroupApi>(instance);
        }

        /// <summary>
        /// Test SdwanGroupsGet
        /// </summary>
        [Fact]
        public void SdwanGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SdwanGroupsGet();
            //Assert.IsType<SdwanGroupCollection>(response);
        }

        /// <summary>
        /// Test SdwanGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void SdwanGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SdwanGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SdwanGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void SdwanGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SdwanGroupsNameNAMEGet(NAME);
            //Assert.IsType<SdwanGroupCollection>(response);
        }

        /// <summary>
        /// Test SdwanGroupsNameNAMEPatch
        /// </summary>
        [Fact]
        public void SdwanGroupsNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SdwanGroupCollection? sdwanGroupCollection = null;
            //var response = instance.SdwanGroupsNameNAMEPatch(NAME, sdwanGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SdwanGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void SdwanGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SdwanGroupCollection? sdwanGroupCollection = null;
            //var response = instance.SdwanGroupsNameNAMEPut(NAME, sdwanGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SdwanGroupsPatch
        /// </summary>
        [Fact]
        public void SdwanGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SdwanGroupCollection? sdwanGroupCollection = null;
            //var response = instance.SdwanGroupsPatch(sdwanGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SdwanGroupsPost
        /// </summary>
        [Fact]
        public void SdwanGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SdwanGroupCollection? sdwanGroupCollection = null;
            //var response = instance.SdwanGroupsPost(sdwanGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SdwanGroupsPut
        /// </summary>
        [Fact]
        public void SdwanGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SdwanGroupCollection? sdwanGroupCollection = null;
            //var response = instance.SdwanGroupsPut(sdwanGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}