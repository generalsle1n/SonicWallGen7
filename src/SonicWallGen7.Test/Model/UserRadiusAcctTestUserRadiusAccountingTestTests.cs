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
    ///  Class for testing UserRadiusAcctTestUserRadiusAccountingTest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserRadiusAcctTestUserRadiusAccountingTestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserRadiusAcctTestUserRadiusAccountingTest
        //private UserRadiusAcctTestUserRadiusAccountingTest instance;

        public UserRadiusAcctTestUserRadiusAccountingTestTests()
        {
            // TODO uncomment below to create an instance of UserRadiusAcctTestUserRadiusAccountingTest
            //instance = new UserRadiusAcctTestUserRadiusAccountingTest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserRadiusAcctTestUserRadiusAccountingTest
        /// </summary>
        [Fact]
        public void UserRadiusAcctTestUserRadiusAccountingTestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserRadiusAcctTestUserRadiusAccountingTest
            //Assert.IsType<UserRadiusAcctTestUserRadiusAccountingTest>(instance);
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
        /// Test the property 'User'
        /// </summary>
        [Fact]
        public void UserTest()
        {
            // TODO unit test for the property 'User'
        }

        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }
    }
}
