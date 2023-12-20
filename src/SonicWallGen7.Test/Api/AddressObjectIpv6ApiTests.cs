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
    ///  Class for testing AddressObjectIpv6Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AddressObjectIpv6ApiTests : IDisposable
    {
        private AddressObjectIpv6Api instance;

        public AddressObjectIpv6ApiTests()
        {
            instance = new AddressObjectIpv6Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AddressObjectIpv6Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AddressObjectIpv6Api
            //Assert.IsType<AddressObjectIpv6Api>(instance);
        }

        /// <summary>
        /// Test AddressObjectsIpv6Get
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AddressObjectsIpv6Get();
            //Assert.IsType<AddressObjectIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6NameNAMEDelete
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6NameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressObjectsIpv6NameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6NameNAMEGet
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6NameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressObjectsIpv6NameNAMEGet(NAME);
            //Assert.IsType<AddressObjectIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6NameNAMEPatch
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6NameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6NameNAMEPatch(NAME, addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6NameNAMEPut
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6NameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6NameNAMEPut(NAME, addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6Patch
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6Patch(addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6Post
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6Post(addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6Put
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6Put(addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6UuidUUIDDelete
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6UuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressObjectsIpv6UuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6UuidUUIDGet
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6UuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressObjectsIpv6UuidUUIDGet(UUID);
            //Assert.IsType<AddressObjectIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6UuidUUIDPatch
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6UuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6UuidUUIDPatch(UUID, addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressObjectsIpv6UuidUUIDPut
        /// </summary>
        [Fact]
        public void AddressObjectsIpv6UuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressObjectIpv6Collection? addressObjectIpv6Collection = null;
            //var response = instance.AddressObjectsIpv6UuidUUIDPut(UUID, addressObjectIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
