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
    ///  Class for testing RoutePolicyIpv6Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RoutePolicyIpv6ApiTests : IDisposable
    {
        private RoutePolicyIpv6Api instance;

        public RoutePolicyIpv6ApiTests()
        {
            instance = new RoutePolicyIpv6Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoutePolicyIpv6Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RoutePolicyIpv6Api
            //Assert.IsType<RoutePolicyIpv6Api>(instance);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6Get
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RoutePoliciesIpv6Get();
            //Assert.IsType<RoutePolicyIpv6Collection>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6Patch
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoutePolicyIpv6Collection? routePolicyIpv6Collection = null;
            //var response = instance.RoutePoliciesIpv6Patch(routePolicyIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6Post
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoutePolicyIpv6Collection? routePolicyIpv6Collection = null;
            //var response = instance.RoutePoliciesIpv6Post(routePolicyIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6Put
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoutePolicyIpv6Collection? routePolicyIpv6Collection = null;
            //var response = instance.RoutePoliciesIpv6Put(routePolicyIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6UuidUUIDDelete
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6UuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.RoutePoliciesIpv6UuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6UuidUUIDGet
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6UuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.RoutePoliciesIpv6UuidUUIDGet(UUID);
            //Assert.IsType<RoutePolicyIpv6Collection>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6UuidUUIDPatch
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6UuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //RoutePolicyIpv6Collection? routePolicyIpv6Collection = null;
            //var response = instance.RoutePoliciesIpv6UuidUUIDPatch(UUID, routePolicyIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test RoutePoliciesIpv6UuidUUIDPut
        /// </summary>
        [Fact]
        public void RoutePoliciesIpv6UuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //RoutePolicyIpv6Collection? routePolicyIpv6Collection = null;
            //var response = instance.RoutePoliciesIpv6UuidUUIDPut(UUID, routePolicyIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}