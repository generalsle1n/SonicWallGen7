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
    ///  Class for testing DebugCmdDebugVpnIke
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DebugCmdDebugVpnIkeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DebugCmdDebugVpnIke
        //private DebugCmdDebugVpnIke instance;

        public DebugCmdDebugVpnIkeTests()
        {
            // TODO uncomment below to create an instance of DebugCmdDebugVpnIke
            //instance = new DebugCmdDebugVpnIke();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DebugCmdDebugVpnIke
        /// </summary>
        [Fact]
        public void DebugCmdDebugVpnIkeInstanceTest()
        {
            // TODO uncomment below to test "IsType" DebugCmdDebugVpnIke
            //Assert.IsType<DebugCmdDebugVpnIke>(instance);
        }

        /// <summary>
        /// Test the property 'Dpd'
        /// </summary>
        [Fact]
        public void DpdTest()
        {
            // TODO unit test for the property 'Dpd'
        }

        /// <summary>
        /// Test the property 'Keepalive'
        /// </summary>
        [Fact]
        public void KeepaliveTest()
        {
            // TODO unit test for the property 'Keepalive'
        }

        /// <summary>
        /// Test the property 'Mempool'
        /// </summary>
        [Fact]
        public void MempoolTest()
        {
            // TODO unit test for the property 'Mempool'
        }

        /// <summary>
        /// Test the property 'Xauth'
        /// </summary>
        [Fact]
        public void XauthTest()
        {
            // TODO unit test for the property 'Xauth'
        }

        /// <summary>
        /// Test the property 'Autoprov'
        /// </summary>
        [Fact]
        public void AutoprovTest()
        {
            // TODO unit test for the property 'Autoprov'
        }

        /// <summary>
        /// Test the property 'Nattrav'
        /// </summary>
        [Fact]
        public void NattravTest()
        {
            // TODO unit test for the property 'Nattrav'
        }

        /// <summary>
        /// Test the property 'Ocsp'
        /// </summary>
        [Fact]
        public void OcspTest()
        {
            // TODO unit test for the property 'Ocsp'
        }

        /// <summary>
        /// Test the property 'Dhcprelay'
        /// </summary>
        [Fact]
        public void DhcprelayTest()
        {
            // TODO unit test for the property 'Dhcprelay'
        }

        /// <summary>
        /// Test the property 'L2tp'
        /// </summary>
        [Fact]
        public void L2tpTest()
        {
            // TODO unit test for the property 'L2tp'
        }

        /// <summary>
        /// Test the property 'Phase1'
        /// </summary>
        [Fact]
        public void Phase1Test()
        {
            // TODO unit test for the property 'Phase1'
        }

        /// <summary>
        /// Test the property 'Phase2'
        /// </summary>
        [Fact]
        public void Phase2Test()
        {
            // TODO unit test for the property 'Phase2'
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
        /// Test the property 'Packet'
        /// </summary>
        [Fact]
        public void PacketTest()
        {
            // TODO unit test for the property 'Packet'
        }

        /// <summary>
        /// Test the property 'Pki'
        /// </summary>
        [Fact]
        public void PkiTest()
        {
            // TODO unit test for the property 'Pki'
        }

        /// <summary>
        /// Test the property 'Groupvpn'
        /// </summary>
        [Fact]
        public void GroupvpnTest()
        {
            // TODO unit test for the property 'Groupvpn'
        }

        /// <summary>
        /// Test the property 'VpnHandle'
        /// </summary>
        [Fact]
        public void VpnHandleTest()
        {
            // TODO unit test for the property 'VpnHandle'
        }

        /// <summary>
        /// Test the property 'Negn'
        /// </summary>
        [Fact]
        public void NegnTest()
        {
            // TODO unit test for the property 'Negn'
        }

        /// <summary>
        /// Test the property 'Ikev2'
        /// </summary>
        [Fact]
        public void Ikev2Test()
        {
            // TODO unit test for the property 'Ikev2'
        }

        /// <summary>
        /// Test the property 'Ikekeys'
        /// </summary>
        [Fact]
        public void IkekeysTest()
        {
            // TODO unit test for the property 'Ikekeys'
        }

        /// <summary>
        /// Test the property 'Blade'
        /// </summary>
        [Fact]
        public void BladeTest()
        {
            // TODO unit test for the property 'Blade'
        }
    }
}
