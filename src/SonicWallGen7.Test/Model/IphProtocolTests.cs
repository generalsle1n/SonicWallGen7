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
    ///  Class for testing IphProtocol
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IphProtocolTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IphProtocol
        //private IphProtocol instance;

        public IphProtocolTests()
        {
            // TODO uncomment below to create an instance of IphProtocol
            //instance = new IphProtocol();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IphProtocol
        /// </summary>
        [Fact]
        public void IphProtocolInstanceTest()
        {
            // TODO uncomment below to test "IsType" IphProtocol
            //Assert.IsType<IphProtocol>(instance);
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
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }

        /// <summary>
        /// Test the property 'Port1'
        /// </summary>
        [Fact]
        public void Port1Test()
        {
            // TODO unit test for the property 'Port1'
        }

        /// <summary>
        /// Test the property 'Port2'
        /// </summary>
        [Fact]
        public void Port2Test()
        {
            // TODO unit test for the property 'Port2'
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }

        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }

        /// <summary>
        /// Test the property 'MulticastIp'
        /// </summary>
        [Fact]
        public void MulticastIpTest()
        {
            // TODO unit test for the property 'MulticastIp'
        }

        /// <summary>
        /// Test the property 'MulticastIpv6'
        /// </summary>
        [Fact]
        public void MulticastIpv6Test()
        {
            // TODO unit test for the property 'MulticastIpv6'
        }

        /// <summary>
        /// Test the property 'SourceTranslation'
        /// </summary>
        [Fact]
        public void SourceTranslationTest()
        {
            // TODO unit test for the property 'SourceTranslation'
        }

        /// <summary>
        /// Test the property 'Raw'
        /// </summary>
        [Fact]
        public void RawTest()
        {
            // TODO unit test for the property 'Raw'
        }
    }
}
