/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SonicWallGen7.Client;
using SonicWallGen7.Api;
// uncomment below to import models
//using SonicWallGen7.Model;

namespace SonicWallGen7.Test.Api
{
    /// <summary>
    ///  Class for testing VpnPolicyIpv4TunnelInterfaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VpnPolicyIpv4TunnelInterfaceApiTests : IDisposable
    {
        private VpnPolicyIpv4TunnelInterfaceApi instance;

        public VpnPolicyIpv4TunnelInterfaceApiTests()
        {
            instance = new VpnPolicyIpv4TunnelInterfaceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv4TunnelInterfaceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VpnPolicyIpv4TunnelInterfaceApi
            //Assert.IsType<VpnPolicyIpv4TunnelInterfaceApi>(instance);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfaceGet
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfaceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VpnPoliciesIpv4TunnelInterfaceGet();
            //Assert.IsType<VpnPolicyIpv4TunnelInterfaceCollection>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string TUNNEL_VPN_NAME = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEDelete(TUNNEL_VPN_NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string TUNNEL_VPN_NAME = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEGet(TUNNEL_VPN_NAME);
            //Assert.IsType<VpnPolicyIpv4TunnelInterfaceCollection>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string TUNNEL_VPN_NAME = null;
            //VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPatch(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string TUNNEL_VPN_NAME = null;
            //VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfaceNameTUNNELVPNNAMEPut(TUNNEL_VPN_NAME, vpnPolicyIpv4TunnelInterfaceCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfacePatch
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfacePatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfacePatch(vpnPolicyIpv4TunnelInterfaceCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfacePost
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfacePost(vpnPolicyIpv4TunnelInterfaceCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4TunnelInterfacePut
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4TunnelInterfacePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4TunnelInterfaceCollection? vpnPolicyIpv4TunnelInterfaceCollection = null;
            //var response = instance.VpnPoliciesIpv4TunnelInterfacePut(vpnPolicyIpv4TunnelInterfaceCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
