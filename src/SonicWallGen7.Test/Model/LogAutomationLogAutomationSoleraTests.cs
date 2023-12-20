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
    ///  Class for testing LogAutomationLogAutomationSolera
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogAutomationLogAutomationSoleraTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogAutomationLogAutomationSolera
        //private LogAutomationLogAutomationSolera instance;

        public LogAutomationLogAutomationSoleraTests()
        {
            // TODO uncomment below to create an instance of LogAutomationLogAutomationSolera
            //instance = new LogAutomationLogAutomationSolera();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogAutomationLogAutomationSolera
        /// </summary>
        [Fact]
        public void LogAutomationLogAutomationSoleraInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogAutomationLogAutomationSolera
            //Assert.IsType<LogAutomationLogAutomationSolera>(instance);
        }

        /// <summary>
        /// Test the property 'SoleraCaptureStackIntegration'
        /// </summary>
        [Fact]
        public void SoleraCaptureStackIntegrationTest()
        {
            // TODO unit test for the property 'SoleraCaptureStackIntegration'
        }

        /// <summary>
        /// Test the property 'Server'
        /// </summary>
        [Fact]
        public void ServerTest()
        {
            // TODO unit test for the property 'Server'
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
        /// Test the property 'Port'
        /// </summary>
        [Fact]
        public void PortTest()
        {
            // TODO unit test for the property 'Port'
        }

        /// <summary>
        /// Test the property 'DeepseeBaseUrl'
        /// </summary>
        [Fact]
        public void DeepseeBaseUrlTest()
        {
            // TODO unit test for the property 'DeepseeBaseUrl'
        }

        /// <summary>
        /// Test the property 'PcapBaseUrl'
        /// </summary>
        [Fact]
        public void PcapBaseUrlTest()
        {
            // TODO unit test for the property 'PcapBaseUrl'
        }

        /// <summary>
        /// Test the property 'LinkIcon'
        /// </summary>
        [Fact]
        public void LinkIconTest()
        {
            // TODO unit test for the property 'LinkIcon'
        }

        /// <summary>
        /// Test the property 'AddressToLink'
        /// </summary>
        [Fact]
        public void AddressToLinkTest()
        {
            // TODO unit test for the property 'AddressToLink'
        }
    }
}