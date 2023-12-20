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
    ///  Class for testing TunnelInterface4to6TypeGre4to6Gre4to6
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TunnelInterface4to6TypeGre4to6Gre4to6Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TunnelInterface4to6TypeGre4to6Gre4to6
        //private TunnelInterface4to6TypeGre4to6Gre4to6 instance;

        public TunnelInterface4to6TypeGre4to6Gre4to6Tests()
        {
            // TODO uncomment below to create an instance of TunnelInterface4to6TypeGre4to6Gre4to6
            //instance = new TunnelInterface4to6TypeGre4to6Gre4to6();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TunnelInterface4to6TypeGre4to6Gre4to6
        /// </summary>
        [Fact]
        public void TunnelInterface4to6TypeGre4to6Gre4to6InstanceTest()
        {
            // TODO uncomment below to test "IsType" TunnelInterface4to6TypeGre4to6Gre4to6
            //Assert.IsType<TunnelInterface4to6TypeGre4to6Gre4to6>(instance);
        }

        /// <summary>
        /// Test the property 'BoundTo'
        /// </summary>
        [Fact]
        public void BoundToTest()
        {
            // TODO unit test for the property 'BoundTo'
        }

        /// <summary>
        /// Test the property 'Remote'
        /// </summary>
        [Fact]
        public void RemoteTest()
        {
            // TODO unit test for the property 'Remote'
        }

        /// <summary>
        /// Test the property 'Local'
        /// </summary>
        [Fact]
        public void LocalTest()
        {
            // TODO unit test for the property 'Local'
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
        /// Test the property 'Netmask'
        /// </summary>
        [Fact]
        public void NetmaskTest()
        {
            // TODO unit test for the property 'Netmask'
        }
    }
}
