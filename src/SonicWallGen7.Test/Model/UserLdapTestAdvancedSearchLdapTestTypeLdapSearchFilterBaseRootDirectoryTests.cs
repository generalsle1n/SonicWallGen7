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
    ///  Class for testing UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectoryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory
        //private UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory instance;

        public UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectoryTests()
        {
            // TODO uncomment below to create an instance of UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory
            //instance = new UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory
        /// </summary>
        [Fact]
        public void UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectoryInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory
            //Assert.IsType<UserLdapTestAdvancedSearchLdapTestTypeLdapSearchFilterBaseRootDirectory>(instance);
        }

        /// <summary>
        /// Test the property 'RootDirectory'
        /// </summary>
        [Fact]
        public void RootDirectoryTest()
        {
            // TODO unit test for the property 'RootDirectory'
        }
    }
}
