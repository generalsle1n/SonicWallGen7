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
    ///  Class for testing UserLocalUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserLocalUserTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserLocalUser
        //private UserLocalUser instance;

        public UserLocalUserTests()
        {
            // TODO uncomment below to create an instance of UserLocalUser
            //instance = new UserLocalUser();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserLocalUser
        /// </summary>
        [Fact]
        public void UserLocalUserInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserLocalUser
            //Assert.IsType<UserLocalUser>(instance);
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
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }

        /// <summary>
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }

        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }

        /// <summary>
        /// Test the property 'ForcePasswordChange'
        /// </summary>
        [Fact]
        public void ForcePasswordChangeTest()
        {
            // TODO unit test for the property 'ForcePasswordChange'
        }

        /// <summary>
        /// Test the property 'OneTimePassword'
        /// </summary>
        [Fact]
        public void OneTimePasswordTest()
        {
            // TODO unit test for the property 'OneTimePassword'
        }

        /// <summary>
        /// Test the property 'AccountLifetime'
        /// </summary>
        [Fact]
        public void AccountLifetimeTest()
        {
            // TODO unit test for the property 'AccountLifetime'
        }

        /// <summary>
        /// Test the property 'Expiration'
        /// </summary>
        [Fact]
        public void ExpirationTest()
        {
            // TODO unit test for the property 'Expiration'
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
        /// Test the property 'QuotaCycle'
        /// </summary>
        [Fact]
        public void QuotaCycleTest()
        {
            // TODO unit test for the property 'QuotaCycle'
        }

        /// <summary>
        /// Test the property 'SessionLifetime'
        /// </summary>
        [Fact]
        public void SessionLifetimeTest()
        {
            // TODO unit test for the property 'SessionLifetime'
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }

        /// <summary>
        /// Test the property 'GuestLoginUniqueness'
        /// </summary>
        [Fact]
        public void GuestLoginUniquenessTest()
        {
            // TODO unit test for the property 'GuestLoginUniqueness'
        }

        /// <summary>
        /// Test the property 'GuestIdleTimeout'
        /// </summary>
        [Fact]
        public void GuestIdleTimeoutTest()
        {
            // TODO unit test for the property 'GuestIdleTimeout'
        }

        /// <summary>
        /// Test the property 'MemberOf'
        /// </summary>
        [Fact]
        public void MemberOfTest()
        {
            // TODO unit test for the property 'MemberOf'
        }

        /// <summary>
        /// Test the property 'VpnClientAccess'
        /// </summary>
        [Fact]
        public void VpnClientAccessTest()
        {
            // TODO unit test for the property 'VpnClientAccess'
        }

        /// <summary>
        /// Test the property 'Bookmark'
        /// </summary>
        [Fact]
        public void BookmarkTest()
        {
            // TODO unit test for the property 'Bookmark'
        }
    }
}
