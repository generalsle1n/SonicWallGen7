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
    ///  Class for testing VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocalTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
        //private VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal instance;

        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocalTests()
        {
            // TODO uncomment below to create an instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
            //instance = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
        /// </summary>
        [Fact]
        public void VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocalInstanceTest()
        {
            // TODO uncomment below to test "IsType" VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
            //Assert.IsType<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal>(instance);
        }

        /// <summary>
        /// Test the property 'Ipv4'
        /// </summary>
        [Fact]
        public void Ipv4Test()
        {
            // TODO unit test for the property 'Ipv4'
        }

        /// <summary>
        /// Test the property 'DomainName'
        /// </summary>
        [Fact]
        public void DomainNameTest()
        {
            // TODO unit test for the property 'DomainName'
        }

        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }

        /// <summary>
        /// Test the property 'FirewallId'
        /// </summary>
        [Fact]
        public void FirewallIdTest()
        {
            // TODO unit test for the property 'FirewallId'
        }

        /// <summary>
        /// Test the property 'KeyId'
        /// </summary>
        [Fact]
        public void KeyIdTest()
        {
            // TODO unit test for the property 'KeyId'
        }
    }
}