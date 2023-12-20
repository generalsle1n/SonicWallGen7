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
    ///  Class for testing UserLocalBaseUserLocal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserLocalBaseUserLocalTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserLocalBaseUserLocal
        //private UserLocalBaseUserLocal instance;

        public UserLocalBaseUserLocalTests()
        {
            // TODO uncomment below to create an instance of UserLocalBaseUserLocal
            //instance = new UserLocalBaseUserLocal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserLocalBaseUserLocal
        /// </summary>
        [Fact]
        public void UserLocalBaseUserLocalInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserLocalBaseUserLocal
            //Assert.IsType<UserLocalBaseUserLocal>(instance);
        }

        /// <summary>
        /// Test the property 'ApplyPasswordConstraints'
        /// </summary>
        [Fact]
        public void ApplyPasswordConstraintsTest()
        {
            // TODO unit test for the property 'ApplyPasswordConstraints'
        }

        /// <summary>
        /// Test the property 'PruneOnExpiry'
        /// </summary>
        [Fact]
        public void PruneOnExpiryTest()
        {
            // TODO unit test for the property 'PruneOnExpiry'
        }

        /// <summary>
        /// Test the property 'InactivityTimeout'
        /// </summary>
        [Fact]
        public void InactivityTimeoutTest()
        {
            // TODO unit test for the property 'InactivityTimeout'
        }

        /// <summary>
        /// Test the property 'PruneOnInactive'
        /// </summary>
        [Fact]
        public void PruneOnInactiveTest()
        {
            // TODO unit test for the property 'PruneOnInactive'
        }

        /// <summary>
        /// Test the property 'DomainNameDisplayFormat'
        /// </summary>
        [Fact]
        public void DomainNameDisplayFormatTest()
        {
            // TODO unit test for the property 'DomainNameDisplayFormat'
        }
    }
}