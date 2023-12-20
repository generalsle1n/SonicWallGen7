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
    ///  Class for testing PacketMonitorPacketMonitorMonitorFilter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PacketMonitorPacketMonitorMonitorFilterTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PacketMonitorPacketMonitorMonitorFilter
        //private PacketMonitorPacketMonitorMonitorFilter instance;

        public PacketMonitorPacketMonitorMonitorFilterTests()
        {
            // TODO uncomment below to create an instance of PacketMonitorPacketMonitorMonitorFilter
            //instance = new PacketMonitorPacketMonitorMonitorFilter();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PacketMonitorPacketMonitorMonitorFilter
        /// </summary>
        [Fact]
        public void PacketMonitorPacketMonitorMonitorFilterInstanceTest()
        {
            // TODO uncomment below to test "IsType" PacketMonitorPacketMonitorMonitorFilter
            //Assert.IsType<PacketMonitorPacketMonitorMonitorFilter>(instance);
        }

        /// <summary>
        /// Test the property 'FirewallGenerated'
        /// </summary>
        [Fact]
        public void FirewallGeneratedTest()
        {
            // TODO unit test for the property 'FirewallGenerated'
        }

        /// <summary>
        /// Test the property 'Intermediate'
        /// </summary>
        [Fact]
        public void IntermediateTest()
        {
            // TODO unit test for the property 'Intermediate'
        }

        /// <summary>
        /// Test the property 'BasedOnFirewallRule'
        /// </summary>
        [Fact]
        public void BasedOnFirewallRuleTest()
        {
            // TODO unit test for the property 'BasedOnFirewallRule'
        }

        /// <summary>
        /// Test the property 'Interfaces'
        /// </summary>
        [Fact]
        public void InterfacesTest()
        {
            // TODO unit test for the property 'Interfaces'
        }

        /// <summary>
        /// Test the property 'EtherTypes'
        /// </summary>
        [Fact]
        public void EtherTypesTest()
        {
            // TODO unit test for the property 'EtherTypes'
        }

        /// <summary>
        /// Test the property 'IpTypes'
        /// </summary>
        [Fact]
        public void IpTypesTest()
        {
            // TODO unit test for the property 'IpTypes'
        }

        /// <summary>
        /// Test the property 'SourceIps'
        /// </summary>
        [Fact]
        public void SourceIpsTest()
        {
            // TODO unit test for the property 'SourceIps'
        }

        /// <summary>
        /// Test the property 'SourcePorts'
        /// </summary>
        [Fact]
        public void SourcePortsTest()
        {
            // TODO unit test for the property 'SourcePorts'
        }

        /// <summary>
        /// Test the property 'DestinationIps'
        /// </summary>
        [Fact]
        public void DestinationIpsTest()
        {
            // TODO unit test for the property 'DestinationIps'
        }

        /// <summary>
        /// Test the property 'DestinationPorts'
        /// </summary>
        [Fact]
        public void DestinationPortsTest()
        {
            // TODO unit test for the property 'DestinationPorts'
        }

        /// <summary>
        /// Test the property 'Bidirectional'
        /// </summary>
        [Fact]
        public void BidirectionalTest()
        {
            // TODO unit test for the property 'Bidirectional'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
    }
}