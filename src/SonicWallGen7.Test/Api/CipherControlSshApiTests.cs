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
    ///  Class for testing CipherControlSshApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CipherControlSshApiTests : IDisposable
    {
        private CipherControlSshApi instance;

        public CipherControlSshApiTests()
        {
            instance = new CipherControlSshApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CipherControlSshApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CipherControlSshApi
            //Assert.IsType<CipherControlSshApi>(instance);
        }

        /// <summary>
        /// Test CipherControlSshGet
        /// </summary>
        [Fact]
        public void CipherControlSshGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CipherControlSshGet();
            //Assert.IsType<CipherControlSsh>(response);
        }

        /// <summary>
        /// Test CipherControlSshPut
        /// </summary>
        [Fact]
        public void CipherControlSshPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CipherControlSsh? cipherControlSsh = null;
            //var response = instance.CipherControlSshPut(cipherControlSsh);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
