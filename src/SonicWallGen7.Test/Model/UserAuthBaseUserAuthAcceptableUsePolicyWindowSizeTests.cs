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
    ///  Class for testing UserAuthBaseUserAuthAcceptableUsePolicyWindowSize
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserAuthBaseUserAuthAcceptableUsePolicyWindowSizeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAuthBaseUserAuthAcceptableUsePolicyWindowSize
        //private UserAuthBaseUserAuthAcceptableUsePolicyWindowSize instance;

        public UserAuthBaseUserAuthAcceptableUsePolicyWindowSizeTests()
        {
            // TODO uncomment below to create an instance of UserAuthBaseUserAuthAcceptableUsePolicyWindowSize
            //instance = new UserAuthBaseUserAuthAcceptableUsePolicyWindowSize();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAuthBaseUserAuthAcceptableUsePolicyWindowSize
        /// </summary>
        [Fact]
        public void UserAuthBaseUserAuthAcceptableUsePolicyWindowSizeInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAuthBaseUserAuthAcceptableUsePolicyWindowSize
            //Assert.IsType<UserAuthBaseUserAuthAcceptableUsePolicyWindowSize>(instance);
        }

        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Fact]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }

        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Fact]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
    }
}