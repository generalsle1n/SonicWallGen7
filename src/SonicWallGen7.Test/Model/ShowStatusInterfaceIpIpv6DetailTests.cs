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
    ///  Class for testing ShowStatusInterfaceIpIpv6Detail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusInterfaceIpIpv6DetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusInterfaceIpIpv6Detail
        //private ShowStatusInterfaceIpIpv6Detail instance;

        public ShowStatusInterfaceIpIpv6DetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusInterfaceIpIpv6Detail
            //instance = new ShowStatusInterfaceIpIpv6Detail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusInterfaceIpIpv6Detail
        /// </summary>
        [Fact]
        public void ShowStatusInterfaceIpIpv6DetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusInterfaceIpIpv6Detail
            //Assert.IsType<ShowStatusInterfaceIpIpv6Detail>(instance);
        }

        /// <summary>
        /// Test the property 'InterfaceName'
        /// </summary>
        [Fact]
        public void InterfaceNameTest()
        {
            // TODO unit test for the property 'InterfaceName'
        }

        /// <summary>
        /// Test the property 'Zone'
        /// </summary>
        [Fact]
        public void ZoneTest()
        {
            // TODO unit test for the property 'Zone'
        }

        /// <summary>
        /// Test the property 'LinkSetting'
        /// </summary>
        [Fact]
        public void LinkSettingTest()
        {
            // TODO unit test for the property 'LinkSetting'
        }

        /// <summary>
        /// Test the property 'IpMode'
        /// </summary>
        [Fact]
        public void IpModeTest()
        {
            // TODO unit test for the property 'IpMode'
        }

        /// <summary>
        /// Test the property 'IpModeStatus'
        /// </summary>
        [Fact]
        public void IpModeStatusTest()
        {
            // TODO unit test for the property 'IpModeStatus'
        }

        /// <summary>
        /// Test the property 'Dhcpv6Router'
        /// </summary>
        [Fact]
        public void Dhcpv6RouterTest()
        {
            // TODO unit test for the property 'Dhcpv6Router'
        }

        /// <summary>
        /// Test the property 'Dhcpv6Managed'
        /// </summary>
        [Fact]
        public void Dhcpv6ManagedTest()
        {
            // TODO unit test for the property 'Dhcpv6Managed'
        }

        /// <summary>
        /// Test the property 'Dhcpv6Other'
        /// </summary>
        [Fact]
        public void Dhcpv6OtherTest()
        {
            // TODO unit test for the property 'Dhcpv6Other'
        }

        /// <summary>
        /// Test the property 'Dhcpv6Server'
        /// </summary>
        [Fact]
        public void Dhcpv6ServerTest()
        {
            // TODO unit test for the property 'Dhcpv6Server'
        }

        /// <summary>
        /// Test the property 'Dhcpv6Duid'
        /// </summary>
        [Fact]
        public void Dhcpv6DuidTest()
        {
            // TODO unit test for the property 'Dhcpv6Duid'
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
        /// Test the property 'SubnetMask'
        /// </summary>
        [Fact]
        public void SubnetMaskTest()
        {
            // TODO unit test for the property 'SubnetMask'
        }

        /// <summary>
        /// Test the property 'DefaultGateway'
        /// </summary>
        [Fact]
        public void DefaultGatewayTest()
        {
            // TODO unit test for the property 'DefaultGateway'
        }

        /// <summary>
        /// Test the property 'L2tpIpAddress'
        /// </summary>
        [Fact]
        public void L2tpIpAddressTest()
        {
            // TODO unit test for the property 'L2tpIpAddress'
        }

        /// <summary>
        /// Test the property 'L2tpSubnetMask'
        /// </summary>
        [Fact]
        public void L2tpSubnetMaskTest()
        {
            // TODO unit test for the property 'L2tpSubnetMask'
        }

        /// <summary>
        /// Test the property 'L2tpDefaultGateway'
        /// </summary>
        [Fact]
        public void L2tpDefaultGatewayTest()
        {
            // TODO unit test for the property 'L2tpDefaultGateway'
        }

        /// <summary>
        /// Test the property 'LinkStatus'
        /// </summary>
        [Fact]
        public void LinkStatusTest()
        {
            // TODO unit test for the property 'LinkStatus'
        }

        /// <summary>
        /// Test the property 'PrimarySonicDns'
        /// </summary>
        [Fact]
        public void PrimarySonicDnsTest()
        {
            // TODO unit test for the property 'PrimarySonicDns'
        }

        /// <summary>
        /// Test the property 'SecondarySonicDns'
        /// </summary>
        [Fact]
        public void SecondarySonicDnsTest()
        {
            // TODO unit test for the property 'SecondarySonicDns'
        }

        /// <summary>
        /// Test the property 'TertiarySonicDns'
        /// </summary>
        [Fact]
        public void TertiarySonicDnsTest()
        {
            // TODO unit test for the property 'TertiarySonicDns'
        }

        /// <summary>
        /// Test the property 'LeaseExpires'
        /// </summary>
        [Fact]
        public void LeaseExpiresTest()
        {
            // TODO unit test for the property 'LeaseExpires'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }
    }
}
