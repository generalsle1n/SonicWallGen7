/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SonicWallGen7.Model;
using SonicWallGen7.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SonicWallGen7.Test.Model
{
    /// <summary>
    ///  Class for testing RoutePolicyIpv6Collection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RoutePolicyIpv6CollectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoutePolicyIpv6Collection
        //private RoutePolicyIpv6Collection instance;

        public RoutePolicyIpv6CollectionTests()
        {
            // TODO uncomment below to create an instance of RoutePolicyIpv6Collection
            //instance = new RoutePolicyIpv6Collection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoutePolicyIpv6Collection
        /// </summary>
        [Fact]
        public void RoutePolicyIpv6CollectionInstanceTest()
        {
            // TODO uncomment below to test "IsType" RoutePolicyIpv6Collection
            //Assert.IsType<RoutePolicyIpv6Collection>(instance);
        }

        /// <summary>
        /// Test the property 'RoutePolicies'
        /// </summary>
        [Fact]
        public void RoutePoliciesTest()
        {
            // TODO unit test for the property 'RoutePolicies'
        }
    }
}
