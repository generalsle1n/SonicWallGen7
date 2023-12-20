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
    ///  Class for testing UserTacacsAccountingServerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserTacacsAccountingServerApiTests : IDisposable
    {
        private UserTacacsAccountingServerApi instance;

        public UserTacacsAccountingServerApiTests()
        {
            instance = new UserTacacsAccountingServerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserTacacsAccountingServerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserTacacsAccountingServerApi
            //Assert.IsType<UserTacacsAccountingServerApi>(instance);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersGet
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserTacacsAccountingServersGet();
            //Assert.IsType<UserTacacsAccountingServerCollection>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersNameNAMEDelete
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserTacacsAccountingServersNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersNameNAMEGet
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserTacacsAccountingServersNameNAMEGet(NAME);
            //Assert.IsType<UserTacacsAccountingServerCollection>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersNameNAMEPatch
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null;
            //var response = instance.UserTacacsAccountingServersNameNAMEPatch(NAME, userTacacsAccountingServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersNameNAMEPut
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null;
            //var response = instance.UserTacacsAccountingServersNameNAMEPut(NAME, userTacacsAccountingServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersPatch
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null;
            //var response = instance.UserTacacsAccountingServersPatch(userTacacsAccountingServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersPost
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null;
            //var response = instance.UserTacacsAccountingServersPost(userTacacsAccountingServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserTacacsAccountingServersPut
        /// </summary>
        [Fact]
        public void UserTacacsAccountingServersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserTacacsAccountingServerCollection? userTacacsAccountingServerCollection = null;
            //var response = instance.UserTacacsAccountingServersPut(userTacacsAccountingServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
