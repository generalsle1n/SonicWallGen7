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
    ///  Class for testing DhcpServerIpv6ScopeStatic
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DhcpServerIpv6ScopeStaticTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DhcpServerIpv6ScopeStatic
        //private DhcpServerIpv6ScopeStatic instance;

        public DhcpServerIpv6ScopeStaticTests()
        {
            // TODO uncomment below to create an instance of DhcpServerIpv6ScopeStatic
            //instance = new DhcpServerIpv6ScopeStatic();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DhcpServerIpv6ScopeStatic
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopeStaticInstanceTest()
        {
            // TODO uncomment below to test "IsType" DhcpServerIpv6ScopeStatic
            //Assert.IsType<DhcpServerIpv6ScopeStatic>(instance);
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
        /// Test the property 'Prefix'
        /// </summary>
        [Fact]
        public void PrefixTest()
        {
            // TODO unit test for the property 'Prefix'
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
        /// Test the property 'Iaid'
        /// </summary>
        [Fact]
        public void IaidTest()
        {
            // TODO unit test for the property 'Iaid'
        }

        /// <summary>
        /// Test the property 'Duid'
        /// </summary>
        [Fact]
        public void DuidTest()
        {
            // TODO unit test for the property 'Duid'
        }

        /// <summary>
        /// Test the property 'Lifetime'
        /// </summary>
        [Fact]
        public void LifetimeTest()
        {
            // TODO unit test for the property 'Lifetime'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }

        /// <summary>
        /// Test the property 'DomainName'
        /// </summary>
        [Fact]
        public void DomainNameTest()
        {
            // TODO unit test for the property 'DomainName'
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
        /// Test the property 'GenericOption'
        /// </summary>
        [Fact]
        public void GenericOptionTest()
        {
            // TODO unit test for the property 'GenericOption'
        }

        /// <summary>
        /// Test the property 'AlwaysSendOption'
        /// </summary>
        [Fact]
        public void AlwaysSendOptionTest()
        {
            // TODO unit test for the property 'AlwaysSendOption'
        }
    }
}
