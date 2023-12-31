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
    ///  Class for testing SecurityPolicyIpv6Ipv6
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SecurityPolicyIpv6Ipv6Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecurityPolicyIpv6Ipv6
        //private SecurityPolicyIpv6Ipv6 instance;

        public SecurityPolicyIpv6Ipv6Tests()
        {
            // TODO uncomment below to create an instance of SecurityPolicyIpv6Ipv6
            //instance = new SecurityPolicyIpv6Ipv6();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityPolicyIpv6Ipv6
        /// </summary>
        [Fact]
        public void SecurityPolicyIpv6Ipv6InstanceTest()
        {
            // TODO uncomment below to test "IsType" SecurityPolicyIpv6Ipv6
            //Assert.IsType<SecurityPolicyIpv6Ipv6>(instance);
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
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
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
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
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
        /// Test the property 'MatchOperation'
        /// </summary>
        [Fact]
        public void MatchOperationTest()
        {
            // TODO unit test for the property 'MatchOperation'
        }

        /// <summary>
        /// Test the property 'Application'
        /// </summary>
        [Fact]
        public void ApplicationTest()
        {
            // TODO unit test for the property 'Application'
        }

        /// <summary>
        /// Test the property 'AndAllMatchedApplications'
        /// </summary>
        [Fact]
        public void AndAllMatchedApplicationsTest()
        {
            // TODO unit test for the property 'AndAllMatchedApplications'
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
        /// Test the property 'UrlList'
        /// </summary>
        [Fact]
        public void UrlListTest()
        {
            // TODO unit test for the property 'UrlList'
        }

        /// <summary>
        /// Test the property 'CustomMatch'
        /// </summary>
        [Fact]
        public void CustomMatchTest()
        {
            // TODO unit test for the property 'CustomMatch'
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
        /// Test the property 'ActionProfile'
        /// </summary>
        [Fact]
        public void ActionProfileTest()
        {
            // TODO unit test for the property 'ActionProfile'
        }

        /// <summary>
        /// Test the property 'Ticket'
        /// </summary>
        [Fact]
        public void TicketTest()
        {
            // TODO unit test for the property 'Ticket'
        }
    }
}
