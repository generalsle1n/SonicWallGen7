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
    ///  Class for testing InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
        //private InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 instance;

        public InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Tests()
        {
            // TODO uncomment below to create an instance of InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
            //instance = new InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
        /// </summary>
        [Fact]
        public void InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6InstanceTest()
        {
            // TODO uncomment below to test "IsType" InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6
            //Assert.IsType<InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6>(instance);
        }

        /// <summary>
        /// Test the property 'ModeAssignment'
        /// </summary>
        [Fact]
        public void ModeAssignmentTest()
        {
            // TODO unit test for the property 'ModeAssignment'
        }

        /// <summary>
        /// Test the property 'Schedule'
        /// </summary>
        [Fact]
        public void ScheduleTest()
        {
            // TODO unit test for the property 'Schedule'
        }

        /// <summary>
        /// Test the property 'Inactivity'
        /// </summary>
        [Fact]
        public void InactivityTest()
        {
            // TODO unit test for the property 'Inactivity'
        }

        /// <summary>
        /// Test the property 'LcpEchoPackets'
        /// </summary>
        [Fact]
        public void LcpEchoPacketsTest()
        {
            // TODO unit test for the property 'LcpEchoPackets'
        }

        /// <summary>
        /// Test the property 'Reconnect'
        /// </summary>
        [Fact]
        public void ReconnectTest()
        {
            // TODO unit test for the property 'Reconnect'
        }

        /// <summary>
        /// Test the property 'NcpNegRetrans'
        /// </summary>
        [Fact]
        public void NcpNegRetransTest()
        {
            // TODO unit test for the property 'NcpNegRetrans'
        }

        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

        /// <summary>
        /// Test the property 'PrefixLength'
        /// </summary>
        [Fact]
        public void PrefixLengthTest()
        {
            // TODO unit test for the property 'PrefixLength'
        }

        /// <summary>
        /// Test the property 'Dns'
        /// </summary>
        [Fact]
        public void DnsTest()
        {
            // TODO unit test for the property 'Dns'
        }

        /// <summary>
        /// Test the property 'Gateway'
        /// </summary>
        [Fact]
        public void GatewayTest()
        {
            // TODO unit test for the property 'Gateway'
        }

        /// <summary>
        /// Test the property 'AdvertiseSubnetPrefix'
        /// </summary>
        [Fact]
        public void AdvertiseSubnetPrefixTest()
        {
            // TODO unit test for the property 'AdvertiseSubnetPrefix'
        }

        /// <summary>
        /// Test the property 'RouterAdvertisement'
        /// </summary>
        [Fact]
        public void RouterAdvertisementTest()
        {
            // TODO unit test for the property 'RouterAdvertisement'
        }

        /// <summary>
        /// Test the property 'PrefixDelegation'
        /// </summary>
        [Fact]
        public void PrefixDelegationTest()
        {
            // TODO unit test for the property 'PrefixDelegation'
        }

        /// <summary>
        /// Test the property 'RapidCommit'
        /// </summary>
        [Fact]
        public void RapidCommitTest()
        {
            // TODO unit test for the property 'RapidCommit'
        }
    }
}
