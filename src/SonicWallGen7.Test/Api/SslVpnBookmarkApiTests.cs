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
    ///  Class for testing SslVpnBookmarkApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SslVpnBookmarkApiTests : IDisposable
    {
        private SslVpnBookmarkApi instance;

        public SslVpnBookmarkApiTests()
        {
            instance = new SslVpnBookmarkApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SslVpnBookmarkApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SslVpnBookmarkApi
            //Assert.IsType<SslVpnBookmarkApi>(instance);
        }

        /// <summary>
        /// Test SslVpnBookmarksGet
        /// </summary>
        [Fact]
        public void SslVpnBookmarksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SslVpnBookmarksGet();
            //Assert.IsType<SslVpnBookmarkCollection>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksNameNAMEDelete
        /// </summary>
        [Fact]
        public void SslVpnBookmarksNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SslVpnBookmarksNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksNameNAMEGet
        /// </summary>
        [Fact]
        public void SslVpnBookmarksNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SslVpnBookmarksNameNAMEGet(NAME);
            //Assert.IsType<SslVpnBookmarkCollection>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksNameNAMEPatch
        /// </summary>
        [Fact]
        public void SslVpnBookmarksNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SslVpnBookmarkCollection? sslVpnBookmarkCollection = null;
            //var response = instance.SslVpnBookmarksNameNAMEPatch(NAME, sslVpnBookmarkCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksNameNAMEPut
        /// </summary>
        [Fact]
        public void SslVpnBookmarksNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SslVpnBookmarkCollection? sslVpnBookmarkCollection = null;
            //var response = instance.SslVpnBookmarksNameNAMEPut(NAME, sslVpnBookmarkCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksPatch
        /// </summary>
        [Fact]
        public void SslVpnBookmarksPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SslVpnBookmarkCollection? sslVpnBookmarkCollection = null;
            //var response = instance.SslVpnBookmarksPatch(sslVpnBookmarkCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksPost
        /// </summary>
        [Fact]
        public void SslVpnBookmarksPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SslVpnBookmarkCollection? sslVpnBookmarkCollection = null;
            //var response = instance.SslVpnBookmarksPost(sslVpnBookmarkCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslVpnBookmarksPut
        /// </summary>
        [Fact]
        public void SslVpnBookmarksPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SslVpnBookmarkCollection? sslVpnBookmarkCollection = null;
            //var response = instance.SslVpnBookmarksPut(sslVpnBookmarkCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
