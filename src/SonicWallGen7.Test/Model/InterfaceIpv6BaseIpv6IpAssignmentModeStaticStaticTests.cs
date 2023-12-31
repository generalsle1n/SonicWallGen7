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
    ///  Class for testing InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic
        //private InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic instance;

        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticTests()
        {
            // TODO uncomment below to create an instance of InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic
            //instance = new InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic
        /// </summary>
        [Fact]
        public void InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticInstanceTest()
        {
            // TODO uncomment below to test "IsType" InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic
            //Assert.IsType<InterfaceIpv6BaseIpv6IpAssignmentModeStaticStatic>(instance);
        }

        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

        /// <summary>
        /// Test the property 'PrefixLength'
        /// </summary>
        [Fact]
        public void PrefixLengthTest()
        {
            // TODO unit test for the property 'PrefixLength'
        }

        /// <summary>
        /// Test the property 'SonicDns'
        /// </summary>
        [Fact]
        public void SonicDnsTest()
        {
            // TODO unit test for the property 'SonicDns'
        }

        /// <summary>
        /// Test the property 'Gateway'
        /// </summary>
        [Fact]
        public void GatewayTest()
        {
            // TODO unit test for the property 'Gateway'
        }

        /// <summary>
        /// Test the property 'AdvertiseSubnetPrefix'
        /// </summary>
        [Fact]
        public void AdvertiseSubnetPrefixTest()
        {
            // TODO unit test for the property 'AdvertiseSubnetPrefix'
        }

        /// <summary>
        /// Test the property 'RouterAdvertisement'
        /// </summary>
        [Fact]
        public void RouterAdvertisementTest()
        {
            // TODO unit test for the property 'RouterAdvertisement'
        }
    }
}
