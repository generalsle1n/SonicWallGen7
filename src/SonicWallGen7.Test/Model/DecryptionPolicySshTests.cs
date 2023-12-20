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
    ///  Class for testing DecryptionPolicySsh
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DecryptionPolicySshTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DecryptionPolicySsh
        //private DecryptionPolicySsh instance;

        public DecryptionPolicySshTests()
        {
            // TODO uncomment below to create an instance of DecryptionPolicySsh
            //instance = new DecryptionPolicySsh();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DecryptionPolicySsh
        /// </summary>
        [Fact]
        public void DecryptionPolicySshInstanceTest()
        {
            // TODO uncomment below to test "IsType" DecryptionPolicySsh
            //Assert.IsType<DecryptionPolicySsh>(instance);
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
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
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }

        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }

        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }

        /// <summary>
        /// Test the property 'Destination'
        /// </summary>
        [Fact]
        public void DestinationTest()
        {
            // TODO unit test for the property 'Destination'
        }

        /// <summary>
        /// Test the property 'Service'
        /// </summary>
        [Fact]
        public void ServiceTest()
        {
            // TODO unit test for the property 'Service'
        }

        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }

        /// <summary>
        /// Test the property 'WebCategory'
        /// </summary>
        [Fact]
        public void WebCategoryTest()
        {
            // TODO unit test for the property 'WebCategory'
        }

        /// <summary>
        /// Test the property 'WebSite'
        /// </summary>
        [Fact]
        public void WebSiteTest()
        {
            // TODO unit test for the property 'WebSite'
        }

        /// <summary>
        /// Test the property 'MatchOperation'
        /// </summary>
        [Fact]
        public void MatchOperationTest()
        {
            // TODO unit test for the property 'MatchOperation'
        }

        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }

        /// <summary>
        /// Test the property 'Schedule'
        /// </summary>
        [Fact]
        public void ScheduleTest()
        {
            // TODO unit test for the property 'Schedule'
        }

        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }

        /// <summary>
        /// Test the property 'Ticket'
        /// </summary>
        [Fact]
        public void TicketTest()
        {
            // TODO unit test for the property 'Ticket'
        }

        /// <summary>
        /// Test the property 'IpType'
        /// </summary>
        [Fact]
        public void IpTypeTest()
        {
            // TODO unit test for the property 'IpType'
        }
    }
}
