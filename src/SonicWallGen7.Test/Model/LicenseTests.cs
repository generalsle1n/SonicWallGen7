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
    ///  Class for testing License
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LicenseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for License
        //private License instance;

        public LicenseTests()
        {
            // TODO uncomment below to create an instance of License
            //instance = new License();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of License
        /// </summary>
        [Fact]
        public void LicenseInstanceTest()
        {
            // TODO uncomment below to test "IsType" License
            //Assert.IsType<License>(instance);
        }

        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }

        /// <summary>
        /// Test the property 'KeySet'
        /// </summary>
        [Fact]
        public void KeySetTest()
        {
            // TODO unit test for the property 'KeySet'
        }

        /// <summary>
        /// Test the property 'SerialNumber'
        /// </summary>
        [Fact]
        public void SerialNumberTest()
        {
            // TODO unit test for the property 'SerialNumber'
        }

        /// <summary>
        /// Test the property 'AuthenticationCode1'
        /// </summary>
        [Fact]
        public void AuthenticationCode1Test()
        {
            // TODO unit test for the property 'AuthenticationCode1'
        }

        /// <summary>
        /// Test the property 'AuthenticationCode2'
        /// </summary>
        [Fact]
        public void AuthenticationCode2Test()
        {
            // TODO unit test for the property 'AuthenticationCode2'
        }

        /// <summary>
        /// Test the property 'RegistrationCode'
        /// </summary>
        [Fact]
        public void RegistrationCodeTest()
        {
            // TODO unit test for the property 'RegistrationCode'
        }
    }
}
