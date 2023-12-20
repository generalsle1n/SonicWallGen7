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
    ///  Class for testing WebsiteGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebsiteGroupApiTests : IDisposable
    {
        private WebsiteGroupApi instance;

        public WebsiteGroupApiTests()
        {
            instance = new WebsiteGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebsiteGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebsiteGroupApi
            //Assert.IsType<WebsiteGroupApi>(instance);
        }

        /// <summary>
        /// Test WebsiteGroupsGet
        /// </summary>
        [Fact]
        public void WebsiteGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WebsiteGroupsGet();
            //Assert.IsType<WebsiteGroupCollection>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsNameNAMEDelete
        /// </summary>
        [Fact]
        public void WebsiteGroupsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.WebsiteGroupsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsNameNAMEGet
        /// </summary>
        [Fact]
        public void WebsiteGroupsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.WebsiteGroupsNameNAMEGet(NAME);
            //Assert.IsType<WebsiteGroupCollection>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsNameNAMEPatch
        /// </summary>
        [Fact]
        public void WebsiteGroupsNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsNameNAMEPatch(NAME, websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsNameNAMEPut
        /// </summary>
        [Fact]
        public void WebsiteGroupsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsNameNAMEPut(NAME, websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsPatch
        /// </summary>
        [Fact]
        public void WebsiteGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsPatch(websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsPost
        /// </summary>
        [Fact]
        public void WebsiteGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsPost(websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsPut
        /// </summary>
        [Fact]
        public void WebsiteGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsPut(websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsUuidUUIDDelete
        /// </summary>
        [Fact]
        public void WebsiteGroupsUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.WebsiteGroupsUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsUuidUUIDGet
        /// </summary>
        [Fact]
        public void WebsiteGroupsUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.WebsiteGroupsUuidUUIDGet(UUID);
            //Assert.IsType<WebsiteGroupCollection>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsUuidUUIDPatch
        /// </summary>
        [Fact]
        public void WebsiteGroupsUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsUuidUUIDPatch(UUID, websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test WebsiteGroupsUuidUUIDPut
        /// </summary>
        [Fact]
        public void WebsiteGroupsUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //WebsiteGroupCollection? websiteGroupCollection = null;
            //var response = instance.WebsiteGroupsUuidUUIDPut(UUID, websiteGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}