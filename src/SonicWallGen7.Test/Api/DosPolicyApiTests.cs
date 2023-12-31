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
    ///  Class for testing DosPolicyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DosPolicyApiTests : IDisposable
    {
        private DosPolicyApi instance;

        public DosPolicyApiTests()
        {
            instance = new DosPolicyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DosPolicyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DosPolicyApi
            //Assert.IsType<DosPolicyApi>(instance);
        }

        /// <summary>
        /// Test DosPoliciesGet
        /// </summary>
        [Fact]
        public void DosPoliciesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DosPoliciesGet();
            //Assert.IsType<DosPolicyCollection>(response);
        }

        /// <summary>
        /// Test DosPoliciesPost
        /// </summary>
        [Fact]
        public void DosPoliciesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DosPolicyCollection? dosPolicyCollection = null;
            //var response = instance.DosPoliciesPost(dosPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DosPoliciesPut
        /// </summary>
        [Fact]
        public void DosPoliciesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DosPolicyCollection? dosPolicyCollection = null;
            //var response = instance.DosPoliciesPut(dosPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DosPoliciesUuidUUIDDelete
        /// </summary>
        [Fact]
        public void DosPoliciesUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.DosPoliciesUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DosPoliciesUuidUUIDGet
        /// </summary>
        [Fact]
        public void DosPoliciesUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.DosPoliciesUuidUUIDGet(UUID);
            //Assert.IsType<DosPolicyCollection>(response);
        }

        /// <summary>
        /// Test DosPoliciesUuidUUIDPut
        /// </summary>
        [Fact]
        public void DosPoliciesUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //DosPolicyCollection? dosPolicyCollection = null;
            //var response = instance.DosPoliciesUuidUUIDPut(UUID, dosPolicyCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
