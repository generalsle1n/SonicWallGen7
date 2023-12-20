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
    ///  Class for testing AddressGroupIpv6Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AddressGroupIpv6ApiTests : IDisposable
    {
        private AddressGroupIpv6Api instance;

        public AddressGroupIpv6ApiTests()
        {
            instance = new AddressGroupIpv6Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AddressGroupIpv6Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AddressGroupIpv6Api
            //Assert.IsType<AddressGroupIpv6Api>(instance);
        }

        /// <summary>
        /// Test AddressGroupsIpv6Get
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AddressGroupsIpv6Get();
            //Assert.IsType<AddressGroupIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6NameNAMEDelete
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6NameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressGroupsIpv6NameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6NameNAMEGet
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6NameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AddressGroupsIpv6NameNAMEGet(NAME);
            //Assert.IsType<AddressGroupIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6NameNAMEPatch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6NameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6NameNAMEPatch(NAME, addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6NameNAMEPut
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6NameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6NameNAMEPut(NAME, addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6Patch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6PatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6Patch(addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6Post
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6Post(addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6Put
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6PutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6Put(addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6UuidUUIDDelete
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6UuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressGroupsIpv6UuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6UuidUUIDGet
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6UuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.AddressGroupsIpv6UuidUUIDGet(UUID);
            //Assert.IsType<AddressGroupIpv6Collection>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6UuidUUIDPatch
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6UuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6UuidUUIDPatch(UUID, addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AddressGroupsIpv6UuidUUIDPut
        /// </summary>
        [Fact]
        public void AddressGroupsIpv6UuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //AddressGroupIpv6Collection? addressGroupIpv6Collection = null;
            //var response = instance.AddressGroupsIpv6UuidUUIDPut(UUID, addressGroupIpv6Collection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
