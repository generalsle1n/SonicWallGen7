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
    ///  Class for testing UserAuthBaseUserAuth
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserAuthBaseUserAuthTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAuthBaseUserAuth
        //private UserAuthBaseUserAuth instance;

        public UserAuthBaseUserAuthTests()
        {
            // TODO uncomment below to create an instance of UserAuthBaseUserAuth
            //instance = new UserAuthBaseUserAuth();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAuthBaseUserAuth
        /// </summary>
        [Fact]
        public void UserAuthBaseUserAuthInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAuthBaseUserAuth
            //Assert.IsType<UserAuthBaseUserAuth>(instance);
        }

        /// <summary>
        /// Test the property 'CaseSensitiveNames'
        /// </summary>
        [Fact]
        public void CaseSensitiveNamesTest()
        {
            // TODO unit test for the property 'CaseSensitiveNames'
        }

        /// <summary>
        /// Test the property 'LoginUniqueness'
        /// </summary>
        [Fact]
        public void LoginUniquenessTest()
        {
            // TODO unit test for the property 'LoginUniqueness'
        }

        /// <summary>
        /// Test the property 'ReloginAfterPasswordChange'
        /// </summary>
        [Fact]
        public void ReloginAfterPasswordChangeTest()
        {
            // TODO unit test for the property 'ReloginAfterPasswordChange'
        }

        /// <summary>
        /// Test the property 'DisplayLoginInfo'
        /// </summary>
        [Fact]
        public void DisplayLoginInfoTest()
        {
            // TODO unit test for the property 'DisplayLoginInfo'
        }

        /// <summary>
        /// Test the property 'OneTimePasswordConstraints'
        /// </summary>
        [Fact]
        public void OneTimePasswordConstraintsTest()
        {
            // TODO unit test for the property 'OneTimePasswordConstraints'
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
        /// Test the property 'AuthPageTimeout'
        /// </summary>
        [Fact]
        public void AuthPageTimeoutTest()
        {
            // TODO unit test for the property 'AuthPageTimeout'
        }

        /// <summary>
        /// Test the property 'BrowserRedirectVia'
        /// </summary>
        [Fact]
        public void BrowserRedirectViaTest()
        {
            // TODO unit test for the property 'BrowserRedirectVia'
        }

        /// <summary>
        /// Test the property 'RedirectToLoginPage'
        /// </summary>
        [Fact]
        public void RedirectToLoginPageTest()
        {
            // TODO unit test for the property 'RedirectToLoginPage'
        }

        /// <summary>
        /// Test the property 'HttpRedirectAfterLogin'
        /// </summary>
        [Fact]
        public void HttpRedirectAfterLoginTest()
        {
            // TODO unit test for the property 'HttpRedirectAfterLogin'
        }

        /// <summary>
        /// Test the property 'RedirectExternalPage'
        /// </summary>
        [Fact]
        public void RedirectExternalPageTest()
        {
            // TODO unit test for the property 'RedirectExternalPage'
        }

        /// <summary>
        /// Test the property 'CombinedLogin'
        /// </summary>
        [Fact]
        public void CombinedLoginTest()
        {
            // TODO unit test for the property 'CombinedLogin'
        }

        /// <summary>
        /// Test the property 'PolicyBannerBeforeLogin'
        /// </summary>
        [Fact]
        public void PolicyBannerBeforeLoginTest()
        {
            // TODO unit test for the property 'PolicyBannerBeforeLogin'
        }

        /// <summary>
        /// Test the property 'PolicyBanner'
        /// </summary>
        [Fact]
        public void PolicyBannerTest()
        {
            // TODO unit test for the property 'PolicyBanner'
        }

        /// <summary>
        /// Test the property 'InactivityTimeout'
        /// </summary>
        [Fact]
        public void InactivityTimeoutTest()
        {
            // TODO unit test for the property 'InactivityTimeout'
        }

        /// <summary>
        /// Test the property 'PreventInactivityLogout'
        /// </summary>
        [Fact]
        public void PreventInactivityLogoutTest()
        {
            // TODO unit test for the property 'PreventInactivityLogout'
        }

        /// <summary>
        /// Test the property 'LogUserName'
        /// </summary>
        [Fact]
        public void LogUserNameTest()
        {
            // TODO unit test for the property 'LogUserName'
        }

        /// <summary>
        /// Test the property 'UserConnectionsLogout'
        /// </summary>
        [Fact]
        public void UserConnectionsLogoutTest()
        {
            // TODO unit test for the property 'UserConnectionsLogout'
        }

        /// <summary>
        /// Test the property 'InactiveUser'
        /// </summary>
        [Fact]
        public void InactiveUserTest()
        {
            // TODO unit test for the property 'InactiveUser'
        }

        /// <summary>
        /// Test the property 'AgeOut'
        /// </summary>
        [Fact]
        public void AgeOutTest()
        {
            // TODO unit test for the property 'AgeOut'
        }

        /// <summary>
        /// Test the property 'WebLoginSessionLimit'
        /// </summary>
        [Fact]
        public void WebLoginSessionLimitTest()
        {
            // TODO unit test for the property 'WebLoginSessionLimit'
        }

        /// <summary>
        /// Test the property 'ShowUserStatusWindow'
        /// </summary>
        [Fact]
        public void ShowUserStatusWindowTest()
        {
            // TODO unit test for the property 'ShowUserStatusWindow'
        }

        /// <summary>
        /// Test the property 'StatusWindowHeartbeat'
        /// </summary>
        [Fact]
        public void StatusWindowHeartbeatTest()
        {
            // TODO unit test for the property 'StatusWindowHeartbeat'
        }

        /// <summary>
        /// Test the property 'DisconnectedUserDetect'
        /// </summary>
        [Fact]
        public void DisconnectedUserDetectTest()
        {
            // TODO unit test for the property 'DisconnectedUserDetect'
        }

        /// <summary>
        /// Test the property 'OpenInSameWindow'
        /// </summary>
        [Fact]
        public void OpenInSameWindowTest()
        {
            // TODO unit test for the property 'OpenInSameWindow'
        }

        /// <summary>
        /// Test the property 'RadiusChapHttpLogin'
        /// </summary>
        [Fact]
        public void RadiusChapHttpLoginTest()
        {
            // TODO unit test for the property 'RadiusChapHttpLogin'
        }

        /// <summary>
        /// Test the property 'AcceptableUsePolicy'
        /// </summary>
        [Fact]
        public void AcceptableUsePolicyTest()
        {
            // TODO unit test for the property 'AcceptableUsePolicy'
        }

        /// <summary>
        /// Test the property 'CustomizeLoginPage'
        /// </summary>
        [Fact]
        public void CustomizeLoginPageTest()
        {
            // TODO unit test for the property 'CustomizeLoginPage'
        }
    }
}
