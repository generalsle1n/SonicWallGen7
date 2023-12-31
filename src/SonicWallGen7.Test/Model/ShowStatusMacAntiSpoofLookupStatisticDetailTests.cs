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
    ///  Class for testing ShowStatusMacAntiSpoofLookupStatisticDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusMacAntiSpoofLookupStatisticDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusMacAntiSpoofLookupStatisticDetail
        //private ShowStatusMacAntiSpoofLookupStatisticDetail instance;

        public ShowStatusMacAntiSpoofLookupStatisticDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusMacAntiSpoofLookupStatisticDetail
            //instance = new ShowStatusMacAntiSpoofLookupStatisticDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusMacAntiSpoofLookupStatisticDetail
        /// </summary>
        [Fact]
        public void ShowStatusMacAntiSpoofLookupStatisticDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusMacAntiSpoofLookupStatisticDetail
            //Assert.IsType<ShowStatusMacAntiSpoofLookupStatisticDetail>(instance);
        }

        /// <summary>
        /// Test the property 'Entries'
        /// </summary>
        [Fact]
        public void EntriesTest()
        {
            // TODO unit test for the property 'Entries'
        }

        /// <summary>
        /// Test the property 'Lookups'
        /// </summary>
        [Fact]
        public void LookupsTest()
        {
            // TODO unit test for the property 'Lookups'
        }

        /// <summary>
        /// Test the property 'Passed'
        /// </summary>
        [Fact]
        public void PassedTest()
        {
            // TODO unit test for the property 'Passed'
        }

        /// <summary>
        /// Test the property 'Dropped'
        /// </summary>
        [Fact]
        public void DroppedTest()
        {
            // TODO unit test for the property 'Dropped'
        }

        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [Fact]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
        }

        /// <summary>
        /// Test the property 'PassedToUs'
        /// </summary>
        [Fact]
        public void PassedToUsTest()
        {
            // TODO unit test for the property 'PassedToUs'
        }
    }
}
