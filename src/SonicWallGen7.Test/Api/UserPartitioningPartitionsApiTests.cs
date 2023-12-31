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
    ///  Class for testing UserPartitioningPartitionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserPartitioningPartitionsApiTests : IDisposable
    {
        private UserPartitioningPartitionsApi instance;

        public UserPartitioningPartitionsApiTests()
        {
            instance = new UserPartitioningPartitionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserPartitioningPartitionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserPartitioningPartitionsApi
            //Assert.IsType<UserPartitioningPartitionsApi>(instance);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsGet
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserPartitioningPartitionsGet();
            //Assert.IsType<UserPartitioningPartitionsCollection>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsNamePNAMEDelete
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsNamePNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string PNAME = null;
            //var response = instance.UserPartitioningPartitionsNamePNAMEDelete(PNAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsNamePNAMEGet
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsNamePNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string PNAME = null;
            //var response = instance.UserPartitioningPartitionsNamePNAMEGet(PNAME);
            //Assert.IsType<UserPartitioningPartitionsCollection>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsNamePNAMEPatch
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsNamePNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string PNAME = null;
            //UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null;
            //var response = instance.UserPartitioningPartitionsNamePNAMEPatch(PNAME, userPartitioningPartitionsCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsNamePNAMEPut
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsNamePNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string PNAME = null;
            //UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null;
            //var response = instance.UserPartitioningPartitionsNamePNAMEPut(PNAME, userPartitioningPartitionsCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsPatch
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null;
            //var response = instance.UserPartitioningPartitionsPatch(userPartitioningPartitionsCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsPost
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null;
            //var response = instance.UserPartitioningPartitionsPost(userPartitioningPartitionsCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test UserPartitioningPartitionsPut
        /// </summary>
        [Fact]
        public void UserPartitioningPartitionsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPartitioningPartitionsCollection? userPartitioningPartitionsCollection = null;
            //var response = instance.UserPartitioningPartitionsPut(userPartitioningPartitionsCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
