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
    ///  Class for testing PoliciesSettingBasePoliciesSetting
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PoliciesSettingBasePoliciesSettingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PoliciesSettingBasePoliciesSetting
        //private PoliciesSettingBasePoliciesSetting instance;

        public PoliciesSettingBasePoliciesSettingTests()
        {
            // TODO uncomment below to create an instance of PoliciesSettingBasePoliciesSetting
            //instance = new PoliciesSettingBasePoliciesSetting();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PoliciesSettingBasePoliciesSetting
        /// </summary>
        [Fact]
        public void PoliciesSettingBasePoliciesSettingInstanceTest()
        {
            // TODO uncomment below to test "IsType" PoliciesSettingBasePoliciesSetting
            //Assert.IsType<PoliciesSettingBasePoliciesSetting>(instance);
        }

        /// <summary>
        /// Test the property 'BlockConnections'
        /// </summary>
        [Fact]
        public void BlockConnectionsTest()
        {
            // TODO unit test for the property 'BlockConnections'
        }

        /// <summary>
        /// Test the property 'ActiveApplicationCaching'
        /// </summary>
        [Fact]
        public void ActiveApplicationCachingTest()
        {
            // TODO unit test for the property 'ActiveApplicationCaching'
        }

        /// <summary>
        /// Test the property 'CachedApplicationBypass'
        /// </summary>
        [Fact]
        public void CachedApplicationBypassTest()
        {
            // TODO unit test for the property 'CachedApplicationBypass'
        }

        /// <summary>
        /// Test the property 'ApplicationCache'
        /// </summary>
        [Fact]
        public void ApplicationCacheTest()
        {
            // TODO unit test for the property 'ApplicationCache'
        }

        /// <summary>
        /// Test the property 'SslServerInspection'
        /// </summary>
        [Fact]
        public void SslServerInspectionTest()
        {
            // TODO unit test for the property 'SslServerInspection'
        }

        /// <summary>
        /// Test the property 'BypassDecryption'
        /// </summary>
        [Fact]
        public void BypassDecryptionTest()
        {
            // TODO unit test for the property 'BypassDecryption'
        }

        /// <summary>
        /// Test the property 'PolicyBasedDosProtection'
        /// </summary>
        [Fact]
        public void PolicyBasedDosProtectionTest()
        {
            // TODO unit test for the property 'PolicyBasedDosProtection'
        }

        /// <summary>
        /// Test the property 'AppCustomMalwareMode'
        /// </summary>
        [Fact]
        public void AppCustomMalwareModeTest()
        {
            // TODO unit test for the property 'AppCustomMalwareMode'
        }

        /// <summary>
        /// Test the property 'ApplicationBasedOn'
        /// </summary>
        [Fact]
        public void ApplicationBasedOnTest()
        {
            // TODO unit test for the property 'ApplicationBasedOn'
        }

        /// <summary>
        /// Test the property 'ThreatBasedOn'
        /// </summary>
        [Fact]
        public void ThreatBasedOnTest()
        {
            // TODO unit test for the property 'ThreatBasedOn'
        }

        /// <summary>
        /// Test the property 'AntispywareBasedOn'
        /// </summary>
        [Fact]
        public void AntispywareBasedOnTest()
        {
            // TODO unit test for the property 'AntispywareBasedOn'
        }

        /// <summary>
        /// Test the property 'AntivirusBasedOn'
        /// </summary>
        [Fact]
        public void AntivirusBasedOnTest()
        {
            // TODO unit test for the property 'AntivirusBasedOn'
        }

        /// <summary>
        /// Test the property 'GeoipMode'
        /// </summary>
        [Fact]
        public void GeoipModeTest()
        {
            // TODO unit test for the property 'GeoipMode'
        }

        /// <summary>
        /// Test the property 'GeoipInspectionBasedOn'
        /// </summary>
        [Fact]
        public void GeoipInspectionBasedOnTest()
        {
            // TODO unit test for the property 'GeoipInspectionBasedOn'
        }

        /// <summary>
        /// Test the property 'BotnetMode'
        /// </summary>
        [Fact]
        public void BotnetModeTest()
        {
            // TODO unit test for the property 'BotnetMode'
        }

        /// <summary>
        /// Test the property 'DpisslMode'
        /// </summary>
        [Fact]
        public void DpisslModeTest()
        {
            // TODO unit test for the property 'DpisslMode'
        }

        /// <summary>
        /// Test the property 'DpisshMode'
        /// </summary>
        [Fact]
        public void DpisshModeTest()
        {
            // TODO unit test for the property 'DpisshMode'
        }

        /// <summary>
        /// Test the property 'DosMode'
        /// </summary>
        [Fact]
        public void DosModeTest()
        {
            // TODO unit test for the property 'DosMode'
        }

        /// <summary>
        /// Test the property 'SynFlood'
        /// </summary>
        [Fact]
        public void SynFloodTest()
        {
            // TODO unit test for the property 'SynFlood'
        }

        /// <summary>
        /// Test the property 'UdpFlood'
        /// </summary>
        [Fact]
        public void UdpFloodTest()
        {
            // TODO unit test for the property 'UdpFlood'
        }

        /// <summary>
        /// Test the property 'IcmpFlood'
        /// </summary>
        [Fact]
        public void IcmpFloodTest()
        {
            // TODO unit test for the property 'IcmpFlood'
        }

        /// <summary>
        /// Test the property 'Attack'
        /// </summary>
        [Fact]
        public void AttackTest()
        {
            // TODO unit test for the property 'Attack'
        }

        /// <summary>
        /// Test the property 'Ddos'
        /// </summary>
        [Fact]
        public void DdosTest()
        {
            // TODO unit test for the property 'Ddos'
        }

        /// <summary>
        /// Test the property 'ThreatProfileForZone'
        /// </summary>
        [Fact]
        public void ThreatProfileForZoneTest()
        {
            // TODO unit test for the property 'ThreatProfileForZone'
        }

        /// <summary>
        /// Test the property 'AntispywareProfileForZone'
        /// </summary>
        [Fact]
        public void AntispywareProfileForZoneTest()
        {
            // TODO unit test for the property 'AntispywareProfileForZone'
        }

        /// <summary>
        /// Test the property 'AntivirusProfileForZone'
        /// </summary>
        [Fact]
        public void AntivirusProfileForZoneTest()
        {
            // TODO unit test for the property 'AntivirusProfileForZone'
        }
    }
}