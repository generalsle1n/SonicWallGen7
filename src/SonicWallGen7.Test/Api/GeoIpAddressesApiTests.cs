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
    ///  Class for testing GeoIpAddressesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GeoIpAddressesApiTests : IDisposable
    {
        private GeoIpAddressesApi instance;

        public GeoIpAddressesApiTests()
        {
            instance = new GeoIpAddressesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GeoIpAddressesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GeoIpAddressesApi
            //Assert.IsType<GeoIpAddressesApi>(instance);
        }

        /// <summary>
        /// Test GeoIpAddressesGet
        /// </summary>
        [Fact]
        public void GeoIpAddressesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GeoIpAddressesGet();
            //Assert.IsType<GeoIpAddressesCollection>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesGroupGRPNAMEDelete
        /// </summary>
        [Fact]
        public void GeoIpAddressesGroupGRPNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string GRPNAME = null;
            //var response = instance.GeoIpAddressesGroupGRPNAMEDelete(GRPNAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesGroupGRPNAMEGet
        /// </summary>
        [Fact]
        public void GeoIpAddressesGroupGRPNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string GRPNAME = null;
            //var response = instance.GeoIpAddressesGroupGRPNAMEGet(GRPNAME);
            //Assert.IsType<GeoIpAddressesCollection>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesGroupGRPNAMEPatch
        /// </summary>
        [Fact]
        public void GeoIpAddressesGroupGRPNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string GRPNAME = null;
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesGroupGRPNAMEPatch(GRPNAME, geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesGroupGRPNAMEPut
        /// </summary>
        [Fact]
        public void GeoIpAddressesGroupGRPNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string GRPNAME = null;
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesGroupGRPNAMEPut(GRPNAME, geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesNameNAMEDelete
        /// </summary>
        [Fact]
        public void GeoIpAddressesNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.GeoIpAddressesNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesNameNAMEGet
        /// </summary>
        [Fact]
        public void GeoIpAddressesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.GeoIpAddressesNameNAMEGet(NAME);
            //Assert.IsType<GeoIpAddressesCollection>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesNameNAMEPatch
        /// </summary>
        [Fact]
        public void GeoIpAddressesNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesNameNAMEPatch(NAME, geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesNameNAMEPut
        /// </summary>
        [Fact]
        public void GeoIpAddressesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesNameNAMEPut(NAME, geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesPatch
        /// </summary>
        [Fact]
        public void GeoIpAddressesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesPatch(geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesPost
        /// </summary>
        [Fact]
        public void GeoIpAddressesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesPost(geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test GeoIpAddressesPut
        /// </summary>
        [Fact]
        public void GeoIpAddressesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GeoIpAddressesCollection? geoIpAddressesCollection = null;
            //var response = instance.GeoIpAddressesPut(geoIpAddressesCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
