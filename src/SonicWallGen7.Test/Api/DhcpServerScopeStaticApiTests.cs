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
    ///  Class for testing DhcpServerScopeStaticApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DhcpServerScopeStaticApiTests : IDisposable
    {
        private DhcpServerScopeStaticApi instance;

        public DhcpServerScopeStaticApiTests()
        {
            instance = new DhcpServerScopeStaticApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DhcpServerScopeStaticApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DhcpServerScopeStaticApi
            //Assert.IsType<DhcpServerScopeStaticApi>(instance);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticGet
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DhcpServerIpv4ScopesStaticGet();
            //Assert.IsType<DhcpServerScopeStaticCollection>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticIpIPMacMACDelete
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticIpIPMacMACDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //var response = instance.DhcpServerIpv4ScopesStaticIpIPMacMACDelete(IP, MAC);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticIpIPMacMACGet
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticIpIPMacMACGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //var response = instance.DhcpServerIpv4ScopesStaticIpIPMacMACGet(IP, MAC);
            //Assert.IsType<DhcpServerScopeStaticCollection>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticIpIPMacMACPatch
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticIpIPMacMACPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv4ScopesStaticIpIPMacMACPatch(IP, MAC, dhcpServerScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticIpIPMacMACPut
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticIpIPMacMACPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv4ScopesStaticIpIPMacMACPut(IP, MAC, dhcpServerScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticPatch
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv4ScopesStaticPatch(dhcpServerScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticPost
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv4ScopesStaticPost(dhcpServerScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DhcpServerIpv4ScopesStaticPut
        /// </summary>
        [Fact]
        public void DhcpServerIpv4ScopesStaticPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DhcpServerScopeStaticCollection? dhcpServerScopeStaticCollection = null;
            //var response = instance.DhcpServerIpv4ScopesStaticPut(dhcpServerScopeStaticCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
