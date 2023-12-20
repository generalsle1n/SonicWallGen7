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
    ///  Class for testing SslVpnDeviceProfileRoutesRouteIpv6Group
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SslVpnDeviceProfileRoutesRouteIpv6GroupTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SslVpnDeviceProfileRoutesRouteIpv6Group
        //private SslVpnDeviceProfileRoutesRouteIpv6Group instance;

        public SslVpnDeviceProfileRoutesRouteIpv6GroupTests()
        {
            // TODO uncomment below to create an instance of SslVpnDeviceProfileRoutesRouteIpv6Group
            //instance = new SslVpnDeviceProfileRoutesRouteIpv6Group();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SslVpnDeviceProfileRoutesRouteIpv6Group
        /// </summary>
        [Fact]
        public void SslVpnDeviceProfileRoutesRouteIpv6GroupInstanceTest()
        {
            // TODO uncomment below to test "IsType" SslVpnDeviceProfileRoutesRouteIpv6Group
            //Assert.IsType<SslVpnDeviceProfileRoutesRouteIpv6Group>(instance);
        }

        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Fact]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }
    }
}
