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
    ///  Class for testing DebugCmdDebugAuthLdap
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DebugCmdDebugAuthLdapTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DebugCmdDebugAuthLdap
        //private DebugCmdDebugAuthLdap instance;

        public DebugCmdDebugAuthLdapTests()
        {
            // TODO uncomment below to create an instance of DebugCmdDebugAuthLdap
            //instance = new DebugCmdDebugAuthLdap();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DebugCmdDebugAuthLdap
        /// </summary>
        [Fact]
        public void DebugCmdDebugAuthLdapInstanceTest()
        {
            // TODO uncomment below to test "IsType" DebugCmdDebugAuthLdap
            //Assert.IsType<DebugCmdDebugAuthLdap>(instance);
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
        /// Test the property 'Daemon'
        /// </summary>
        [Fact]
        public void DaemonTest()
        {
            // TODO unit test for the property 'Daemon'
        }

        /// <summary>
        /// Test the property 'Tool'
        /// </summary>
        [Fact]
        public void ToolTest()
        {
            // TODO unit test for the property 'Tool'
        }

        /// <summary>
        /// Test the property 'Relay'
        /// </summary>
        [Fact]
        public void RelayTest()
        {
            // TODO unit test for the property 'Relay'
        }

        /// <summary>
        /// Test the property 'Trace'
        /// </summary>
        [Fact]
        public void TraceTest()
        {
            // TODO unit test for the property 'Trace'
        }

        /// <summary>
        /// Test the property 'Packets'
        /// </summary>
        [Fact]
        public void PacketsTest()
        {
            // TODO unit test for the property 'Packets'
        }

        /// <summary>
        /// Test the property 'Args'
        /// </summary>
        [Fact]
        public void ArgsTest()
        {
            // TODO unit test for the property 'Args'
        }

        /// <summary>
        /// Test the property 'Conns'
        /// </summary>
        [Fact]
        public void ConnsTest()
        {
            // TODO unit test for the property 'Conns'
        }

        /// <summary>
        /// Test the property 'Ber'
        /// </summary>
        [Fact]
        public void BerTest()
        {
            // TODO unit test for the property 'Ber'
        }

        /// <summary>
        /// Test the property 'AuthFilter'
        /// </summary>
        [Fact]
        public void AuthFilterTest()
        {
            // TODO unit test for the property 'AuthFilter'
        }

        /// <summary>
        /// Test the property 'Parse'
        /// </summary>
        [Fact]
        public void ParseTest()
        {
            // TODO unit test for the property 'Parse'
        }

        /// <summary>
        /// Test the property 'Toolverbose'
        /// </summary>
        [Fact]
        public void ToolverboseTest()
        {
            // TODO unit test for the property 'Toolverbose'
        }

        /// <summary>
        /// Test the property 'Nameresolve'
        /// </summary>
        [Fact]
        public void NameresolveTest()
        {
            // TODO unit test for the property 'Nameresolve'
        }

        /// <summary>
        /// Test the property 'Pktdump'
        /// </summary>
        [Fact]
        public void PktdumpTest()
        {
            // TODO unit test for the property 'Pktdump'
        }

        /// <summary>
        /// Test the property 'Socketdump'
        /// </summary>
        [Fact]
        public void SocketdumpTest()
        {
            // TODO unit test for the property 'Socketdump'
        }

        /// <summary>
        /// Test the property 'All'
        /// </summary>
        [Fact]
        public void AllTest()
        {
            // TODO unit test for the property 'All'
        }
    }
}