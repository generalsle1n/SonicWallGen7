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
    ///  Class for testing TcpProxyConnectionsServiceProtocolProtocol
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TcpProxyConnectionsServiceProtocolProtocolTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TcpProxyConnectionsServiceProtocolProtocol
        //private TcpProxyConnectionsServiceProtocolProtocol instance;

        public TcpProxyConnectionsServiceProtocolProtocolTests()
        {
            // TODO uncomment below to create an instance of TcpProxyConnectionsServiceProtocolProtocol
            //instance = new TcpProxyConnectionsServiceProtocolProtocol();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TcpProxyConnectionsServiceProtocolProtocol
        /// </summary>
        [Fact]
        public void TcpProxyConnectionsServiceProtocolProtocolInstanceTest()
        {
            // TODO uncomment below to test "IsType" TcpProxyConnectionsServiceProtocolProtocol
            //Assert.IsType<TcpProxyConnectionsServiceProtocolProtocol>(instance);
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
        /// Test the property 'Begin'
        /// </summary>
        [Fact]
        public void BeginTest()
        {
            // TODO unit test for the property 'Begin'
        }

        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Fact]
        public void EndTest()
        {
            // TODO unit test for the property 'End'
        }
    }
}
