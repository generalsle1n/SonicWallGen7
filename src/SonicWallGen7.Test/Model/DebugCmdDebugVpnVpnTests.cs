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
    ///  Class for testing DebugCmdDebugVpnVpn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DebugCmdDebugVpnVpnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DebugCmdDebugVpnVpn
        //private DebugCmdDebugVpnVpn instance;

        public DebugCmdDebugVpnVpnTests()
        {
            // TODO uncomment below to create an instance of DebugCmdDebugVpnVpn
            //instance = new DebugCmdDebugVpnVpn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DebugCmdDebugVpnVpn
        /// </summary>
        [Fact]
        public void DebugCmdDebugVpnVpnInstanceTest()
        {
            // TODO uncomment below to test "IsType" DebugCmdDebugVpnVpn
            //Assert.IsType<DebugCmdDebugVpnVpn>(instance);
        }

        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }

        /// <summary>
        /// Test the property 'Bitmap'
        /// </summary>
        [Fact]
        public void BitmapTest()
        {
            // TODO unit test for the property 'Bitmap'
        }

        /// <summary>
        /// Test the property 'Autorule'
        /// </summary>
        [Fact]
        public void AutoruleTest()
        {
            // TODO unit test for the property 'Autorule'
        }

        /// <summary>
        /// Test the property 'Routeadv'
        /// </summary>
        [Fact]
        public void RouteadvTest()
        {
            // TODO unit test for the property 'Routeadv'
        }

        /// <summary>
        /// Test the property 'Snmp'
        /// </summary>
        [Fact]
        public void SnmpTest()
        {
            // TODO unit test for the property 'Snmp'
        }

        /// <summary>
        /// Test the property 'Gms'
        /// </summary>
        [Fact]
        public void GmsTest()
        {
            // TODO unit test for the property 'Gms'
        }

        /// <summary>
        /// Test the property 'Manualkey'
        /// </summary>
        [Fact]
        public void ManualkeyTest()
        {
            // TODO unit test for the property 'Manualkey'
        }

        /// <summary>
        /// Test the property 'Tunnelif'
        /// </summary>
        [Fact]
        public void TunnelifTest()
        {
            // TODO unit test for the property 'Tunnelif'
        }

        /// <summary>
        /// Test the property 'Natpol'
        /// </summary>
        [Fact]
        public void NatpolTest()
        {
            // TODO unit test for the property 'Natpol'
        }

        /// <summary>
        /// Test the property 'Iphcfg'
        /// </summary>
        [Fact]
        public void IphcfgTest()
        {
            // TODO unit test for the property 'Iphcfg'
        }

        /// <summary>
        /// Test the property 'Prisecgw'
        /// </summary>
        [Fact]
        public void PrisecgwTest()
        {
            // TODO unit test for the property 'Prisecgw'
        }

        /// <summary>
        /// Test the property 'Config'
        /// </summary>
        [Fact]
        public void ConfigTest()
        {
            // TODO unit test for the property 'Config'
        }

        /// <summary>
        /// Test the property 'Spd'
        /// </summary>
        [Fact]
        public void SpdTest()
        {
            // TODO unit test for the property 'Spd'
        }

        /// <summary>
        /// Test the property 'VpnHa'
        /// </summary>
        [Fact]
        public void VpnHaTest()
        {
            // TODO unit test for the property 'VpnHa'
        }

        /// <summary>
        /// Test the property 'Activestate'
        /// </summary>
        [Fact]
        public void ActivestateTest()
        {
            // TODO unit test for the property 'Activestate'
        }

        /// <summary>
        /// Test the property 'LookUp'
        /// </summary>
        [Fact]
        public void LookUpTest()
        {
            // TODO unit test for the property 'LookUp'
        }

        /// <summary>
        /// Test the property 'Bladedisplay'
        /// </summary>
        [Fact]
        public void BladedisplayTest()
        {
            // TODO unit test for the property 'Bladedisplay'
        }
    }
}