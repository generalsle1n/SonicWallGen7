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
    ///  Class for testing UserRadiusBaseUserRadius
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserRadiusBaseUserRadiusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserRadiusBaseUserRadius
        //private UserRadiusBaseUserRadius instance;

        public UserRadiusBaseUserRadiusTests()
        {
            // TODO uncomment below to create an instance of UserRadiusBaseUserRadius
            //instance = new UserRadiusBaseUserRadius();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserRadiusBaseUserRadius
        /// </summary>
        [Fact]
        public void UserRadiusBaseUserRadiusInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserRadiusBaseUserRadius
            //Assert.IsType<UserRadiusBaseUserRadius>(instance);
        }

        /// <summary>
        /// Test the property 'LocalUsersOnly'
        /// </summary>
        [Fact]
        public void LocalUsersOnlyTest()
        {
            // TODO unit test for the property 'LocalUsersOnly'
        }

        /// <summary>
        /// Test the property 'DefaultUserGroup'
        /// </summary>
        [Fact]
        public void DefaultUserGroupTest()
        {
            // TODO unit test for the property 'DefaultUserGroup'
        }

        /// <summary>
        /// Test the property 'PeriodicCheckServer'
        /// </summary>
        [Fact]
        public void PeriodicCheckServerTest()
        {
            // TODO unit test for the property 'PeriodicCheckServer'
        }

        /// <summary>
        /// Test the property 'Mschapv2Mode'
        /// </summary>
        [Fact]
        public void Mschapv2ModeTest()
        {
            // TODO unit test for the property 'Mschapv2Mode'
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }

        /// <summary>
        /// Test the property 'Retries'
        /// </summary>
        [Fact]
        public void RetriesTest()
        {
            // TODO unit test for the property 'Retries'
        }

        /// <summary>
        /// Test the property 'UserGroupMechanism'
        /// </summary>
        [Fact]
        public void UserGroupMechanismTest()
        {
            // TODO unit test for the property 'UserGroupMechanism'
        }
    }
}
