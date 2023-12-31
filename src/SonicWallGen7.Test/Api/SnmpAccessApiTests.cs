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
    ///  Class for testing SnmpAccessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SnmpAccessApiTests : IDisposable
    {
        private SnmpAccessApi instance;

        public SnmpAccessApiTests()
        {
            instance = new SnmpAccessApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SnmpAccessApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SnmpAccessApi
            //Assert.IsType<SnmpAccessApi>(instance);
        }

        /// <summary>
        /// Test SnmpAccessesGet
        /// </summary>
        [Fact]
        public void SnmpAccessesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SnmpAccessesGet();
            //Assert.IsType<SnmpAccessCollection>(response);
        }

        /// <summary>
        /// Test SnmpAccessesNameNAMEDelete
        /// </summary>
        [Fact]
        public void SnmpAccessesNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SnmpAccessesNameNAMEDelete(NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SnmpAccessesNameNAMEGet
        /// </summary>
        [Fact]
        public void SnmpAccessesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.SnmpAccessesNameNAMEGet(NAME);
            //Assert.IsType<SnmpAccessCollection>(response);
        }

        /// <summary>
        /// Test SnmpAccessesNameNAMEPatch
        /// </summary>
        [Fact]
        public void SnmpAccessesNameNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SnmpAccessCollection? snmpAccessCollection = null;
            //var response = instance.SnmpAccessesNameNAMEPatch(NAME, snmpAccessCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SnmpAccessesNameNAMEPut
        /// </summary>
        [Fact]
        public void SnmpAccessesNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //SnmpAccessCollection? snmpAccessCollection = null;
            //var response = instance.SnmpAccessesNameNAMEPut(NAME, snmpAccessCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SnmpAccessesPatch
        /// </summary>
        [Fact]
        public void SnmpAccessesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SnmpAccessCollection? snmpAccessCollection = null;
            //var response = instance.SnmpAccessesPatch(snmpAccessCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SnmpAccessesPost
        /// </summary>
        [Fact]
        public void SnmpAccessesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SnmpAccessCollection? snmpAccessCollection = null;
            //var response = instance.SnmpAccessesPost(snmpAccessCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test SnmpAccessesPut
        /// </summary>
        [Fact]
        public void SnmpAccessesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SnmpAccessCollection? snmpAccessCollection = null;
            //var response = instance.SnmpAccessesPut(snmpAccessCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
