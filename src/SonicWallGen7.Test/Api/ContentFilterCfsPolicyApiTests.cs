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
    ///  Class for testing ContentFilterCfsPolicyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContentFilterCfsPolicyApiTests : IDisposable
    {
        private ContentFilterCfsPolicyApi instance;

        public ContentFilterCfsPolicyApiTests()
        {
            instance = new ContentFilterCfsPolicyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentFilterCfsPolicyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ContentFilterCfsPolicyApi
            //Assert.IsType<ContentFilterCfsPolicyApi>(instance);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesGet
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ContentFilterCfsPoliciesGet();
            //Assert.IsType<ContentFilterCfsPolicyCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesNameNAMEDelete
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ContentFilterCfsPoliciesNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesNameNAMEGet
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ContentFilterCfsPoliciesNameNAMEGet(NAME);
            //Assert.IsType<ContentFilterCfsPolicyCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesNameNAMEPatch
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesNameNAMEPatch(NAME, contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesNameNAMEPut
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesNameNAMEPut(NAME, contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesPatch
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesPatch(contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesPost
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesPost(contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesPut
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesPut(contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesUuidUUIDDelete
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ContentFilterCfsPoliciesUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesUuidUUIDGet
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ContentFilterCfsPoliciesUuidUUIDGet(UUID);
            //Assert.IsType<ContentFilterCfsPolicyCollection>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesUuidUUIDPatch
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesUuidUUIDPatch(UUID, contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test ContentFilterCfsPoliciesUuidUUIDPut
        /// </summary>
        [Fact]
        public void ContentFilterCfsPoliciesUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //ContentFilterCfsPolicyCollection? contentFilterCfsPolicyCollection = null;
            //var response = instance.ContentFilterCfsPoliciesUuidUUIDPut(UUID, contentFilterCfsPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}