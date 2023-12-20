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
    ///  Class for testing AddressGroupIpv4Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AddressGroupIpv4ApiTests : IDisposable
    {
        private AddressGroupIpv4Api instance;

        public AddressGroupIpv4ApiTests()
        {
            instance = new AddressGroupIpv4Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AddressGroupIpv4Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AddressGroupIpv4Api
            //Assert.IsType<AddressGroupIpv4Api>(instance);
        }

        /// <summary>
        /// Test AddressGroupsIpv4Get
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AddressGroupsIpv4Get();
            //Assert.IsType<AddressGroupIpv4Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4NameNAMEDelete
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4NameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressGroupsIpv4NameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4NameNAMEGet
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4NameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressGroupsIpv4NameNAMEGet(NAME);
            //Assert.IsType<AddressGroupIpv4Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4NameNAMEPatch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4NameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4NameNAMEPatch(NAME, addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4NameNAMEPut
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4NameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4NameNAMEPut(NAME, addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4Patch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4Patch(addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4Post
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4Post(addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4Put
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4Put(addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4UuidUUIDDelete
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4UuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressGroupsIpv4UuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4UuidUUIDGet
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4UuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressGroupsIpv4UuidUUIDGet(UUID);
            //Assert.IsType<AddressGroupIpv4Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4UuidUUIDPatch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4UuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4UuidUUIDPatch(UUID, addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv4UuidUUIDPut
        /// </summary>
        [Fact]
        public void AddressGroupsIpv4UuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressGroupIpv4Collection? addressGroupIpv4Collection = null;
            //var response = instance.AddressGroupsIpv4UuidUUIDPut(UUID, addressGroupIpv4Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}