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
    ///  Class for testing ShowStatusSecurityPoliciesStatusDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusSecurityPoliciesStatusDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusSecurityPoliciesStatusDetail
        //private ShowStatusSecurityPoliciesStatusDetail instance;

        public ShowStatusSecurityPoliciesStatusDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusSecurityPoliciesStatusDetail
            //instance = new ShowStatusSecurityPoliciesStatusDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusSecurityPoliciesStatusDetail
        /// </summary>
        [Fact]
        public void ShowStatusSecurityPoliciesStatusDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusSecurityPoliciesStatusDetail
            //Assert.IsType<ShowStatusSecurityPoliciesStatusDetail>(instance);
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
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'Sourceport'
        /// </summary>
        [Fact]
        public void SourceportTest()
        {
            // TODO unit test for the property 'Sourceport'
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
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
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
        /// Test the property 'Rxbytes'
        /// </summary>
        [Fact]
        public void RxbytesTest()
        {
            // TODO unit test for the property 'Rxbytes'
        }

        /// <summary>
        /// Test the property 'Rxpackets'
        /// </summary>
        [Fact]
        public void RxpacketsTest()
        {
            // TODO unit test for the property 'Rxpackets'
        }

        /// <summary>
        /// Test the property 'Txbytes'
        /// </summary>
        [Fact]
        public void TxbytesTest()
        {
            // TODO unit test for the property 'Txbytes'
        }

        /// <summary>
        /// Test the property 'Txpackets'
        /// </summary>
        [Fact]
        public void TxpacketsTest()
        {
            // TODO unit test for the property 'Txpackets'
        }

        /// <summary>
        /// Test the property 'Usage'
        /// </summary>
        [Fact]
        public void UsageTest()
        {
            // TODO unit test for the property 'Usage'
        }

        /// <summary>
        /// Test the property 'TimeLastHit'
        /// </summary>
        [Fact]
        public void TimeLastHitTest()
        {
            // TODO unit test for the property 'TimeLastHit'
        }

        /// <summary>
        /// Test the property 'TimeCreated'
        /// </summary>
        [Fact]
        public void TimeCreatedTest()
        {
            // TODO unit test for the property 'TimeCreated'
        }

        /// <summary>
        /// Test the property 'TimeUpdated'
        /// </summary>
        [Fact]
        public void TimeUpdatedTest()
        {
            // TODO unit test for the property 'TimeUpdated'
        }

        /// <summary>
        /// Test the property 'Iptype'
        /// </summary>
        [Fact]
        public void IptypeTest()
        {
            // TODO unit test for the property 'Iptype'
        }
    }
}