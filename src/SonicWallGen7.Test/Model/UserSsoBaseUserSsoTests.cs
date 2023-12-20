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
    ///  Class for testing UserSsoBaseUserSso
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserSsoBaseUserSsoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserSsoBaseUserSso
        //private UserSsoBaseUserSso instance;

        public UserSsoBaseUserSsoTests()
        {
            // TODO uncomment below to create an instance of UserSsoBaseUserSso
            //instance = new UserSsoBaseUserSso();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserSsoBaseUserSso
        /// </summary>
        [Fact]
        public void UserSsoBaseUserSsoInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserSsoBaseUserSso
            //Assert.IsType<UserSsoBaseUserSso>(instance);
        }

        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Fact]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }

        /// <summary>
        /// Test the property 'NextAgentOnNoName'
        /// </summary>
        [Fact]
        public void NextAgentOnNoNameTest()
        {
            // TODO unit test for the property 'NextAgentOnNoName'
        }

        /// <summary>
        /// Test the property 'BlockTraffic'
        /// </summary>
        [Fact]
        public void BlockTrafficTest()
        {
            // TODO unit test for the property 'BlockTraffic'
        }

        /// <summary>
        /// Test the property 'IncludingForAccessRules'
        /// </summary>
        [Fact]
        public void IncludingForAccessRulesTest()
        {
            // TODO unit test for the property 'IncludingForAccessRules'
        }

        /// <summary>
        /// Test the property 'SyncAllAgentsUserDb'
        /// </summary>
        [Fact]
        public void SyncAllAgentsUserDbTest()
        {
            // TODO unit test for the property 'SyncAllAgentsUserDb'
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
        /// Test the property 'NonDomainLimitedAccess'
        /// </summary>
        [Fact]
        public void NonDomainLimitedAccessTest()
        {
            // TODO unit test for the property 'NonDomainLimitedAccess'
        }

        /// <summary>
        /// Test the property 'Probe'
        /// </summary>
        [Fact]
        public void ProbeTest()
        {
            // TODO unit test for the property 'Probe'
        }

        /// <summary>
        /// Test the property 'ForwardLanman'
        /// </summary>
        [Fact]
        public void ForwardLanmanTest()
        {
            // TODO unit test for the property 'ForwardLanman'
        }

        /// <summary>
        /// Test the property 'TsaServicesBypass'
        /// </summary>
        [Fact]
        public void TsaServicesBypassTest()
        {
            // TODO unit test for the property 'TsaServicesBypass'
        }

        /// <summary>
        /// Test the property 'UserGroupMechanism'
        /// </summary>
        [Fact]
        public void UserGroupMechanismTest()
        {
            // TODO unit test for the property 'UserGroupMechanism'
        }

        /// <summary>
        /// Test the property 'Poll'
        /// </summary>
        [Fact]
        public void PollTest()
        {
            // TODO unit test for the property 'Poll'
        }

        /// <summary>
        /// Test the property 'HoldTime'
        /// </summary>
        [Fact]
        public void HoldTimeTest()
        {
            // TODO unit test for the property 'HoldTime'
        }

        /// <summary>
        /// Test the property 'RampUp'
        /// </summary>
        [Fact]
        public void RampUpTest()
        {
            // TODO unit test for the property 'RampUp'
        }

        /// <summary>
        /// Test the property 'UserDomainName'
        /// </summary>
        [Fact]
        public void UserDomainNameTest()
        {
            // TODO unit test for the property 'UserDomainName'
        }

        /// <summary>
        /// Test the property 'BypassPolicy'
        /// </summary>
        [Fact]
        public void BypassPolicyTest()
        {
            // TODO unit test for the property 'BypassPolicy'
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
        /// Test the property 'DummyUser'
        /// </summary>
        [Fact]
        public void DummyUserTest()
        {
            // TODO unit test for the property 'DummyUser'
        }

        /// <summary>
        /// Test the property 'RadiusAccountingPort'
        /// </summary>
        [Fact]
        public void RadiusAccountingPortTest()
        {
            // TODO unit test for the property 'RadiusAccountingPort'
        }

        /// <summary>
        /// Test the property 'RadiusAcctLookupMechanism'
        /// </summary>
        [Fact]
        public void RadiusAcctLookupMechanismTest()
        {
            // TODO unit test for the property 'RadiusAcctLookupMechanism'
        }

        /// <summary>
        /// Test the property 'SwitchOverTime'
        /// </summary>
        [Fact]
        public void SwitchOverTimeTest()
        {
            // TODO unit test for the property 'SwitchOverTime'
        }

        /// <summary>
        /// Test the property 'IgnoreTransitionMessage'
        /// </summary>
        [Fact]
        public void IgnoreTransitionMessageTest()
        {
            // TODO unit test for the property 'IgnoreTransitionMessage'
        }

        /// <summary>
        /// Test the property 'IgnoreAddr'
        /// </summary>
        [Fact]
        public void IgnoreAddrTest()
        {
            // TODO unit test for the property 'IgnoreAddr'
        }

        /// <summary>
        /// Test the property 'IncludeAddr'
        /// </summary>
        [Fact]
        public void IncludeAddrTest()
        {
            // TODO unit test for the property 'IncludeAddr'
        }

        /// <summary>
        /// Test the property 'RetriesOnFailure'
        /// </summary>
        [Fact]
        public void RetriesOnFailureTest()
        {
            // TODO unit test for the property 'RetriesOnFailure'
        }

        /// <summary>
        /// Test the property 'AuthenticationDomain'
        /// </summary>
        [Fact]
        public void AuthenticationDomainTest()
        {
            // TODO unit test for the property 'AuthenticationDomain'
        }

        /// <summary>
        /// Test the property 'RedirectBrowser'
        /// </summary>
        [Fact]
        public void RedirectBrowserTest()
        {
            // TODO unit test for the property 'RedirectBrowser'
        }
    }
}
