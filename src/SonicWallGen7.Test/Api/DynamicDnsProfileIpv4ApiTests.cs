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
    ///  Class for testing DynamicSonicDnsProfileIpv4Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DynamicSonicDnsProfileIpv4ApiTests : IDisposable
    {
        private DynamicSonicDnsProfileIpv4Api instance;

        public DynamicSonicDnsProfileIpv4ApiTests()
        {
            instance = new DynamicSonicDnsProfileIpv4Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DynamicSonicDnsProfileIpv4Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DynamicSonicDnsProfileIpv4Api
            //Assert.IsType<DynamicSonicDnsProfileIpv4Api>(instance);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4Get
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DynamicSonicDnsProfilesIpv4Get();
            //Assert.IsType<DynamicSonicDnsProfileIpv4Collection>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4NameNAMEDelete
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4NameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4NameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4NameNAMEGet
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4NameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4NameNAMEGet(NAME);
            //Assert.IsType<DynamicSonicDnsProfileIpv4Collection>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4NameNAMEPatch
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4NameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //DynamicSonicDnsProfileIpv4Collection? dynamicSonicDnsProfileIpv4Collection = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4NameNAMEPatch(NAME, dynamicSonicDnsProfileIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4NameNAMEPut
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4NameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //DynamicSonicDnsProfileIpv4Collection? dynamicSonicDnsProfileIpv4Collection = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4NameNAMEPut(NAME, dynamicSonicDnsProfileIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4Patch
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicSonicDnsProfileIpv4Collection? dynamicSonicDnsProfileIpv4Collection = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4Patch(dynamicSonicDnsProfileIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4Post
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicSonicDnsProfileIpv4Collection? dynamicSonicDnsProfileIpv4Collection = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4Post(dynamicSonicDnsProfileIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test DynamicSonicDnsProfilesIpv4Put
        /// </summary>
        [Fact]
        public void DynamicSonicDnsProfilesIpv4PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicSonicDnsProfileIpv4Collection? dynamicSonicDnsProfileIpv4Collection = null;
            //var response = instance.DynamicSonicDnsProfilesIpv4Put(dynamicSonicDnsProfileIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
