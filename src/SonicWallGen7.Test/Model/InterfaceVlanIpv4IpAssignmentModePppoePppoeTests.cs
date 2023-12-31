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
    ///  Class for testing InterfaceVlanIpv4IpAssignmentModePppoePppoe
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InterfaceVlanIpv4IpAssignmentModePppoePppoeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InterfaceVlanIpv4IpAssignmentModePppoePppoe
        //private InterfaceVlanIpv4IpAssignmentModePppoePppoe instance;

        public InterfaceVlanIpv4IpAssignmentModePppoePppoeTests()
        {
            // TODO uncomment below to create an instance of InterfaceVlanIpv4IpAssignmentModePppoePppoe
            //instance = new InterfaceVlanIpv4IpAssignmentModePppoePppoe();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InterfaceVlanIpv4IpAssignmentModePppoePppoe
        /// </summary>
        [Fact]
        public void InterfaceVlanIpv4IpAssignmentModePppoePppoeInstanceTest()
        {
            // TODO uncomment below to test "IsType" InterfaceVlanIpv4IpAssignmentModePppoePppoe
            //Assert.IsType<InterfaceVlanIpv4IpAssignmentModePppoePppoe>(instance);
        }

        /// <summary>
        /// Test the property 'Dynamic'
        /// </summary>
        [Fact]
        public void DynamicTest()
        {
            // TODO unit test for the property 'Dynamic'
        }

        /// <summary>
        /// Test the property 'Unnumbered'
        /// </summary>
        [Fact]
        public void UnnumberedTest()
        {
            // TODO unit test for the property 'Unnumbered'
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
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
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
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

        /// <summary>
        /// Test the property 'ServiceName'
        /// </summary>
        [Fact]
        public void ServiceNameTest()
        {
            // TODO unit test for the property 'ServiceName'
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
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
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
        /// Test the property 'Schedule'
        /// </summary>
        [Fact]
        public void ScheduleTest()
        {
            // TODO unit test for the property 'Schedule'
        }
    }
}
