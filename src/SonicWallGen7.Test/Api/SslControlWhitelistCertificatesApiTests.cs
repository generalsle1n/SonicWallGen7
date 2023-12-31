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
    ///  Class for testing SslControlWhitelistCertificatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SslControlWhitelistCertificatesApiTests : IDisposable
    {
        private SslControlWhitelistCertificatesApi instance;

        public SslControlWhitelistCertificatesApiTests()
        {
            instance = new SslControlWhitelistCertificatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SslControlWhitelistCertificatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SslControlWhitelistCertificatesApi
            //Assert.IsType<SslControlWhitelistCertificatesApi>(instance);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesCommonNameCNAMEDelete
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesCommonNameCNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string CNAME = null;
            //var response = instance.SslControlWhitelistCertificatesCommonNameCNAMEDelete(CNAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesCommonNameCNAMEGet
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesCommonNameCNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string CNAME = null;
            //var response = instance.SslControlWhitelistCertificatesCommonNameCNAMEGet(CNAME);
            //Assert.IsType<SslControlWhitelistCertificatesCollection>(response);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesCommonNameCNAMEPut
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesCommonNameCNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string CNAME = null;
            //SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null;
            //var response = instance.SslControlWhitelistCertificatesCommonNameCNAMEPut(CNAME, sslControlWhitelistCertificatesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesGet
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SslControlWhitelistCertificatesGet();
            //Assert.IsType<SslControlWhitelistCertificatesCollection>(response);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesPost
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null;
            //var response = instance.SslControlWhitelistCertificatesPost(sslControlWhitelistCertificatesCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SslControlWhitelistCertificatesPut
        /// </summary>
        [Fact]
        public void SslControlWhitelistCertificatesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SslControlWhitelistCertificatesCollection? sslControlWhitelistCertificatesCollection = null;
            //var response = instance.SslControlWhitelistCertificatesPut(sslControlWhitelistCertificatesCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
