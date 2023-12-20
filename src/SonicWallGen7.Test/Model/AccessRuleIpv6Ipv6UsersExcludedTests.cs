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
    ///  Class for testing AccessRuleIpv6Ipv6UsersExcluded
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccessRuleIpv6Ipv6UsersExcludedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccessRuleIpv6Ipv6UsersExcluded
        //private AccessRuleIpv6Ipv6UsersExcluded instance;

        public AccessRuleIpv6Ipv6UsersExcludedTests()
        {
            // TODO uncomment below to create an instance of AccessRuleIpv6Ipv6UsersExcluded
            //instance = new AccessRuleIpv6Ipv6UsersExcluded();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccessRuleIpv6Ipv6UsersExcluded
        /// </summary>
        [Fact]
        public void AccessRuleIpv6Ipv6UsersExcludedInstanceTest()
        {
            // TODO uncomment below to test "IsType" AccessRuleIpv6Ipv6UsersExcluded
            //Assert.IsType<AccessRuleIpv6Ipv6UsersExcluded>(instance);
        }

        /// <summary>
        /// Test the property 'None'
        /// </summary>
        [Fact]
        public void NoneTest()
        {
            // TODO unit test for the property 'None'
        }

        /// <summary>
        /// Test the property 'Guests'
        /// </summary>
        [Fact]
        public void GuestsTest()
        {
            // TODO unit test for the property 'Guests'
        }

        /// <summary>
        /// Test the property 'Administrator'
        /// </summary>
        [Fact]
        public void AdministratorTest()
        {
            // TODO unit test for the property 'Administrator'
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