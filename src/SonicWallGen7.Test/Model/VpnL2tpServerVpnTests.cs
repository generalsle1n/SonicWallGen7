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
    ///  Class for testing VpnL2tpServerVpn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VpnL2tpServerVpnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VpnL2tpServerVpn
        //private VpnL2tpServerVpn instance;

        public VpnL2tpServerVpnTests()
        {
            // TODO uncomment below to create an instance of VpnL2tpServerVpn
            //instance = new VpnL2tpServerVpn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnL2tpServerVpn
        /// </summary>
        [Fact]
        public void VpnL2tpServerVpnInstanceTest()
        {
            // TODO uncomment below to test "IsType" VpnL2tpServerVpn
            //Assert.IsType<VpnL2tpServerVpn>(instance);
        }

        /// <summary>
        /// Test the property 'L2tpServer'
        /// </summary>
        [Fact]
        public void L2tpServerTest()
        {
            // TODO unit test for the property 'L2tpServer'
        }
    }
}
