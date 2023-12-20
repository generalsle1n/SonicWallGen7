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
    ///  Class for testing MacIpAntiSpoofIpv4Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MacIpAntiSpoofIpv4ApiTests : IDisposable
    {
        private MacIpAntiSpoofIpv4Api instance;

        public MacIpAntiSpoofIpv4ApiTests()
        {
            instance = new MacIpAntiSpoofIpv4Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MacIpAntiSpoofIpv4Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MacIpAntiSpoofIpv4Api
            //Assert.IsType<MacIpAntiSpoofIpv4Api>(instance);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4InterfacesGet
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4InterfacesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MacIpAntiSpoofIpv4InterfacesGet();
            //Assert.IsType<MacIpAntiSpoofIpv4Collection>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4InterfacesNameNAMEGet
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4InterfacesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.MacIpAntiSpoofIpv4InterfacesNameNAMEGet(NAME);
            //Assert.IsType<MacIpAntiSpoofIpv4Collection>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4InterfacesNameNAMEPut
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4InterfacesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //MacIpAntiSpoofIpv4Collection? macIpAntiSpoofIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4InterfacesNameNAMEPut(NAME, macIpAntiSpoofIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4InterfacesPut
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4InterfacesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MacIpAntiSpoofIpv4Collection? macIpAntiSpoofIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4InterfacesPut(macIpAntiSpoofIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
