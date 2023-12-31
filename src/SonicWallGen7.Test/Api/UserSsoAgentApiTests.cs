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
    ///  Class for testing UserSsoAgentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserSsoAgentApiTests : IDisposable
    {
        private UserSsoAgentApi instance;

        public UserSsoAgentApiTests()
        {
            instance = new UserSsoAgentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserSsoAgentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserSsoAgentApi
            //Assert.IsType<UserSsoAgentApi>(instance);
        }

        /// <summary>
        /// Test UserSsoAgentsGet
        /// </summary>
        [Fact]
        public void UserSsoAgentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserSsoAgentsGet();
            //Assert.IsType<UserSsoAgentCollection>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsNameNAMEDelete
        /// </summary>
        [Fact]
        public void UserSsoAgentsNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserSsoAgentsNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsNameNAMEGet
        /// </summary>
        [Fact]
        public void UserSsoAgentsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserSsoAgentsNameNAMEGet(NAME);
            //Assert.IsType<UserSsoAgentCollection>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsNameNAMEPatch
        /// </summary>
        [Fact]
        public void UserSsoAgentsNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //UserSsoAgentCollection? userSsoAgentCollection = null;
            //var response = instance.UserSsoAgentsNameNAMEPatch(NAME, userSsoAgentCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsNameNAMEPut
        /// </summary>
        [Fact]
        public void UserSsoAgentsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //UserSsoAgentCollection? userSsoAgentCollection = null;
            //var response = instance.UserSsoAgentsNameNAMEPut(NAME, userSsoAgentCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsPatch
        /// </summary>
        [Fact]
        public void UserSsoAgentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSsoAgentCollection? userSsoAgentCollection = null;
            //var response = instance.UserSsoAgentsPatch(userSsoAgentCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsPost
        /// </summary>
        [Fact]
        public void UserSsoAgentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSsoAgentCollection? userSsoAgentCollection = null;
            //var response = instance.UserSsoAgentsPost(userSsoAgentCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserSsoAgentsPut
        /// </summary>
        [Fact]
        public void UserSsoAgentsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSsoAgentCollection? userSsoAgentCollection = null;
            //var response = instance.UserSsoAgentsPut(userSsoAgentCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
