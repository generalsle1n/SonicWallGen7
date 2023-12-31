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
    ///  Class for testing ShowStatusUserGuestUserDetailListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusUserGuestUserDetailListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusUserGuestUserDetailListInner
        //private ShowStatusUserGuestUserDetailListInner instance;

        public ShowStatusUserGuestUserDetailListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusUserGuestUserDetailListInner
            //instance = new ShowStatusUserGuestUserDetailListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusUserGuestUserDetailListInner
        /// </summary>
        [Fact]
        public void ShowStatusUserGuestUserDetailListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusUserGuestUserDetailListInner
            //Assert.IsType<ShowStatusUserGuestUserDetailListInner>(instance);
        }

        /// <summary>
        /// Test the property 'AccountName'
        /// </summary>
        [Fact]
        public void AccountNameTest()
        {
            // TODO unit test for the property 'AccountName'
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
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
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
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }

        /// <summary>
        /// Test the property 'AccountExpires'
        /// </summary>
        [Fact]
        public void AccountExpiresTest()
        {
            // TODO unit test for the property 'AccountExpires'
        }

        /// <summary>
        /// Test the property 'AccountLeftLifetime'
        /// </summary>
        [Fact]
        public void AccountLeftLifetimeTest()
        {
            // TODO unit test for the property 'AccountLeftLifetime'
        }

        /// <summary>
        /// Test the property 'SessionExpires'
        /// </summary>
        [Fact]
        public void SessionExpiresTest()
        {
            // TODO unit test for the property 'SessionExpires'
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
        /// Test the property 'IdleTimeout'
        /// </summary>
        [Fact]
        public void IdleTimeoutTest()
        {
            // TODO unit test for the property 'IdleTimeout'
        }

        /// <summary>
        /// Test the property 'ReceiveLimit'
        /// </summary>
        [Fact]
        public void ReceiveLimitTest()
        {
            // TODO unit test for the property 'ReceiveLimit'
        }

        /// <summary>
        /// Test the property 'TransmitLimit'
        /// </summary>
        [Fact]
        public void TransmitLimitTest()
        {
            // TODO unit test for the property 'TransmitLimit'
        }

        /// <summary>
        /// Test the property 'QuotaCycle'
        /// </summary>
        [Fact]
        public void QuotaCycleTest()
        {
            // TODO unit test for the property 'QuotaCycle'
        }
    }
}
