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
    ///  Class for testing ShowStatusSystemDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusSystemDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusSystemDetail
        //private ShowStatusSystemDetail instance;

        public ShowStatusSystemDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusSystemDetail
            //instance = new ShowStatusSystemDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusSystemDetail
        /// </summary>
        [Fact]
        public void ShowStatusSystemDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusSystemDetail
            //Assert.IsType<ShowStatusSystemDetail>(instance);
        }

        /// <summary>
        /// Test the property 'Model'
        /// </summary>
        [Fact]
        public void ModelTest()
        {
            // TODO unit test for the property 'Model'
        }

        /// <summary>
        /// Test the property 'ProductCode'
        /// </summary>
        [Fact]
        public void ProductCodeTest()
        {
            // TODO unit test for the property 'ProductCode'
        }

        /// <summary>
        /// Test the property 'FirewallName'
        /// </summary>
        [Fact]
        public void FirewallNameTest()
        {
            // TODO unit test for the property 'FirewallName'
        }

        /// <summary>
        /// Test the property 'Guid'
        /// </summary>
        [Fact]
        public void GuidTest()
        {
            // TODO unit test for the property 'Guid'
        }

        /// <summary>
        /// Test the property 'SerialNumber'
        /// </summary>
        [Fact]
        public void SerialNumberTest()
        {
            // TODO unit test for the property 'SerialNumber'
        }

        /// <summary>
        /// Test the property 'AuthenticationCode'
        /// </summary>
        [Fact]
        public void AuthenticationCodeTest()
        {
            // TODO unit test for the property 'AuthenticationCode'
        }

        /// <summary>
        /// Test the property 'FirmwareVersion'
        /// </summary>
        [Fact]
        public void FirmwareVersionTest()
        {
            // TODO unit test for the property 'FirmwareVersion'
        }

        /// <summary>
        /// Test the property 'SafemodeVersion'
        /// </summary>
        [Fact]
        public void SafemodeVersionTest()
        {
            // TODO unit test for the property 'SafemodeVersion'
        }

        /// <summary>
        /// Test the property 'RomVersion'
        /// </summary>
        [Fact]
        public void RomVersionTest()
        {
            // TODO unit test for the property 'RomVersion'
        }

        /// <summary>
        /// Test the property 'SystemTime'
        /// </summary>
        [Fact]
        public void SystemTimeTest()
        {
            // TODO unit test for the property 'SystemTime'
        }

        /// <summary>
        /// Test the property 'UpTime'
        /// </summary>
        [Fact]
        public void UpTimeTest()
        {
            // TODO unit test for the property 'UpTime'
        }

        /// <summary>
        /// Test the property 'PrimaryWan'
        /// </summary>
        [Fact]
        public void PrimaryWanTest()
        {
            // TODO unit test for the property 'PrimaryWan'
        }

        /// <summary>
        /// Test the property 'PeakConnections'
        /// </summary>
        [Fact]
        public void PeakConnectionsTest()
        {
            // TODO unit test for the property 'PeakConnections'
        }

        /// <summary>
        /// Test the property 'CurrentConnections'
        /// </summary>
        [Fact]
        public void CurrentConnectionsTest()
        {
            // TODO unit test for the property 'CurrentConnections'
        }

        /// <summary>
        /// Test the property 'MaxAllowedConnections'
        /// </summary>
        [Fact]
        public void MaxAllowedConnectionsTest()
        {
            // TODO unit test for the property 'MaxAllowedConnections'
        }

        /// <summary>
        /// Test the property 'MaxConnections'
        /// </summary>
        [Fact]
        public void MaxConnectionsTest()
        {
            // TODO unit test for the property 'MaxConnections'
        }

        /// <summary>
        /// Test the property 'ConnectionUsage'
        /// </summary>
        [Fact]
        public void ConnectionUsageTest()
        {
            // TODO unit test for the property 'ConnectionUsage'
        }

        /// <summary>
        /// Test the property 'LastModifiedBy'
        /// </summary>
        [Fact]
        public void LastModifiedByTest()
        {
            // TODO unit test for the property 'LastModifiedBy'
        }

        /// <summary>
        /// Test the property 'AssignToken'
        /// </summary>
        [Fact]
        public void AssignTokenTest()
        {
            // TODO unit test for the property 'AssignToken'
        }

        /// <summary>
        /// Test the property 'RegistrationCode'
        /// </summary>
        [Fact]
        public void RegistrationCodeTest()
        {
            // TODO unit test for the property 'RegistrationCode'
        }

        /// <summary>
        /// Test the property 'GlobalMode'
        /// </summary>
        [Fact]
        public void GlobalModeTest()
        {
            // TODO unit test for the property 'GlobalMode'
        }

        /// <summary>
        /// Test the property 'RestartRequired'
        /// </summary>
        [Fact]
        public void RestartRequiredTest()
        {
            // TODO unit test for the property 'RestartRequired'
        }

        /// <summary>
        /// Test the property 'ServiceRemainingMessage'
        /// </summary>
        [Fact]
        public void ServiceRemainingMessageTest()
        {
            // TODO unit test for the property 'ServiceRemainingMessage'
        }
    }
}