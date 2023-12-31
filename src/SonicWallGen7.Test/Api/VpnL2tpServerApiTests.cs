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
    ///  Class for testing VpnL2tpServerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VpnL2tpServerApiTests : IDisposable
    {
        private VpnL2tpServerApi instance;

        public VpnL2tpServerApiTests()
        {
            instance = new VpnL2tpServerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnL2tpServerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VpnL2tpServerApi
            //Assert.IsType<VpnL2tpServerApi>(instance);
        }

        /// <summary>
        /// Test VpnL2tpServerBaseGet
        /// </summary>
        [Fact]
        public void VpnL2tpServerBaseGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VpnL2tpServerBaseGet();
            //Assert.IsType<VpnL2tpServer>(response);
        }

        /// <summary>
        /// Test VpnL2tpServerBasePut
        /// </summary>
        [Fact]
        public void VpnL2tpServerBasePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnL2tpServer? vpnL2tpServer = null;
            //var response = instance.VpnL2tpServerBasePut(vpnL2tpServer);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
