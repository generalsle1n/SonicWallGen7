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
    ///  Class for testing ShowStatusLdapDynamicServerStatusListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusLdapDynamicServerStatusListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusLdapDynamicServerStatusListInner
        //private ShowStatusLdapDynamicServerStatusListInner instance;

        public ShowStatusLdapDynamicServerStatusListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusLdapDynamicServerStatusListInner
            //instance = new ShowStatusLdapDynamicServerStatusListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusLdapDynamicServerStatusListInner
        /// </summary>
        [Fact]
        public void ShowStatusLdapDynamicServerStatusListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusLdapDynamicServerStatusListInner
            //Assert.IsType<ShowStatusLdapDynamicServerStatusListInner>(instance);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'HostNameIpAddress'
        /// </summary>
        [Fact]
        public void HostNameIpAddressTest()
        {
            // TODO unit test for the property 'HostNameIpAddress'
        }

        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }

        /// <summary>
        /// Test the property 'Port'
        /// </summary>
        [Fact]
        public void PortTest()
        {
            // TODO unit test for the property 'Port'
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }

        /// <summary>
        /// Test the property 'UseTls'
        /// </summary>
        [Fact]
        public void UseTlsTest()
        {
            // TODO unit test for the property 'UseTls'
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
        /// Test the property 'Partition'
        /// </summary>
        [Fact]
        public void PartitionTest()
        {
            // TODO unit test for the property 'Partition'
        }

        /// <summary>
        /// Test the property 'Bind'
        /// </summary>
        [Fact]
        public void BindTest()
        {
            // TODO unit test for the property 'Bind'
        }

        /// <summary>
        /// Test the property 'TreesContainingUsers'
        /// </summary>
        [Fact]
        public void TreesContainingUsersTest()
        {
            // TODO unit test for the property 'TreesContainingUsers'
        }

        /// <summary>
        /// Test the property 'TreesContainingUserGroups'
        /// </summary>
        [Fact]
        public void TreesContainingUserGroupsTest()
        {
            // TODO unit test for the property 'TreesContainingUserGroups'
        }
    }
}
