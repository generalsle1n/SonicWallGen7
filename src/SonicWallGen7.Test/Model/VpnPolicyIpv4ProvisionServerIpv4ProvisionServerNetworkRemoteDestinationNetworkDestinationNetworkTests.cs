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
    ///  Class for testing VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetworkTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
        //private VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork instance;

        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetworkTests()
        {
            // TODO uncomment below to create an instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
            //instance = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
        /// </summary>
        [Fact]
        public void VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetworkInstanceTest()
        {
            // TODO uncomment below to test "IsType" VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
            //Assert.IsType<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Fact]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }

        /// <summary>
        /// Test the property 'Host'
        /// </summary>
        [Fact]
        public void HostTest()
        {
            // TODO unit test for the property 'Host'
        }

        /// <summary>
        /// Test the property 'Range'
        /// </summary>
        [Fact]
        public void RangeTest()
        {
            // TODO unit test for the property 'Range'
        }

        /// <summary>
        /// Test the property 'Network'
        /// </summary>
        [Fact]
        public void NetworkTest()
        {
            // TODO unit test for the property 'Network'
        }
    }
}
