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
    ///  Class for testing SecurityActionProfilesUserActions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SecurityActionProfilesUserActionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecurityActionProfilesUserActions
        //private SecurityActionProfilesUserActions instance;

        public SecurityActionProfilesUserActionsTests()
        {
            // TODO uncomment below to create an instance of SecurityActionProfilesUserActions
            //instance = new SecurityActionProfilesUserActions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityActionProfilesUserActions
        /// </summary>
        [Fact]
        public void SecurityActionProfilesUserActionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" SecurityActionProfilesUserActions
            //Assert.IsType<SecurityActionProfilesUserActions>(instance);
        }

        /// <summary>
        /// Test the property 'BlockPage'
        /// </summary>
        [Fact]
        public void BlockPageTest()
        {
            // TODO unit test for the property 'BlockPage'
        }

        /// <summary>
        /// Test the property 'BlockDetails'
        /// </summary>
        [Fact]
        public void BlockDetailsTest()
        {
            // TODO unit test for the property 'BlockDetails'
        }

        /// <summary>
        /// Test the property 'BypassSso'
        /// </summary>
        [Fact]
        public void BypassSsoTest()
        {
            // TODO unit test for the property 'BypassSso'
        }
    }
}
