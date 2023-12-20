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
    ///  Class for testing ContentFilterProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContentFilterProfileApiTests : IDisposable
    {
        private ContentFilterProfileApi instance;

        public ContentFilterProfileApiTests()
        {
            instance = new ContentFilterProfileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentFilterProfileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ContentFilterProfileApi
            //Assert.IsType<ContentFilterProfileApi>(instance);
        }

        /// <summary>
        /// Test ContentFilterProfilesGet
        /// </summary>
        [Fact]
        public void ContentFilterProfilesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ContentFilterProfilesGet();
            //Assert.IsType<ContentFilterProfileCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesNameNAMEDelete
        /// </summary>
        [Fact]
        public void ContentFilterProfilesNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ContentFilterProfilesNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesNameNAMEGet
        /// </summary>
        [Fact]
        public void ContentFilterProfilesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ContentFilterProfilesNameNAMEGet(NAME);
            //Assert.IsType<ContentFilterProfileCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesNameNAMEPatch
        /// </summary>
        [Fact]
        public void ContentFilterProfilesNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesNameNAMEPatch(NAME, contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesNameNAMEPut
        /// </summary>
        [Fact]
        public void ContentFilterProfilesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesNameNAMEPut(NAME, contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesPatch
        /// </summary>
        [Fact]
        public void ContentFilterProfilesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesPatch(contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesPost
        /// </summary>
        [Fact]
        public void ContentFilterProfilesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesPost(contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesPut
        /// </summary>
        [Fact]
        public void ContentFilterProfilesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesPut(contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesUuidUUIDDelete
        /// </summary>
        [Fact]
        public void ContentFilterProfilesUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ContentFilterProfilesUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesUuidUUIDGet
        /// </summary>
        [Fact]
        public void ContentFilterProfilesUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ContentFilterProfilesUuidUUIDGet(UUID);
            //Assert.IsType<ContentFilterProfileCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesUuidUUIDPatch
        /// </summary>
        [Fact]
        public void ContentFilterProfilesUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesUuidUUIDPatch(UUID, contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterProfilesUuidUUIDPut
        /// </summary>
        [Fact]
        public void ContentFilterProfilesUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ContentFilterProfileCollection? contentFilterProfileCollection = null;
            //var response = instance.ContentFilterProfilesUuidUUIDPut(UUID, contentFilterProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
