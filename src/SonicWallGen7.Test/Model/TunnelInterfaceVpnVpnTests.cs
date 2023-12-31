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
    ///  Class for testing TunnelInterfaceVpnVpn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TunnelInterfaceVpnVpnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TunnelInterfaceVpnVpn
        //private TunnelInterfaceVpnVpn instance;

        public TunnelInterfaceVpnVpnTests()
        {
            // TODO uncomment below to create an instance of TunnelInterfaceVpnVpn
            //instance = new TunnelInterfaceVpnVpn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TunnelInterfaceVpnVpn
        /// </summary>
        [Fact]
        public void TunnelInterfaceVpnVpnInstanceTest()
        {
            // TODO uncomment below to test "IsType" TunnelInterfaceVpnVpn
            //Assert.IsType<TunnelInterfaceVpnVpn>(instance);
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
        /// Test the property 'IpAssignment'
        /// </summary>
        [Fact]
        public void IpAssignmentTest()
        {
            // TODO unit test for the property 'IpAssignment'
        }

        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Fact]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
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
        /// Test the property 'UserLogin'
        /// </summary>
        [Fact]
        public void UserLoginTest()
        {
            // TODO unit test for the property 'UserLogin'
        }

        /// <summary>
        /// Test the property 'FragmentPackets'
        /// </summary>
        [Fact]
        public void FragmentPacketsTest()
        {
            // TODO unit test for the property 'FragmentPackets'
        }

        /// <summary>
        /// Test the property 'IgnoreDfBit'
        /// </summary>
        [Fact]
        public void IgnoreDfBitTest()
        {
            // TODO unit test for the property 'IgnoreDfBit'
        }

        /// <summary>
        /// Test the property 'FlowReporting'
        /// </summary>
        [Fact]
        public void FlowReportingTest()
        {
            // TODO unit test for the property 'FlowReporting'
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
        /// Test the property 'AsymmetricRoute'
        /// </summary>
        [Fact]
        public void AsymmetricRouteTest()
        {
            // TODO unit test for the property 'AsymmetricRoute'
        }
    }
}
