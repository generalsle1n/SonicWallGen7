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
    ///  Class for testing UserLdapBaseUserLdap
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserLdapBaseUserLdapTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserLdapBaseUserLdap
        //private UserLdapBaseUserLdap instance;

        public UserLdapBaseUserLdapTests()
        {
            // TODO uncomment below to create an instance of UserLdapBaseUserLdap
            //instance = new UserLdapBaseUserLdap();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserLdapBaseUserLdap
        /// </summary>
        [Fact]
        public void UserLdapBaseUserLdapInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserLdapBaseUserLdap
            //Assert.IsType<UserLdapBaseUserLdap>(instance);
        }

        /// <summary>
        /// Test the property 'ProtocolVersion'
        /// </summary>
        [Fact]
        public void ProtocolVersionTest()
        {
            // TODO unit test for the property 'ProtocolVersion'
        }

        /// <summary>
        /// Test the property 'RequireValidCertificate'
        /// </summary>
        [Fact]
        public void RequireValidCertificateTest()
        {
            // TODO unit test for the property 'RequireValidCertificate'
        }

        /// <summary>
        /// Test the property 'LocalTlsCertificate'
        /// </summary>
        [Fact]
        public void LocalTlsCertificateTest()
        {
            // TODO unit test for the property 'LocalTlsCertificate'
        }

        /// <summary>
        /// Test the property 'AllowReferrals'
        /// </summary>
        [Fact]
        public void AllowReferralsTest()
        {
            // TODO unit test for the property 'AllowReferrals'
        }

        /// <summary>
        /// Test the property 'AllowReferences'
        /// </summary>
        [Fact]
        public void AllowReferencesTest()
        {
            // TODO unit test for the property 'AllowReferences'
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
        /// Test the property 'CheckDeletedGroupsMethod'
        /// </summary>
        [Fact]
        public void CheckDeletedGroupsMethodTest()
        {
            // TODO unit test for the property 'CheckDeletedGroupsMethod'
        }

        /// <summary>
        /// Test the property 'MirrorUserGroups'
        /// </summary>
        [Fact]
        public void MirrorUserGroupsTest()
        {
            // TODO unit test for the property 'MirrorUserGroups'
        }

        /// <summary>
        /// Test the property 'DelMirroredUserGroups'
        /// </summary>
        [Fact]
        public void DelMirroredUserGroupsTest()
        {
            // TODO unit test for the property 'DelMirroredUserGroups'
        }

        /// <summary>
        /// Test the property 'Relay'
        /// </summary>
        [Fact]
        public void RelayTest()
        {
            // TODO unit test for the property 'Relay'
        }
    }
}