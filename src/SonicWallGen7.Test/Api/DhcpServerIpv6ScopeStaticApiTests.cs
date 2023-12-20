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
    ///  Class for testing DhcpServerIpv6ScopeStaticApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DhcpServerIpv6ScopeStaticApiTests : IDisposable
    {
        private DhcpServerIpv6ScopeStaticApi instance;

        public DhcpServerIpv6ScopeStaticApiTests()
        {
            instance = new DhcpServerIpv6ScopeStaticApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DhcpServerIpv6ScopeStaticApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DhcpServerIpv6ScopeStaticApi
            //Assert.IsType<DhcpServerIpv6ScopeStaticApi>(instance);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticGet
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DhcpServerIpv6ScopesStaticGet();
            //Assert.IsType<DhcpServerIpv6ScopeStaticCollection>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticNameNAMEDelete
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.DhcpServerIpv6ScopesStaticNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticNameNAMEGet
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.DhcpServerIpv6ScopesStaticNameNAMEGet(NAME);
            //Assert.IsType<DhcpServerIpv6ScopeStaticCollection>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticNameNAMEPatch
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv6ScopesStaticNameNAMEPatch(NAME, dhcpServerIpv6ScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticNameNAMEPut
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv6ScopesStaticNameNAMEPut(NAME, dhcpServerIpv6ScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticPatch
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv6ScopesStaticPatch(dhcpServerIpv6ScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticPost
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv6ScopesStaticPost(dhcpServerIpv6ScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv6ScopesStaticPut
        /// </summary>
        [Fact]
        public void DhcpServerIpv6ScopesStaticPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerIpv6ScopeStaticCollection? dhcpServerIpv6ScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv6ScopesStaticPut(dhcpServerIpv6ScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
