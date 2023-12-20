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
    ///  Class for testing UserRadiusAccountingServerUserNameFormat
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserRadiusAccountingServerUserNameFormatTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserRadiusAccountingServerUserNameFormat
        //private UserRadiusAccountingServerUserNameFormat instance;

        public UserRadiusAccountingServerUserNameFormatTests()
        {
            // TODO uncomment below to create an instance of UserRadiusAccountingServerUserNameFormat
            //instance = new UserRadiusAccountingServerUserNameFormat();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserRadiusAccountingServerUserNameFormat
        /// </summary>
        [Fact]
        public void UserRadiusAccountingServerUserNameFormatInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserRadiusAccountingServerUserNameFormat
            //Assert.IsType<UserRadiusAccountingServerUserNameFormat>(instance);
        }

        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

        /// <summary>
        /// Test the property 'UserPrinciple'
        /// </summary>
        [Fact]
        public void UserPrincipleTest()
        {
            // TODO unit test for the property 'UserPrinciple'
        }

        /// <summary>
        /// Test the property 'DownLevelLogon'
        /// </summary>
        [Fact]
        public void DownLevelLogonTest()
        {
            // TODO unit test for the property 'DownLevelLogon'
        }

        /// <summary>
        /// Test the property 'NameDotDomain'
        /// </summary>
        [Fact]
        public void NameDotDomainTest()
        {
            // TODO unit test for the property 'NameDotDomain'
        }
    }
}
