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
    ///  Class for testing Udpv6UdpIpv6Flood
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class Udpv6UdpIpv6FloodTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Udpv6UdpIpv6Flood
        //private Udpv6UdpIpv6Flood instance;

        public Udpv6UdpIpv6FloodTests()
        {
            // TODO uncomment below to create an instance of Udpv6UdpIpv6Flood
            //instance = new Udpv6UdpIpv6Flood();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Udpv6UdpIpv6Flood
        /// </summary>
        [Fact]
        public void Udpv6UdpIpv6FloodInstanceTest()
        {
            // TODO uncomment below to test "IsType" Udpv6UdpIpv6Flood
            //Assert.IsType<Udpv6UdpIpv6Flood>(instance);
        }

        /// <summary>
        /// Test the property 'Protection'
        /// </summary>
        [Fact]
        public void ProtectionTest()
        {
            // TODO unit test for the property 'Protection'
        }

        /// <summary>
        /// Test the property 'AttackThreshold'
        /// </summary>
        [Fact]
        public void AttackThresholdTest()
        {
            // TODO unit test for the property 'AttackThreshold'
        }

        /// <summary>
        /// Test the property 'BlockTimeout'
        /// </summary>
        [Fact]
        public void BlockTimeoutTest()
        {
            // TODO unit test for the property 'BlockTimeout'
        }

        /// <summary>
        /// Test the property 'ProtectedDestList'
        /// </summary>
        [Fact]
        public void ProtectedDestListTest()
        {
            // TODO unit test for the property 'ProtectedDestList'
        }
    }
}
