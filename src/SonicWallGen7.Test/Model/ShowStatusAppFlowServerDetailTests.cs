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
    ///  Class for testing ShowStatusAppFlowServerDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusAppFlowServerDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusAppFlowServerDetail
        //private ShowStatusAppFlowServerDetail instance;

        public ShowStatusAppFlowServerDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusAppFlowServerDetail
            //instance = new ShowStatusAppFlowServerDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusAppFlowServerDetail
        /// </summary>
        [Fact]
        public void ShowStatusAppFlowServerDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusAppFlowServerDetail
            //Assert.IsType<ShowStatusAppFlowServerDetail>(instance);
        }

        /// <summary>
        /// Test the property 'HostName'
        /// </summary>
        [Fact]
        public void HostNameTest()
        {
            // TODO unit test for the property 'HostName'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            // TODO unit test for the property 'Revision'
        }

        /// <summary>
        /// Test the property 'ConnectionStatus'
        /// </summary>
        [Fact]
        public void ConnectionStatusTest()
        {
            // TODO unit test for the property 'ConnectionStatus'
        }

        /// <summary>
        /// Test the property 'RegistrationStatus'
        /// </summary>
        [Fact]
        public void RegistrationStatusTest()
        {
            // TODO unit test for the property 'RegistrationStatus'
        }

        /// <summary>
        /// Test the property 'MemoryPoolSize'
        /// </summary>
        [Fact]
        public void MemoryPoolSizeTest()
        {
            // TODO unit test for the property 'MemoryPoolSize'
        }

        /// <summary>
        /// Test the property 'DumpPeriod'
        /// </summary>
        [Fact]
        public void DumpPeriodTest()
        {
            // TODO unit test for the property 'DumpPeriod'
        }

        /// <summary>
        /// Test the property 'SerialExists'
        /// </summary>
        [Fact]
        public void SerialExistsTest()
        {
            // TODO unit test for the property 'SerialExists'
        }

        /// <summary>
        /// Test the property 'MaxDb'
        /// </summary>
        [Fact]
        public void MaxDbTest()
        {
            // TODO unit test for the property 'MaxDb'
        }

        /// <summary>
        /// Test the property 'SerialCount'
        /// </summary>
        [Fact]
        public void SerialCountTest()
        {
            // TODO unit test for the property 'SerialCount'
        }

        /// <summary>
        /// Test the property 'LastSeen'
        /// </summary>
        [Fact]
        public void LastSeenTest()
        {
            // TODO unit test for the property 'LastSeen'
        }

        /// <summary>
        /// Test the property 'LastConfig'
        /// </summary>
        [Fact]
        public void LastConfigTest()
        {
            // TODO unit test for the property 'LastConfig'
        }

        /// <summary>
        /// Test the property 'AppServerStartTime'
        /// </summary>
        [Fact]
        public void AppServerStartTimeTest()
        {
            // TODO unit test for the property 'AppServerStartTime'
        }

        /// <summary>
        /// Test the property 'RecordRate'
        /// </summary>
        [Fact]
        public void RecordRateTest()
        {
            // TODO unit test for the property 'RecordRate'
        }

        /// <summary>
        /// Test the property 'PacketRate'
        /// </summary>
        [Fact]
        public void PacketRateTest()
        {
            // TODO unit test for the property 'PacketRate'
        }

        /// <summary>
        /// Test the property 'MaxDbFiles'
        /// </summary>
        [Fact]
        public void MaxDbFilesTest()
        {
            // TODO unit test for the property 'MaxDbFiles'
        }

        /// <summary>
        /// Test the property 'CurrentDbFiles'
        /// </summary>
        [Fact]
        public void CurrentDbFilesTest()
        {
            // TODO unit test for the property 'CurrentDbFiles'
        }
    }
}
