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
    ///  Class for testing VpnPolicyIpv4ProvisionServerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VpnPolicyIpv4ProvisionServerApiTests : IDisposable
    {
        private VpnPolicyIpv4ProvisionServerApi instance;

        public VpnPolicyIpv4ProvisionServerApiTests()
        {
            instance = new VpnPolicyIpv4ProvisionServerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv4ProvisionServerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VpnPolicyIpv4ProvisionServerApi
            //Assert.IsType<VpnPolicyIpv4ProvisionServerApi>(instance);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerGet
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VpnPoliciesIpv4ProvisionServerGet();
            //Assert.IsType<VpnPolicyIpv4ProvisionServerCollection>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerNameVPNNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string VPN_NAME = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEDelete(VPN_NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerNameVPNNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string VPN_NAME = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEGet(VPN_NAME);
            //Assert.IsType<VpnPolicyIpv4ProvisionServerCollection>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string VPN_NAME = null;
            //VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPatch(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerNameVPNNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string VPN_NAME = null;
            //VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerNameVPNNAMEPut(VPN_NAME, vpnPolicyIpv4ProvisionServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerPatch
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerPatch(vpnPolicyIpv4ProvisionServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerPost
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerPost(vpnPolicyIpv4ProvisionServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test VpnPoliciesIpv4ProvisionServerPut
        /// </summary>
        [Fact]
        public void VpnPoliciesIpv4ProvisionServerPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VpnPolicyIpv4ProvisionServerCollection? vpnPolicyIpv4ProvisionServerCollection = null;
            //var response = instance.VpnPoliciesIpv4ProvisionServerPut(vpnPolicyIpv4ProvisionServerCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
