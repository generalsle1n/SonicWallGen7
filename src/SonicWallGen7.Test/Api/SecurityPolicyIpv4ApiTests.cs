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
    ///  Class for testing SecurityPolicyIpv4Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SecurityPolicyIpv4ApiTests : IDisposable
    {
        private SecurityPolicyIpv4Api instance;

        public SecurityPolicyIpv4ApiTests()
        {
            instance = new SecurityPolicyIpv4Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityPolicyIpv4Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecurityPolicyIpv4Api
            //Assert.IsType<SecurityPolicyIpv4Api>(instance);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4Get
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SecurityPoliciesIpv4Get();
            //Assert.IsType<SecurityPolicyIpv4Collection>(response);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4Post
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null;
            //var response = instance.SecurityPoliciesIpv4Post(securityPolicyIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4Put
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null;
            //var response = instance.SecurityPoliciesIpv4Put(securityPolicyIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4UuidUUIDDelete
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4UuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.SecurityPoliciesIpv4UuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4UuidUUIDGet
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4UuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.SecurityPoliciesIpv4UuidUUIDGet(UUID);
            //Assert.IsType<SecurityPolicyIpv4Collection>(response);
        }

        /// <summary>
        /// Test SecurityPoliciesIpv4UuidUUIDPut
        /// </summary>
        [Fact]
        public void SecurityPoliciesIpv4UuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //SecurityPolicyIpv4Collection? securityPolicyIpv4Collection = null;
            //var response = instance.SecurityPoliciesIpv4UuidUUIDPut(UUID, securityPolicyIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
