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
    ///  Class for testing MacIpAntiSpoofIpv4Collection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MacIpAntiSpoofIpv4CollectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MacIpAntiSpoofIpv4Collection
        //private MacIpAntiSpoofIpv4Collection instance;

        public MacIpAntiSpoofIpv4CollectionTests()
        {
            // TODO uncomment below to create an instance of MacIpAntiSpoofIpv4Collection
            //instance = new MacIpAntiSpoofIpv4Collection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MacIpAntiSpoofIpv4Collection
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofIpv4CollectionInstanceTest()
        {
            // TODO uncomment below to test "IsType" MacIpAntiSpoofIpv4Collection
            //Assert.IsType<MacIpAntiSpoofIpv4Collection>(instance);
        }

        /// <summary>
        /// Test the property 'MacIpAntiSpoof'
        /// </summary>
        [Fact]
        public void MacIpAntiSpoofTest()
        {
            // TODO unit test for the property 'MacIpAntiSpoof'
        }
    }
}
