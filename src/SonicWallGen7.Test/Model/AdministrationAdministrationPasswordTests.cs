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
    ///  Class for testing AdministrationAdministrationPassword
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdministrationAdministrationPasswordTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdministrationAdministrationPassword
        //private AdministrationAdministrationPassword instance;

        public AdministrationAdministrationPasswordTests()
        {
            // TODO uncomment below to create an instance of AdministrationAdministrationPassword
            //instance = new AdministrationAdministrationPassword();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdministrationAdministrationPassword
        /// </summary>
        [Fact]
        public void AdministrationAdministrationPasswordInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdministrationAdministrationPassword
            //Assert.IsType<AdministrationAdministrationPassword>(instance);
        }

        /// <summary>
        /// Test the property 'Aging'
        /// </summary>
        [Fact]
        public void AgingTest()
        {
            // TODO unit test for the property 'Aging'
        }

        /// <summary>
        /// Test the property 'LastChanged'
        /// </summary>
        [Fact]
        public void LastChangedTest()
        {
            // TODO unit test for the property 'LastChanged'
        }

        /// <summary>
        /// Test the property 'Uniqueness'
        /// </summary>
        [Fact]
        public void UniquenessTest()
        {
            // TODO unit test for the property 'Uniqueness'
        }

        /// <summary>
        /// Test the property 'EnforceCharacterDifference'
        /// </summary>
        [Fact]
        public void EnforceCharacterDifferenceTest()
        {
            // TODO unit test for the property 'EnforceCharacterDifference'
        }

        /// <summary>
        /// Test the property 'MinimumLength'
        /// </summary>
        [Fact]
        public void MinimumLengthTest()
        {
            // TODO unit test for the property 'MinimumLength'
        }

        /// <summary>
        /// Test the property 'Complexity'
        /// </summary>
        [Fact]
        public void ComplexityTest()
        {
            // TODO unit test for the property 'Complexity'
        }

        /// <summary>
        /// Test the property 'ConstraintsApplyTo'
        /// </summary>
        [Fact]
        public void ConstraintsApplyToTest()
        {
            // TODO unit test for the property 'ConstraintsApplyTo'
        }
    }
}
