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
    ///  Class for testing MacIpAntiSpoofCacheIpv4Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MacIpAntiSpoofCacheIpv4ApiTests : IDisposable
    {
        private MacIpAntiSpoofCacheIpv4Api instance;

        public MacIpAntiSpoofCacheIpv4ApiTests()
        {
            instance = new MacIpAntiSpoofCacheIpv4Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MacIpAntiSpoofCacheIpv4Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MacIpAntiSpoofCacheIpv4Api
            //Assert.IsType<MacIpAntiSpoofCacheIpv4Api>(instance);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesGet
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesGet();
            //Assert.IsType<MacIpAntiSpoofCacheIpv4Collection>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //string IFNAME = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEDelete(IP, MAC, IFNAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //string IFNAME = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEGet(IP, MAC, IFNAME);
            //Assert.IsType<MacIpAntiSpoofCacheIpv4Collection>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //string IFNAME = null;
            //MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPatch(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string IP = null;
            //string MAC = null;
            //string IFNAME = null;
            //MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesIpIPMacMACInterfaceIFNAMEPut(IP, MAC, IFNAME, macIpAntiSpoofCacheIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesPatch
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesPatch(macIpAntiSpoofCacheIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesPost
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesPost(macIpAntiSpoofCacheIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test MacIpAntiSpoofIpv4CacheEntriesPut
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CacheEntriesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MacIpAntiSpoofCacheIpv4Collection? macIpAntiSpoofCacheIpv4Collection = null;
            //var response = instance.MacIpAntiSpoofIpv4CacheEntriesPut(macIpAntiSpoofCacheIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
