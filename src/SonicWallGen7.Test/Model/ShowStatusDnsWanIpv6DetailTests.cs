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
    ///  Class for testing ShowStatusDnsWanIpv6Detail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusDnsWanIpv6DetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusDnsWanIpv6Detail
        //private ShowStatusDnsWanIpv6Detail instance;

        public ShowStatusDnsWanIpv6DetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusDnsWanIpv6Detail
            //instance = new ShowStatusDnsWanIpv6Detail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusDnsWanIpv6Detail
        /// </summary>
        [Fact]
        public void ShowStatusDnsWanIpv6DetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusDnsWanIpv6Detail
            //Assert.IsType<ShowStatusDnsWanIpv6Detail>(instance);
        }

        /// <summary>
        /// Test the property 'DnsServer1'
        /// </summary>
        [Fact]
        public void DnsServer1Test()
        {
            // TODO unit test for the property 'DnsServer1'
        }

        /// <summary>
        /// Test the property 'DnsServer2'
        /// </summary>
        [Fact]
        public void DnsServer2Test()
        {
            // TODO unit test for the property 'DnsServer2'
        }

        /// <summary>
        /// Test the property 'DnsServer3'
        /// </summary>
        [Fact]
        public void DnsServer3Test()
        {
            // TODO unit test for the property 'DnsServer3'
        }
    }
}
