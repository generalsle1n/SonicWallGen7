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
    ///  Class for testing ShowStatusDnsSecurityTunnelClientsListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusDnsSecurityTunnelClientsListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusDnsSecurityTunnelClientsListInner
        //private ShowStatusDnsSecurityTunnelClientsListInner instance;

        public ShowStatusDnsSecurityTunnelClientsListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusDnsSecurityTunnelClientsListInner
            //instance = new ShowStatusDnsSecurityTunnelClientsListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusDnsSecurityTunnelClientsListInner
        /// </summary>
        [Fact]
        public void ShowStatusDnsSecurityTunnelClientsListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusDnsSecurityTunnelClientsListInner
            //Assert.IsType<ShowStatusDnsSecurityTunnelClientsListInner>(instance);
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
        /// Test the property 'MacAddress'
        /// </summary>
        [Fact]
        public void MacAddressTest()
        {
            // TODO unit test for the property 'MacAddress'
        }

        /// <summary>
        /// Test the property 'DetectionMethod'
        /// </summary>
        [Fact]
        public void DetectionMethodTest()
        {
            // TODO unit test for the property 'DetectionMethod'
        }

        /// <summary>
        /// Test the property 'VarInterface'
        /// </summary>
        [Fact]
        public void VarInterfaceTest()
        {
            // TODO unit test for the property 'VarInterface'
        }

        /// <summary>
        /// Test the property 'Block'
        /// </summary>
        [Fact]
        public void BlockTest()
        {
            // TODO unit test for the property 'Block'
        }
    }
}