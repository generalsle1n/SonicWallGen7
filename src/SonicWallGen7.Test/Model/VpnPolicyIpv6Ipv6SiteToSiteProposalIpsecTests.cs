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
    ///  Class for testing VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec
        //private VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec instance;

        public VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecTests()
        {
            // TODO uncomment below to create an instance of VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec
            //instance = new VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec
        /// </summary>
        [Fact]
        public void VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecInstanceTest()
        {
            // TODO uncomment below to test "IsType" VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec
            //Assert.IsType<VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec>(instance);
        }

        /// <summary>
        /// Test the property 'Protocol'
        /// </summary>
        [Fact]
        public void ProtocolTest()
        {
            // TODO unit test for the property 'Protocol'
        }

        /// <summary>
        /// Test the property 'Encryption'
        /// </summary>
        [Fact]
        public void EncryptionTest()
        {
            // TODO unit test for the property 'Encryption'
        }

        /// <summary>
        /// Test the property 'Authentication'
        /// </summary>
        [Fact]
        public void AuthenticationTest()
        {
            // TODO unit test for the property 'Authentication'
        }

        /// <summary>
        /// Test the property 'PerfectForwardSecrecy'
        /// </summary>
        [Fact]
        public void PerfectForwardSecrecyTest()
        {
            // TODO unit test for the property 'PerfectForwardSecrecy'
        }

        /// <summary>
        /// Test the property 'Lifetime'
        /// </summary>
        [Fact]
        public void LifetimeTest()
        {
            // TODO unit test for the property 'Lifetime'
        }

        /// <summary>
        /// Test the property 'Lifebytes'
        /// </summary>
        [Fact]
        public void LifebytesTest()
        {
            // TODO unit test for the property 'Lifebytes'
        }

        /// <summary>
        /// Test the property 'InSpi'
        /// </summary>
        [Fact]
        public void InSpiTest()
        {
            // TODO unit test for the property 'InSpi'
        }

        /// <summary>
        /// Test the property 'OutSpi'
        /// </summary>
        [Fact]
        public void OutSpiTest()
        {
            // TODO unit test for the property 'OutSpi'
        }

        /// <summary>
        /// Test the property 'InEncryptionKey'
        /// </summary>
        [Fact]
        public void InEncryptionKeyTest()
        {
            // TODO unit test for the property 'InEncryptionKey'
        }

        /// <summary>
        /// Test the property 'InAuthenticationKey'
        /// </summary>
        [Fact]
        public void InAuthenticationKeyTest()
        {
            // TODO unit test for the property 'InAuthenticationKey'
        }

        /// <summary>
        /// Test the property 'OutEncryptionKey'
        /// </summary>
        [Fact]
        public void OutEncryptionKeyTest()
        {
            // TODO unit test for the property 'OutEncryptionKey'
        }

        /// <summary>
        /// Test the property 'OutAuthenticationKey'
        /// </summary>
        [Fact]
        public void OutAuthenticationKeyTest()
        {
            // TODO unit test for the property 'OutAuthenticationKey'
        }
    }
}