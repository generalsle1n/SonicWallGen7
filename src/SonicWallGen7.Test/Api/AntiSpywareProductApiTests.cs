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
    ///  Class for testing AntiSpywareProductApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AntiSpywareProductApiTests : IDisposable
    {
        private AntiSpywareProductApi instance;

        public AntiSpywareProductApiTests()
        {
            instance = new AntiSpywareProductApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AntiSpywareProductApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AntiSpywareProductApi
            //Assert.IsType<AntiSpywareProductApi>(instance);
        }

        /// <summary>
        /// Test AntiSpywareProductsGet
        /// </summary>
        [Fact]
        public void AntiSpywareProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AntiSpywareProductsGet();
            //Assert.IsType<AntiSpywareProductCollection>(response);
        }

        /// <summary>
        /// Test AntiSpywareProductsIdIDGet
        /// </summary>
        [Fact]
        public void AntiSpywareProductsIdIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ID = null;
            //var response = instance.AntiSpywareProductsIdIDGet(ID);
            //Assert.IsType<AntiSpywareProductCollection>(response);
        }

        /// <summary>
        /// Test AntiSpywareProductsIdIDPut
        /// </summary>
        [Fact]
        public void AntiSpywareProductsIdIDPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ID = null;
            //AntiSpywareProductCollection? antiSpywareProductCollection = null;
            //var response = instance.AntiSpywareProductsIdIDPut(ID, antiSpywareProductCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AntiSpywareProductsNameNAMEGet
        /// </summary>
        [Fact]
        public void AntiSpywareProductsNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.AntiSpywareProductsNameNAMEGet(NAME);
            //Assert.IsType<AntiSpywareProductCollection>(response);
        }

        /// <summary>
        /// Test AntiSpywareProductsNameNAMEPut
        /// </summary>
        [Fact]
        public void AntiSpywareProductsNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //AntiSpywareProductCollection? antiSpywareProductCollection = null;
            //var response = instance.AntiSpywareProductsNameNAMEPut(NAME, antiSpywareProductCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test AntiSpywareProductsPut
        /// </summary>
        [Fact]
        public void AntiSpywareProductsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AntiSpywareProductCollection? antiSpywareProductCollection = null;
            //var response = instance.AntiSpywareProductsPut(antiSpywareProductCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
