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
    ///  Class for testing ShowStatusDhcpv6RelayLeasesListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusDhcpv6RelayLeasesListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusDhcpv6RelayLeasesListInner
        //private ShowStatusDhcpv6RelayLeasesListInner instance;

        public ShowStatusDhcpv6RelayLeasesListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusDhcpv6RelayLeasesListInner
            //instance = new ShowStatusDhcpv6RelayLeasesListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusDhcpv6RelayLeasesListInner
        /// </summary>
        [Fact]
        public void ShowStatusDhcpv6RelayLeasesListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusDhcpv6RelayLeasesListInner
            //Assert.IsType<ShowStatusDhcpv6RelayLeasesListInner>(instance);
        }

        /// <summary>
        /// Test the property 'ClientSIpAddress'
        /// </summary>
        [Fact]
        public void ClientSIpAddressTest()
        {
            // TODO unit test for the property 'ClientSIpAddress'
        }

        /// <summary>
        /// Test the property 'Iaid'
        /// </summary>
        [Fact]
        public void IaidTest()
        {
            // TODO unit test for the property 'Iaid'
        }

        /// <summary>
        /// Test the property 'Duid'
        /// </summary>
        [Fact]
        public void DuidTest()
        {
            // TODO unit test for the property 'Duid'
        }

        /// <summary>
        /// Test the property 'ServerSIpAddress'
        /// </summary>
        [Fact]
        public void ServerSIpAddressTest()
        {
            // TODO unit test for the property 'ServerSIpAddress'
        }

        /// <summary>
        /// Test the property 'LeaseTime'
        /// </summary>
        [Fact]
        public void LeaseTimeTest()
        {
            // TODO unit test for the property 'LeaseTime'
        }

        /// <summary>
        /// Test the property 'RemainingTime'
        /// </summary>
        [Fact]
        public void RemainingTimeTest()
        {
            // TODO unit test for the property 'RemainingTime'
        }
    }
}
