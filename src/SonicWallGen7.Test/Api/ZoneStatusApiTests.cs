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
    ///  Class for testing ZoneStatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ZoneStatusApiTests : IDisposable
    {
        private ZoneStatusApi instance;

        public ZoneStatusApiTests()
        {
            instance = new ZoneStatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZoneStatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ZoneStatusApi
            //Assert.IsType<ZoneStatusApi>(instance);
        }

        /// <summary>
        /// Test ReportingZonesGet
        /// </summary>
        [Fact]
        public void ReportingZonesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ReportingZonesGet();
            //Assert.IsType<List<ShowStatusZoneStatusListInner>>(response);
        }

        /// <summary>
        /// Test ReportingZonesNameNAMEGet
        /// </summary>
        [Fact]
        public void ReportingZonesNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string NAME = null;
            //var response = instance.ReportingZonesNameNAMEGet(NAME);
            //Assert.IsType<List<ShowStatusZoneStatusListInner>>(response);
        }

        /// <summary>
        /// Test ReportingZonesUuidUUIDGet
        /// </summary>
        [Fact]
        public void ReportingZonesUuidUUIDGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //var response = instance.ReportingZonesUuidUUIDGet(UUID);
            //Assert.IsType<List<ShowStatusZoneStatusListInner>>(response);
        }
    }
}
