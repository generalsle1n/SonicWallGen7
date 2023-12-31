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
    ///  Class for testing VpnPolicyIpv4GroupVpnIpv4GroupVpn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VpnPolicyIpv4GroupVpnIpv4GroupVpnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VpnPolicyIpv4GroupVpnIpv4GroupVpn
        //private VpnPolicyIpv4GroupVpnIpv4GroupVpn instance;

        public VpnPolicyIpv4GroupVpnIpv4GroupVpnTests()
        {
            // TODO uncomment below to create an instance of VpnPolicyIpv4GroupVpnIpv4GroupVpn
            //instance = new VpnPolicyIpv4GroupVpnIpv4GroupVpn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv4GroupVpnIpv4GroupVpn
        /// </summary>
        [Fact]
        public void VpnPolicyIpv4GroupVpnIpv4GroupVpnInstanceTest()
        {
            // TODO uncomment below to test "IsType" VpnPolicyIpv4GroupVpnIpv4GroupVpn
            //Assert.IsType<VpnPolicyIpv4GroupVpnIpv4GroupVpn>(instance);
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
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }

        /// <summary>
        /// Test the property 'AuthMethod'
        /// </summary>
        [Fact]
        public void AuthMethodTest()
        {
            // TODO unit test for the property 'AuthMethod'
        }

        /// <summary>
        /// Test the property 'Proposal'
        /// </summary>
        [Fact]
        public void ProposalTest()
        {
            // TODO unit test for the property 'Proposal'
        }

        /// <summary>
        /// Test the property 'VarClient'
        /// </summary>
        [Fact]
        public void VarClientTest()
        {
            // TODO unit test for the property 'VarClient'
        }

        /// <summary>
        /// Test the property 'AntiReplay'
        /// </summary>
        [Fact]
        public void AntiReplayTest()
        {
            // TODO unit test for the property 'AntiReplay'
        }

        /// <summary>
        /// Test the property 'Multicast'
        /// </summary>
        [Fact]
        public void MulticastTest()
        {
            // TODO unit test for the property 'Multicast'
        }

        /// <summary>
        /// Test the property 'OcspChecking'
        /// </summary>
        [Fact]
        public void OcspCheckingTest()
        {
            // TODO unit test for the property 'OcspChecking'
        }

        /// <summary>
        /// Test the property 'ResponderUrl'
        /// </summary>
        [Fact]
        public void ResponderUrlTest()
        {
            // TODO unit test for the property 'ResponderUrl'
        }

        /// <summary>
        /// Test the property 'Management'
        /// </summary>
        [Fact]
        public void ManagementTest()
        {
            // TODO unit test for the property 'Management'
        }

        /// <summary>
        /// Test the property 'DefaultLanGateway'
        /// </summary>
        [Fact]
        public void DefaultLanGatewayTest()
        {
            // TODO unit test for the property 'DefaultLanGateway'
        }

        /// <summary>
        /// Test the property 'ClientAuthentication'
        /// </summary>
        [Fact]
        public void ClientAuthenticationTest()
        {
            // TODO unit test for the property 'ClientAuthentication'
        }

        /// <summary>
        /// Test the property 'AcceptMultipleProposals'
        /// </summary>
        [Fact]
        public void AcceptMultipleProposalsTest()
        {
            // TODO unit test for the property 'AcceptMultipleProposals'
        }

        /// <summary>
        /// Test the property 'IkeModeConfiguration'
        /// </summary>
        [Fact]
        public void IkeModeConfigurationTest()
        {
            // TODO unit test for the property 'IkeModeConfiguration'
        }
    }
}
