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
    ///  Class for testing AccessRuleIpv4Ipv4SourcePort
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccessRuleIpv4Ipv4SourcePortTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccessRuleIpv4Ipv4SourcePort
        //private AccessRuleIpv4Ipv4SourcePort instance;

        public AccessRuleIpv4Ipv4SourcePortTests()
        {
            // TODO uncomment below to create an instance of AccessRuleIpv4Ipv4SourcePort
            //instance = new AccessRuleIpv4Ipv4SourcePort();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccessRuleIpv4Ipv4SourcePort
        /// </summary>
        [Fact]
        public void AccessRuleIpv4Ipv4SourcePortInstanceTest()
        {
            // TODO uncomment below to test "IsType" AccessRuleIpv4Ipv4SourcePort
            //Assert.IsType<AccessRuleIpv4Ipv4SourcePort>(instance);
        }

        /// <summary>
        /// Test the property 'Any'
        /// </summary>
        [Fact]
        public void AnyTest()
        {
            // TODO unit test for the property 'Any'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Fact]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }
    }
}
