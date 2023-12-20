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
    ///  Class for testing ShowStatusPacketMonitorTraceConfigDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusPacketMonitorTraceConfigDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusPacketMonitorTraceConfigDetail
        //private ShowStatusPacketMonitorTraceConfigDetail instance;

        public ShowStatusPacketMonitorTraceConfigDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusPacketMonitorTraceConfigDetail
            //instance = new ShowStatusPacketMonitorTraceConfigDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusPacketMonitorTraceConfigDetail
        /// </summary>
        [Fact]
        public void ShowStatusPacketMonitorTraceConfigDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusPacketMonitorTraceConfigDetail
            //Assert.IsType<ShowStatusPacketMonitorTraceConfigDetail>(instance);
        }

        /// <summary>
        /// Test the property 'MirrorFilteredPacketsToInterface'
        /// </summary>
        [Fact]
        public void MirrorFilteredPacketsToInterfaceTest()
        {
            // TODO unit test for the property 'MirrorFilteredPacketsToInterface'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsOnlyIpPackets'
        /// </summary>
        [Fact]
        public void MirrorSettingsOnlyIpPacketsTest()
        {
            // TODO unit test for the property 'MirrorSettingsOnlyIpPackets'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsInterface'
        /// </summary>
        [Fact]
        public void MirrorSettingsInterfaceTest()
        {
            // TODO unit test for the property 'MirrorSettingsInterface'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsMaxRate'
        /// </summary>
        [Fact]
        public void MirrorSettingsMaxRateTest()
        {
            // TODO unit test for the property 'MirrorSettingsMaxRate'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsForwardInterface'
        /// </summary>
        [Fact]
        public void MirrorSettingsForwardInterfaceTest()
        {
            // TODO unit test for the property 'MirrorSettingsForwardInterface'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsToCaptureBuffer'
        /// </summary>
        [Fact]
        public void MirrorSettingsToCaptureBufferTest()
        {
            // TODO unit test for the property 'MirrorSettingsToCaptureBuffer'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsIp'
        /// </summary>
        [Fact]
        public void MirrorSettingsIpTest()
        {
            // TODO unit test for the property 'MirrorSettingsIp'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsReceiveFromIp'
        /// </summary>
        [Fact]
        public void MirrorSettingsReceiveFromIpTest()
        {
            // TODO unit test for the property 'MirrorSettingsReceiveFromIp'
        }

        /// <summary>
        /// Test the property 'MirrorSettingsEncryptKey'
        /// </summary>
        [Fact]
        public void MirrorSettingsEncryptKeyTest()
        {
            // TODO unit test for the property 'MirrorSettingsEncryptKey'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsWrapBuff'
        /// </summary>
        [Fact]
        public void CaptureSettingsWrapBuffTest()
        {
            // TODO unit test for the property 'CaptureSettingsWrapBuff'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsMulticast'
        /// </summary>
        [Fact]
        public void CaptureSettingsMulticastTest()
        {
            // TODO unit test for the property 'CaptureSettingsMulticast'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsIphelper'
        /// </summary>
        [Fact]
        public void CaptureSettingsIphelperTest()
        {
            // TODO unit test for the property 'CaptureSettingsIphelper'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsReassembled'
        /// </summary>
        [Fact]
        public void CaptureSettingsReassembledTest()
        {
            // TODO unit test for the property 'CaptureSettingsReassembled'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFragmented'
        /// </summary>
        [Fact]
        public void CaptureSettingsFragmentedTest()
        {
            // TODO unit test for the property 'CaptureSettingsFragmented'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsRemoteMirrored'
        /// </summary>
        [Fact]
        public void CaptureSettingsRemoteMirroredTest()
        {
            // TODO unit test for the property 'CaptureSettingsRemoteMirrored'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsIpsec'
        /// </summary>
        [Fact]
        public void CaptureSettingsIpsecTest()
        {
            // TODO unit test for the property 'CaptureSettingsIpsec'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsSsl'
        /// </summary>
        [Fact]
        public void CaptureSettingsSslTest()
        {
            // TODO unit test for the property 'CaptureSettingsSsl'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsRestorePortsSsl'
        /// </summary>
        [Fact]
        public void CaptureSettingsRestorePortsSslTest()
        {
            // TODO unit test for the property 'CaptureSettingsRestorePortsSsl'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpAutomatic'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpAutomaticTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpAutomatic'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpHtml'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpHtmlTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpHtml'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpPcapng'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpPcapngTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpPcapng'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFirewallGenerated'
        /// </summary>
        [Fact]
        public void CaptureSettingsFirewallGeneratedTest()
        {
            // TODO unit test for the property 'CaptureSettingsFirewallGenerated'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsBytesToCapture'
        /// </summary>
        [Fact]
        public void CaptureSettingsBytesToCaptureTest()
        {
            // TODO unit test for the property 'CaptureSettingsBytesToCapture'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpServer'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpServerTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpServer'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpPassword'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpPasswordTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpPassword'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpLogin'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpLoginTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpLogin'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsFtpDirectory'
        /// </summary>
        [Fact]
        public void CaptureSettingsFtpDirectoryTest()
        {
            // TODO unit test for the property 'CaptureSettingsFtpDirectory'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsIntermediate'
        /// </summary>
        [Fact]
        public void CaptureSettingsIntermediateTest()
        {
            // TODO unit test for the property 'CaptureSettingsIntermediate'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsLdapOverTls'
        /// </summary>
        [Fact]
        public void CaptureSettingsLdapOverTlsTest()
        {
            // TODO unit test for the property 'CaptureSettingsLdapOverTls'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsSsoAgent'
        /// </summary>
        [Fact]
        public void CaptureSettingsSsoAgentTest()
        {
            // TODO unit test for the property 'CaptureSettingsSsoAgent'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeManagementHttp'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeManagementHttpTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeManagementHttp'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeManagementSnmp'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeManagementSnmpTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeManagementSnmp'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeManagementSsh'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeManagementSshTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeManagementSsh'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeSyslogServers'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeSyslogServersTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeSyslogServers'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeGmsServer'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeGmsServerTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeGmsServer'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeEncryptedGms'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeEncryptedGmsTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeEncryptedGms'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeEncryptedMgms'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeEncryptedMgmsTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeEncryptedMgms'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeInternalTrafficHa'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeInternalTrafficHaTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeInternalTrafficHa'
        }

        /// <summary>
        /// Test the property 'CaptureSettingsExcludeInternalTrafficSonicpoint'
        /// </summary>
        [Fact]
        public void CaptureSettingsExcludeInternalTrafficSonicpointTest()
        {
            // TODO unit test for the property 'CaptureSettingsExcludeInternalTrafficSonicpoint'
        }

        /// <summary>
        /// Test the property 'CaptureFilterInterfaceName'
        /// </summary>
        [Fact]
        public void CaptureFilterInterfaceNameTest()
        {
            // TODO unit test for the property 'CaptureFilterInterfaceName'
        }

        /// <summary>
        /// Test the property 'CaptureFilterEtherType'
        /// </summary>
        [Fact]
        public void CaptureFilterEtherTypeTest()
        {
            // TODO unit test for the property 'CaptureFilterEtherType'
        }

        /// <summary>
        /// Test the property 'CaptureFilterIpType'
        /// </summary>
        [Fact]
        public void CaptureFilterIpTypeTest()
        {
            // TODO unit test for the property 'CaptureFilterIpType'
        }

        /// <summary>
        /// Test the property 'CaptureFilterSourceIp'
        /// </summary>
        [Fact]
        public void CaptureFilterSourceIpTest()
        {
            // TODO unit test for the property 'CaptureFilterSourceIp'
        }

        /// <summary>
        /// Test the property 'CaptureFilterSourcePort'
        /// </summary>
        [Fact]
        public void CaptureFilterSourcePortTest()
        {
            // TODO unit test for the property 'CaptureFilterSourcePort'
        }

        /// <summary>
        /// Test the property 'CaptureFilterDestinationIp'
        /// </summary>
        [Fact]
        public void CaptureFilterDestinationIpTest()
        {
            // TODO unit test for the property 'CaptureFilterDestinationIp'
        }

        /// <summary>
        /// Test the property 'CaptureFilterDestinationPort'
        /// </summary>
        [Fact]
        public void CaptureFilterDestinationPortTest()
        {
            // TODO unit test for the property 'CaptureFilterDestinationPort'
        }

        /// <summary>
        /// Test the property 'CaptureFilterFirewallRule'
        /// </summary>
        [Fact]
        public void CaptureFilterFirewallRuleTest()
        {
            // TODO unit test for the property 'CaptureFilterFirewallRule'
        }

        /// <summary>
        /// Test the property 'CaptureFilterBidirectional'
        /// </summary>
        [Fact]
        public void CaptureFilterBidirectionalTest()
        {
            // TODO unit test for the property 'CaptureFilterBidirectional'
        }

        /// <summary>
        /// Test the property 'CaptureFilterForwarded'
        /// </summary>
        [Fact]
        public void CaptureFilterForwardedTest()
        {
            // TODO unit test for the property 'CaptureFilterForwarded'
        }

        /// <summary>
        /// Test the property 'CaptureFilterGenerated'
        /// </summary>
        [Fact]
        public void CaptureFilterGeneratedTest()
        {
            // TODO unit test for the property 'CaptureFilterGenerated'
        }

        /// <summary>
        /// Test the property 'CaptureFilterConsumed'
        /// </summary>
        [Fact]
        public void CaptureFilterConsumedTest()
        {
            // TODO unit test for the property 'CaptureFilterConsumed'
        }

        /// <summary>
        /// Test the property 'CaptureFilterDropped'
        /// </summary>
        [Fact]
        public void CaptureFilterDroppedTest()
        {
            // TODO unit test for the property 'CaptureFilterDropped'
        }

        /// <summary>
        /// Test the property 'InterfaceName'
        /// </summary>
        [Fact]
        public void InterfaceNameTest()
        {
            // TODO unit test for the property 'InterfaceName'
        }

        /// <summary>
        /// Test the property 'DisplayFilterEtherType'
        /// </summary>
        [Fact]
        public void DisplayFilterEtherTypeTest()
        {
            // TODO unit test for the property 'DisplayFilterEtherType'
        }

        /// <summary>
        /// Test the property 'DisplayFilterIpType'
        /// </summary>
        [Fact]
        public void DisplayFilterIpTypeTest()
        {
            // TODO unit test for the property 'DisplayFilterIpType'
        }

        /// <summary>
        /// Test the property 'DisplayFilterSourceIp'
        /// </summary>
        [Fact]
        public void DisplayFilterSourceIpTest()
        {
            // TODO unit test for the property 'DisplayFilterSourceIp'
        }

        /// <summary>
        /// Test the property 'DisplayFilterSourcePort'
        /// </summary>
        [Fact]
        public void DisplayFilterSourcePortTest()
        {
            // TODO unit test for the property 'DisplayFilterSourcePort'
        }

        /// <summary>
        /// Test the property 'DisplayFilterDestinationIp'
        /// </summary>
        [Fact]
        public void DisplayFilterDestinationIpTest()
        {
            // TODO unit test for the property 'DisplayFilterDestinationIp'
        }

        /// <summary>
        /// Test the property 'DisplayFilterDestinationPort'
        /// </summary>
        [Fact]
        public void DisplayFilterDestinationPortTest()
        {
            // TODO unit test for the property 'DisplayFilterDestinationPort'
        }

        /// <summary>
        /// Test the property 'DisplayFilterBidirectional'
        /// </summary>
        [Fact]
        public void DisplayFilterBidirectionalTest()
        {
            // TODO unit test for the property 'DisplayFilterBidirectional'
        }

        /// <summary>
        /// Test the property 'DisplayFilterForwarded'
        /// </summary>
        [Fact]
        public void DisplayFilterForwardedTest()
        {
            // TODO unit test for the property 'DisplayFilterForwarded'
        }

        /// <summary>
        /// Test the property 'DisplayFilterGenerated'
        /// </summary>
        [Fact]
        public void DisplayFilterGeneratedTest()
        {
            // TODO unit test for the property 'DisplayFilterGenerated'
        }

        /// <summary>
        /// Test the property 'DisplayFilterConsumed'
        /// </summary>
        [Fact]
        public void DisplayFilterConsumedTest()
        {
            // TODO unit test for the property 'DisplayFilterConsumed'
        }

        /// <summary>
        /// Test the property 'DisplayFilterDropped'
        /// </summary>
        [Fact]
        public void DisplayFilterDroppedTest()
        {
            // TODO unit test for the property 'DisplayFilterDropped'
        }
    }
}
