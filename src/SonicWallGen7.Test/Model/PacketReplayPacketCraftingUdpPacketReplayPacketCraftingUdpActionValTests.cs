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
    ///  Class for testing PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionValTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal
        //private PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal instance;

        public PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionValTests()
        {
            // TODO uncomment below to create an instance of PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal
            //instance = new PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal
        /// </summary>
        [Fact]
        public void PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionValInstanceTest()
        {
            // TODO uncomment below to test "IsType" PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal
            //Assert.IsType<PacketReplayPacketCraftingUdpPacketReplayPacketCraftingUdpActionVal>(instance);
        }

        /// <summary>
        /// Test the property 'DestIface'
        /// </summary>
        [Fact]
        public void DestIfaceTest()
        {
            // TODO unit test for the property 'DestIface'
        }

        /// <summary>
        /// Test the property 'DestMac'
        /// </summary>
        [Fact]
        public void DestMacTest()
        {
            // TODO unit test for the property 'DestMac'
        }

        /// <summary>
        /// Test the property 'SrcMac'
        /// </summary>
        [Fact]
        public void SrcMacTest()
        {
            // TODO unit test for the property 'SrcMac'
        }

        /// <summary>
        /// Test the property 'EtherType'
        /// </summary>
        [Fact]
        public void EtherTypeTest()
        {
            // TODO unit test for the property 'EtherType'
        }

        /// <summary>
        /// Test the property 'IpAddrType'
        /// </summary>
        [Fact]
        public void IpAddrTypeTest()
        {
            // TODO unit test for the property 'IpAddrType'
        }

        /// <summary>
        /// Test the property 'SrcAddr'
        /// </summary>
        [Fact]
        public void SrcAddrTest()
        {
            // TODO unit test for the property 'SrcAddr'
        }

        /// <summary>
        /// Test the property 'DestAddr'
        /// </summary>
        [Fact]
        public void DestAddrTest()
        {
            // TODO unit test for the property 'DestAddr'
        }

        /// <summary>
        /// Test the property 'TtlVal'
        /// </summary>
        [Fact]
        public void TtlValTest()
        {
            // TODO unit test for the property 'TtlVal'
        }

        /// <summary>
        /// Test the property 'SrcPort'
        /// </summary>
        [Fact]
        public void SrcPortTest()
        {
            // TODO unit test for the property 'SrcPort'
        }

        /// <summary>
        /// Test the property 'DstPort'
        /// </summary>
        [Fact]
        public void DstPortTest()
        {
            // TODO unit test for the property 'DstPort'
        }

        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Fact]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }
    }
}
