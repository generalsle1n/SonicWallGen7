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
    ///  Class for testing ShowStatusInterfaceIpIpv6ListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusInterfaceIpIpv6ListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusInterfaceIpIpv6ListInner
        //private ShowStatusInterfaceIpIpv6ListInner instance;

        public ShowStatusInterfaceIpIpv6ListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusInterfaceIpIpv6ListInner
            //instance = new ShowStatusInterfaceIpIpv6ListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusInterfaceIpIpv6ListInner
        /// </summary>
        [Fact]
        public void ShowStatusInterfaceIpIpv6ListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusInterfaceIpIpv6ListInner
            //Assert.IsType<ShowStatusInterfaceIpIpv6ListInner>(instance);
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
        /// Test the property 'Zone'
        /// </summary>
        [Fact]
        public void ZoneTest()
        {
            // TODO unit test for the property 'Zone'
        }

        /// <summary>
        /// Test the property 'IpMode'
        /// </summary>
        [Fact]
        public void IpModeTest()
        {
            // TODO unit test for the property 'IpMode'
        }

        /// <summary>
        /// Test the property 'IpAddress'
        /// </summary>
        [Fact]
        public void IpAddressTest()
        {
            // TODO unit test for the property 'IpAddress'
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
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }
    }
}
