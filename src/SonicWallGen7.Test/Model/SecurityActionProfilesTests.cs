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
    ///  Class for testing SecurityActionProfiles
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SecurityActionProfilesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecurityActionProfiles
        //private SecurityActionProfiles instance;

        public SecurityActionProfilesTests()
        {
            // TODO uncomment below to create an instance of SecurityActionProfiles
            //instance = new SecurityActionProfiles();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityActionProfiles
        /// </summary>
        [Fact]
        public void SecurityActionProfilesInstanceTest()
        {
            // TODO uncomment below to test "IsType" SecurityActionProfiles
            //Assert.IsType<SecurityActionProfiles>(instance);
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
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

        /// <summary>
        /// Test the property 'BandwidthManagement'
        /// </summary>
        [Fact]
        public void BandwidthManagementTest()
        {
            // TODO unit test for the property 'BandwidthManagement'
        }

        /// <summary>
        /// Test the property 'QualityOfService'
        /// </summary>
        [Fact]
        public void QualityOfServiceTest()
        {
            // TODO unit test for the property 'QualityOfService'
        }

        /// <summary>
        /// Test the property 'CosOverride'
        /// </summary>
        [Fact]
        public void CosOverrideTest()
        {
            // TODO unit test for the property 'CosOverride'
        }

        /// <summary>
        /// Test the property 'GatewayAntivirus'
        /// </summary>
        [Fact]
        public void GatewayAntivirusTest()
        {
            // TODO unit test for the property 'GatewayAntivirus'
        }

        /// <summary>
        /// Test the property 'Threat'
        /// </summary>
        [Fact]
        public void ThreatTest()
        {
            // TODO unit test for the property 'Threat'
        }

        /// <summary>
        /// Test the property 'AntiSpyware'
        /// </summary>
        [Fact]
        public void AntiSpywareTest()
        {
            // TODO unit test for the property 'AntiSpyware'
        }

        /// <summary>
        /// Test the property 'Botnet'
        /// </summary>
        [Fact]
        public void BotnetTest()
        {
            // TODO unit test for the property 'Botnet'
        }

        /// <summary>
        /// Test the property 'ContentFilter'
        /// </summary>
        [Fact]
        public void ContentFilterTest()
        {
            // TODO unit test for the property 'ContentFilter'
        }

        /// <summary>
        /// Test the property 'Reporting'
        /// </summary>
        [Fact]
        public void ReportingTest()
        {
            // TODO unit test for the property 'Reporting'
        }

        /// <summary>
        /// Test the property 'UserActions'
        /// </summary>
        [Fact]
        public void UserActionsTest()
        {
            // TODO unit test for the property 'UserActions'
        }

        /// <summary>
        /// Test the property 'Tcp'
        /// </summary>
        [Fact]
        public void TcpTest()
        {
            // TODO unit test for the property 'Tcp'
        }

        /// <summary>
        /// Test the property 'Udp'
        /// </summary>
        [Fact]
        public void UdpTest()
        {
            // TODO unit test for the property 'Udp'
        }

        /// <summary>
        /// Test the property 'Fragments'
        /// </summary>
        [Fact]
        public void FragmentsTest()
        {
            // TODO unit test for the property 'Fragments'
        }

        /// <summary>
        /// Test the property 'BypassServerToClientInspection'
        /// </summary>
        [Fact]
        public void BypassServerToClientInspectionTest()
        {
            // TODO unit test for the property 'BypassServerToClientInspection'
        }

        /// <summary>
        /// Test the property 'Sip'
        /// </summary>
        [Fact]
        public void SipTest()
        {
            // TODO unit test for the property 'Sip'
        }

        /// <summary>
        /// Test the property 'H323'
        /// </summary>
        [Fact]
        public void H323Test()
        {
            // TODO unit test for the property 'H323'
        }

        /// <summary>
        /// Test the property 'UnauthenticatedRedirect'
        /// </summary>
        [Fact]
        public void UnauthenticatedRedirectTest()
        {
            // TODO unit test for the property 'UnauthenticatedRedirect'
        }

        /// <summary>
        /// Test the property 'PacketDissectionFilter'
        /// </summary>
        [Fact]
        public void PacketDissectionFilterTest()
        {
            // TODO unit test for the property 'PacketDissectionFilter'
        }
    }
}