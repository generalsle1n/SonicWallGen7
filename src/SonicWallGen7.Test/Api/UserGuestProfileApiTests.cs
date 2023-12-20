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
    ///  Class for testing UserGuestProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserGuestProfileApiTests : IDisposable
    {
        private UserGuestProfileApi instance;

        public UserGuestProfileApiTests()
        {
            instance = new UserGuestProfileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserGuestProfileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserGuestProfileApi
            //Assert.IsType<UserGuestProfileApi>(instance);
        }

        /// <summary>
        /// Test UserGuestProfilesGet
        /// </summary>
        [Fact]
        public void UserGuestProfilesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGuestProfilesGet();
            //Assert.IsType<UserGuestProfileCollection>(response);
        }

        /// <summary>
        /// Test UserGuestProfilesNameNAMEDelete
        /// </summary>
        [Fact]
        public void UserGuestProfilesNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserGuestProfilesNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserGuestProfilesNameNAMEGet
        /// </summary>
        [Fact]
        public void UserGuestProfilesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.UserGuestProfilesNameNAMEGet(NAME);
            //Assert.IsType<UserGuestProfileCollection>(response);
        }

        /// <summary>
        /// Test UserGuestProfilesNameNAMEPut
        /// </summary>
        [Fact]
        public void UserGuestProfilesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //UserGuestProfileCollection? userGuestProfileCollection = null;
            //var response = instance.UserGuestProfilesNameNAMEPut(NAME, userGuestProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserGuestProfilesPost
        /// </summary>
        [Fact]
        public void UserGuestProfilesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserGuestProfileCollection? userGuestProfileCollection = null;
            //var response = instance.UserGuestProfilesPost(userGuestProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserGuestProfilesPut
        /// </summary>
        [Fact]
        public void UserGuestProfilesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserGuestProfileCollection? userGuestProfileCollection = null;
            //var response = instance.UserGuestProfilesPut(userGuestProfileCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}