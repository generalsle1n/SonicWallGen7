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
    ///  Class for testing UserLocalGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserLocalGroupApiTests : IDisposable
    {
        private UserLocalGroupApi instance;

        public UserLocalGroupApiTests()
        {
            instance = new UserLocalGroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserLocalGroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserLocalGroupApi
            //Assert.IsType<UserLocalGroupApi>(instance);
        }

        /// <summary>
        /// Test UserLocalGroupsGet
        /// </summary>
        [Fact]
        public void UserLocalGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserLocalGroupsGet();
            //Assert.IsType<UserLocalGroupCollection>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsNameNAMEDomainDNAMEDelete
        /// </summary>
        [Fact]
        public void UserLocalGroupsNameNAMEDomainDNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //string DNAME = null;
            //var response = instance.UserLocalGroupsNameNAMEDomainDNAMEDelete(NAME, DNAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsNameNAMEDomainDNAMEGet
        /// </summary>
        [Fact]
        public void UserLocalGroupsNameNAMEDomainDNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //string DNAME = null;
            //var response = instance.UserLocalGroupsNameNAMEDomainDNAMEGet(NAME, DNAME);
            //Assert.IsType<UserLocalGroupCollection>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsNameNAMEDomainDNAMEPatch
        /// </summary>
        [Fact]
        public void UserLocalGroupsNameNAMEDomainDNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //string DNAME = null;
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsNameNAMEDomainDNAMEPatch(NAME, DNAME, userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsNameNAMEDomainDNAMEPut
        /// </summary>
        [Fact]
        public void UserLocalGroupsNameNAMEDomainDNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //string DNAME = null;
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsNameNAMEDomainDNAMEPut(NAME, DNAME, userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsPatch
        /// </summary>
        [Fact]
        public void UserLocalGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsPatch(userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsPost
        /// </summary>
        [Fact]
        public void UserLocalGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsPost(userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsPut
        /// </summary>
        [Fact]
        public void UserLocalGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsPut(userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsUuidUUIDDelete
        /// </summary>
        [Fact]
        public void UserLocalGroupsUuidUUIDDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.UserLocalGroupsUuidUUIDDelete(UUID);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsUuidUUIDGet
        /// </summary>
        [Fact]
        public void UserLocalGroupsUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.UserLocalGroupsUuidUUIDGet(UUID);
            //Assert.IsType<UserLocalGroupCollection>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsUuidUUIDPatch
        /// </summary>
        [Fact]
        public void UserLocalGroupsUuidUUIDPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsUuidUUIDPatch(UUID, userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserLocalGroupsUuidUUIDPut
        /// </summary>
        [Fact]
        public void UserLocalGroupsUuidUUIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //UserLocalGroupCollection? userLocalGroupCollection = null;
            //var response = instance.UserLocalGroupsUuidUUIDPut(UUID, userLocalGroupCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
