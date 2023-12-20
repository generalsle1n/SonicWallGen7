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
    ///  Class for testing RoutePolicyIpv4Ipv4Gateway3
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RoutePolicyIpv4Ipv4Gateway3Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoutePolicyIpv4Ipv4Gateway3
        //private RoutePolicyIpv4Ipv4Gateway3 instance;

        public RoutePolicyIpv4Ipv4Gateway3Tests()
        {
            // TODO uncomment below to create an instance of RoutePolicyIpv4Ipv4Gateway3
            //instance = new RoutePolicyIpv4Ipv4Gateway3();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoutePolicyIpv4Ipv4Gateway3
        /// </summary>
        [Fact]
        public void RoutePolicyIpv4Ipv4Gateway3InstanceTest()
        {
            // TODO uncomment below to test "IsType" RoutePolicyIpv4Ipv4Gateway3
            //Assert.IsType<RoutePolicyIpv4Ipv4Gateway3>(instance);
        }

        /// <summary>
        /// Test the property 'VarDefault'
        /// </summary>
        [Fact]
        public void VarDefaultTest()
        {
            // TODO unit test for the property 'VarDefault'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Host'
        /// </summary>
        [Fact]
        public void HostTest()
        {
            // TODO unit test for the property 'Host'
        }
    }
}