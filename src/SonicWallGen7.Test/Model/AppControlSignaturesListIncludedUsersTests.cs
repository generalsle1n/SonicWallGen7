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
    ///  Class for testing AppControlSignaturesListIncludedUsers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppControlSignaturesListIncludedUsersTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppControlSignaturesListIncludedUsers
        //private AppControlSignaturesListIncludedUsers instance;

        public AppControlSignaturesListIncludedUsersTests()
        {
            // TODO uncomment below to create an instance of AppControlSignaturesListIncludedUsers
            //instance = new AppControlSignaturesListIncludedUsers();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppControlSignaturesListIncludedUsers
        /// </summary>
        [Fact]
        public void AppControlSignaturesListIncludedUsersInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppControlSignaturesListIncludedUsers
            //Assert.IsType<AppControlSignaturesListIncludedUsers>(instance);
        }

        /// <summary>
        /// Test the property 'App'
        /// </summary>
        [Fact]
        public void AppTest()
        {
            // TODO unit test for the property 'App'
        }

        /// <summary>
        /// Test the property 'All'
        /// </summary>
        [Fact]
        public void AllTest()
        {
            // TODO unit test for the property 'All'
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
