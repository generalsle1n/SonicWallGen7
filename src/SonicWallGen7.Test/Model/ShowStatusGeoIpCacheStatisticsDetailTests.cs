/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SonicWallGen7.Model;
using SonicWallGen7.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SonicWallGen7.Test.Model
{
    /// <summary>
    ///  Class for testing ShowStatusGeoIpCacheStatisticsDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusGeoIpCacheStatisticsDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusGeoIpCacheStatisticsDetail
        //private ShowStatusGeoIpCacheStatisticsDetail instance;

        public ShowStatusGeoIpCacheStatisticsDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusGeoIpCacheStatisticsDetail
            //instance = new ShowStatusGeoIpCacheStatisticsDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusGeoIpCacheStatisticsDetail
        /// </summary>
        [Fact]
        public void ShowStatusGeoIpCacheStatisticsDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusGeoIpCacheStatisticsDetail
            //Assert.IsType<ShowStatusGeoIpCacheStatisticsDetail>(instance);
        }

        /// <summary>
        /// Test the property 'LocationServerIp'
        /// </summary>
        [Fact]
        public void LocationServerIpTest()
        {
            // TODO unit test for the property 'LocationServerIp'
        }

        /// <summary>
        /// Test the property 'ResolvedEntries'
        /// </summary>
        [Fact]
        public void ResolvedEntriesTest()
        {
            // TODO unit test for the property 'ResolvedEntries'
        }

        /// <summary>
        /// Test the property 'UnresolvedEntries'
        /// </summary>
        [Fact]
        public void UnresolvedEntriesTest()
        {
            // TODO unit test for the property 'UnresolvedEntries'
        }

        /// <summary>
        /// Test the property 'CurrentEntryCount'
        /// </summary>
        [Fact]
        public void CurrentEntryCountTest()
        {
            // TODO unit test for the property 'CurrentEntryCount'
        }

        /// <summary>
        /// Test the property 'MaxEntryCount'
        /// </summary>
        [Fact]
        public void MaxEntryCountTest()
        {
            // TODO unit test for the property 'MaxEntryCount'
        }

        /// <summary>
        /// Test the property 'LocationMapCount'
        /// </summary>
        [Fact]
        public void LocationMapCountTest()
        {
            // TODO unit test for the property 'LocationMapCount'
        }
    }
}
