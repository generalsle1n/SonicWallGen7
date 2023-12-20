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
    ///  Class for testing AccessRuleIpv4Ipv4Users
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccessRuleIpv4Ipv4UsersTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccessRuleIpv4Ipv4Users
        //private AccessRuleIpv4Ipv4Users instance;

        public AccessRuleIpv4Ipv4UsersTests()
        {
            // TODO uncomment below to create an instance of AccessRuleIpv4Ipv4Users
            //instance = new AccessRuleIpv4Ipv4Users();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccessRuleIpv4Ipv4Users
        /// </summary>
        [Fact]
        public void AccessRuleIpv4Ipv4UsersInstanceTest()
        {
            // TODO uncomment below to test "IsType" AccessRuleIpv4Ipv4Users
            //Assert.IsType<AccessRuleIpv4Ipv4Users>(instance);
        }

        /// <summary>
        /// Test the property 'Included'
        /// </summary>
        [Fact]
        public void IncludedTest()
        {
            // TODO unit test for the property 'Included'
        }

        /// <summary>
        /// Test the property 'Excluded'
        /// </summary>
        [Fact]
        public void ExcludedTest()
        {
            // TODO unit test for the property 'Excluded'
        }
    }
}