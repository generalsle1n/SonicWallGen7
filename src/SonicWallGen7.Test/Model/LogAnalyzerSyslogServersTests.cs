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
    ///  Class for testing LogAnalyzerSyslogServers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogAnalyzerSyslogServersTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogAnalyzerSyslogServers
        //private LogAnalyzerSyslogServers instance;

        public LogAnalyzerSyslogServersTests()
        {
            // TODO uncomment below to create an instance of LogAnalyzerSyslogServers
            //instance = new LogAnalyzerSyslogServers();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogAnalyzerSyslogServers
        /// </summary>
        [Fact]
        public void LogAnalyzerSyslogServersInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogAnalyzerSyslogServers
            //Assert.IsType<LogAnalyzerSyslogServers>(instance);
        }

        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Fact]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
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
        /// Test the property 'Profile'
        /// </summary>
        [Fact]
        public void ProfileTest()
        {
            // TODO unit test for the property 'Profile'
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
        /// Test the property 'Facility'
        /// </summary>
        [Fact]
        public void FacilityTest()
        {
            // TODO unit test for the property 'Facility'
        }

        /// <summary>
        /// Test the property 'Format'
        /// </summary>
        [Fact]
        public void FormatTest()
        {
            // TODO unit test for the property 'Format'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }

        /// <summary>
        /// Test the property 'EventRateLimiting'
        /// </summary>
        [Fact]
        public void EventRateLimitingTest()
        {
            // TODO unit test for the property 'EventRateLimiting'
        }

        /// <summary>
        /// Test the property 'DataRateLimiting'
        /// </summary>
        [Fact]
        public void DataRateLimitingTest()
        {
            // TODO unit test for the property 'DataRateLimiting'
        }

        /// <summary>
        /// Test the property 'OutboundInterface'
        /// </summary>
        [Fact]
        public void OutboundInterfaceTest()
        {
            // TODO unit test for the property 'OutboundInterface'
        }

        /// <summary>
        /// Test the property 'LocalInterface'
        /// </summary>
        [Fact]
        public void LocalInterfaceTest()
        {
            // TODO unit test for the property 'LocalInterface'
        }
    }
}