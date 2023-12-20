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
    ///  Class for testing AdministrationAdministrationPasswordConstraintsApplyTo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AdministrationAdministrationPasswordConstraintsApplyToTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AdministrationAdministrationPasswordConstraintsApplyTo
        //private AdministrationAdministrationPasswordConstraintsApplyTo instance;

        public AdministrationAdministrationPasswordConstraintsApplyToTests()
        {
            // TODO uncomment below to create an instance of AdministrationAdministrationPasswordConstraintsApplyTo
            //instance = new AdministrationAdministrationPasswordConstraintsApplyTo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdministrationAdministrationPasswordConstraintsApplyTo
        /// </summary>
        [Fact]
        public void AdministrationAdministrationPasswordConstraintsApplyToInstanceTest()
        {
            // TODO uncomment below to test "IsType" AdministrationAdministrationPasswordConstraintsApplyTo
            //Assert.IsType<AdministrationAdministrationPasswordConstraintsApplyTo>(instance);
        }

        /// <summary>
        /// Test the property 'BuiltinAdmin'
        /// </summary>
        [Fact]
        public void BuiltinAdminTest()
        {
            // TODO unit test for the property 'BuiltinAdmin'
        }

        /// <summary>
        /// Test the property 'FullAdmins'
        /// </summary>
        [Fact]
        public void FullAdminsTest()
        {
            // TODO unit test for the property 'FullAdmins'
        }

        /// <summary>
        /// Test the property 'LimitedAdmins'
        /// </summary>
        [Fact]
        public void LimitedAdminsTest()
        {
            // TODO unit test for the property 'LimitedAdmins'
        }

        /// <summary>
        /// Test the property 'LocalUsers'
        /// </summary>
        [Fact]
        public void LocalUsersTest()
        {
            // TODO unit test for the property 'LocalUsers'
        }

        /// <summary>
        /// Test the property 'GuestAdmins'
        /// </summary>
        [Fact]
        public void GuestAdminsTest()
        {
            // TODO unit test for the property 'GuestAdmins'
        }

        /// <summary>
        /// Test the property 'SystemAdmins'
        /// </summary>
        [Fact]
        public void SystemAdminsTest()
        {
            // TODO unit test for the property 'SystemAdmins'
        }

        /// <summary>
        /// Test the property 'CryptoAdmins'
        /// </summary>
        [Fact]
        public void CryptoAdminsTest()
        {
            // TODO unit test for the property 'CryptoAdmins'
        }

        /// <summary>
        /// Test the property 'AuditAdmins'
        /// </summary>
        [Fact]
        public void AuditAdminsTest()
        {
            // TODO unit test for the property 'AuditAdmins'
        }
    }
}
