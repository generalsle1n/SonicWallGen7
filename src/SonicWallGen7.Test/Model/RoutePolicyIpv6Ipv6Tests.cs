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
    ///  Class for testing RoutePolicyIpv6Ipv6
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RoutePolicyIpv6Ipv6Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoutePolicyIpv6Ipv6
        //private RoutePolicyIpv6Ipv6 instance;

        public RoutePolicyIpv6Ipv6Tests()
        {
            // TODO uncomment below to create an instance of RoutePolicyIpv6Ipv6
            //instance = new RoutePolicyIpv6Ipv6();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoutePolicyIpv6Ipv6
        /// </summary>
        [Fact]
        public void RoutePolicyIpv6Ipv6InstanceTest()
        {
            // TODO uncomment below to test "IsType" RoutePolicyIpv6Ipv6
            //Assert.IsType<RoutePolicyIpv6Ipv6>(instance);
        }

        /// <summary>
        /// Test the property 'VarInterface'
        /// </summary>
        [Fact]
        public void VarInterfaceTest()
        {
            // TODO unit test for the property 'VarInterface'
        }

        /// <summary>
        /// Test the property 'Metric'
        /// </summary>
        [Fact]
        public void MetricTest()
        {
            // TODO unit test for the property 'Metric'
        }

        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }

        /// <summary>
        /// Test the property 'Destination'
        /// </summary>
        [Fact]
        public void DestinationTest()
        {
            // TODO unit test for the property 'Destination'
        }

        /// <summary>
        /// Test the property 'App'
        /// </summary>
        [Fact]
        public void AppTest()
        {
            // TODO unit test for the property 'App'
        }

        /// <summary>
        /// Test the property 'Application'
        /// </summary>
        [Fact]
        public void ApplicationTest()
        {
            // TODO unit test for the property 'Application'
        }

        /// <summary>
        /// Test the property 'Service'
        /// </summary>
        [Fact]
        public void ServiceTest()
        {
            // TODO unit test for the property 'Service'
        }

        /// <summary>
        /// Test the property 'Gateway'
        /// </summary>
        [Fact]
        public void GatewayTest()
        {
            // TODO unit test for the property 'Gateway'
        }

        /// <summary>
        /// Test the property 'Tos'
        /// </summary>
        [Fact]
        public void TosTest()
        {
            // TODO unit test for the property 'Tos'
        }

        /// <summary>
        /// Test the property 'Mask'
        /// </summary>
        [Fact]
        public void MaskTest()
        {
            // TODO unit test for the property 'Mask'
        }

        /// <summary>
        /// Test the property 'Distance'
        /// </summary>
        [Fact]
        public void DistanceTest()
        {
            // TODO unit test for the property 'Distance'
        }

        /// <summary>
        /// Test the property 'NexthopNumber'
        /// </summary>
        [Fact]
        public void NexthopNumberTest()
        {
            // TODO unit test for the property 'NexthopNumber'
        }

        /// <summary>
        /// Test the property 'Interface2'
        /// </summary>
        [Fact]
        public void Interface2Test()
        {
            // TODO unit test for the property 'Interface2'
        }

        /// <summary>
        /// Test the property 'Gateway2'
        /// </summary>
        [Fact]
        public void Gateway2Test()
        {
            // TODO unit test for the property 'Gateway2'
        }

        /// <summary>
        /// Test the property 'Interface3'
        /// </summary>
        [Fact]
        public void Interface3Test()
        {
            // TODO unit test for the property 'Interface3'
        }

        /// <summary>
        /// Test the property 'Gateway3'
        /// </summary>
        [Fact]
        public void Gateway3Test()
        {
            // TODO unit test for the property 'Gateway3'
        }

        /// <summary>
        /// Test the property 'Interface4'
        /// </summary>
        [Fact]
        public void Interface4Test()
        {
            // TODO unit test for the property 'Interface4'
        }

        /// <summary>
        /// Test the property 'Gateway4'
        /// </summary>
        [Fact]
        public void Gateway4Test()
        {
            // TODO unit test for the property 'Gateway4'
        }

        /// <summary>
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
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
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }

        /// <summary>
        /// Test the property 'DisableOnInterfaceDown'
        /// </summary>
        [Fact]
        public void DisableOnInterfaceDownTest()
        {
            // TODO unit test for the property 'DisableOnInterfaceDown'
        }

        /// <summary>
        /// Test the property 'VpnPrecedence'
        /// </summary>
        [Fact]
        public void VpnPrecedenceTest()
        {
            // TODO unit test for the property 'VpnPrecedence'
        }

        /// <summary>
        /// Test the property 'AutoAddAccessRules'
        /// </summary>
        [Fact]
        public void AutoAddAccessRulesTest()
        {
            // TODO unit test for the property 'AutoAddAccessRules'
        }

        /// <summary>
        /// Test the property 'Probe'
        /// </summary>
        [Fact]
        public void ProbeTest()
        {
            // TODO unit test for the property 'Probe'
        }

        /// <summary>
        /// Test the property 'DisableWhenProbesSucceed'
        /// </summary>
        [Fact]
        public void DisableWhenProbesSucceedTest()
        {
            // TODO unit test for the property 'DisableWhenProbesSucceed'
        }

        /// <summary>
        /// Test the property 'DefaultProbeStateUp'
        /// </summary>
        [Fact]
        public void DefaultProbeStateUpTest()
        {
            // TODO unit test for the property 'DefaultProbeStateUp'
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
        /// Test the property 'Ticket'
        /// </summary>
        [Fact]
        public void TicketTest()
        {
            // TODO unit test for the property 'Ticket'
        }
    }
}