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
    ///  Class for testing DiagAdvancedFirewallDiagAdvancedFirewall
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedFirewallDiagAdvancedFirewallTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedFirewallDiagAdvancedFirewall
        //private DiagAdvancedFirewallDiagAdvancedFirewall instance;

        public DiagAdvancedFirewallDiagAdvancedFirewallTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedFirewallDiagAdvancedFirewall
            //instance = new DiagAdvancedFirewallDiagAdvancedFirewall();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedFirewallDiagAdvancedFirewall
        /// </summary>
        [Fact]
        public void DiagAdvancedFirewallDiagAdvancedFirewallInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedFirewallDiagAdvancedFirewall
            //Assert.IsType<DiagAdvancedFirewallDiagAdvancedFirewall>(instance);
        }

        /// <summary>
        /// Test the property 'KillCacheNoDelay'
        /// </summary>
        [Fact]
        public void KillCacheNoDelayTest()
        {
            // TODO unit test for the property 'KillCacheNoDelay'
        }

        /// <summary>
        /// Test the property 'FtpBounceAttackProtection'
        /// </summary>
        [Fact]
        public void FtpBounceAttackProtectionTest()
        {
            // TODO unit test for the property 'FtpBounceAttackProtection'
        }

        /// <summary>
        /// Test the property 'FtpProtocolAnomalyAttackProtection'
        /// </summary>
        [Fact]
        public void FtpProtocolAnomalyAttackProtectionTest()
        {
            // TODO unit test for the property 'FtpProtocolAnomalyAttackProtection'
        }

        /// <summary>
        /// Test the property 'OrphanDataConnection'
        /// </summary>
        [Fact]
        public void OrphanDataConnectionTest()
        {
            // TODO unit test for the property 'OrphanDataConnection'
        }

        /// <summary>
        /// Test the property 'AllowZeroPort'
        /// </summary>
        [Fact]
        public void AllowZeroPortTest()
        {
            // TODO unit test for the property 'AllowZeroPort'
        }

        /// <summary>
        /// Test the property 'IpSpoofChecking'
        /// </summary>
        [Fact]
        public void IpSpoofCheckingTest()
        {
            // TODO unit test for the property 'IpSpoofChecking'
        }

        /// <summary>
        /// Test the property 'PortScanDetection'
        /// </summary>
        [Fact]
        public void PortScanDetectionTest()
        {
            // TODO unit test for the property 'PortScanDetection'
        }

        /// <summary>
        /// Test the property 'UcaplCompliance'
        /// </summary>
        [Fact]
        public void UcaplComplianceTest()
        {
            // TODO unit test for the property 'UcaplCompliance'
        }

        /// <summary>
        /// Test the property 'AnticipatedConnectionTimeout'
        /// </summary>
        [Fact]
        public void AnticipatedConnectionTimeoutTest()
        {
            // TODO unit test for the property 'AnticipatedConnectionTimeout'
        }

        /// <summary>
        /// Test the property 'AnticipatedConnectionParentTermination'
        /// </summary>
        [Fact]
        public void AnticipatedConnectionParentTerminationTest()
        {
            // TODO unit test for the property 'AnticipatedConnectionParentTermination'
        }

        /// <summary>
        /// Test the property 'CacheIgnoreIcmpReject'
        /// </summary>
        [Fact]
        public void CacheIgnoreIcmpRejectTest()
        {
            // TODO unit test for the property 'CacheIgnoreIcmpReject'
        }

        /// <summary>
        /// Test the property 'AnticipatedMediaTimeout'
        /// </summary>
        [Fact]
        public void AnticipatedMediaTimeoutTest()
        {
            // TODO unit test for the property 'AnticipatedMediaTimeout'
        }

        /// <summary>
        /// Test the property 'AnticipatedMediaParentTermination'
        /// </summary>
        [Fact]
        public void AnticipatedMediaParentTerminationTest()
        {
            // TODO unit test for the property 'AnticipatedMediaParentTermination'
        }

        /// <summary>
        /// Test the property 'TraceConnectionsPort'
        /// </summary>
        [Fact]
        public void TraceConnectionsPortTest()
        {
            // TODO unit test for the property 'TraceConnectionsPort'
        }

        /// <summary>
        /// Test the property 'IncludeTcpDataConnection'
        /// </summary>
        [Fact]
        public void IncludeTcpDataConnectionTest()
        {
            // TODO unit test for the property 'IncludeTcpDataConnection'
        }

        /// <summary>
        /// Test the property 'TrackBandwidthUsage'
        /// </summary>
        [Fact]
        public void TrackBandwidthUsageTest()
        {
            // TODO unit test for the property 'TrackBandwidthUsage'
        }

        /// <summary>
        /// Test the property 'DecreaseConnectionCountAfterClose'
        /// </summary>
        [Fact]
        public void DecreaseConnectionCountAfterCloseTest()
        {
            // TODO unit test for the property 'DecreaseConnectionCountAfterClose'
        }

        /// <summary>
        /// Test the property 'CsrfTokenValidation'
        /// </summary>
        [Fact]
        public void CsrfTokenValidationTest()
        {
            // TODO unit test for the property 'CsrfTokenValidation'
        }

        /// <summary>
        /// Test the property 'SecureSessionIdCookie'
        /// </summary>
        [Fact]
        public void SecureSessionIdCookieTest()
        {
            // TODO unit test for the property 'SecureSessionIdCookie'
        }

        /// <summary>
        /// Test the property 'TcpStateManipulationDosProtection'
        /// </summary>
        [Fact]
        public void TcpStateManipulationDosProtectionTest()
        {
            // TODO unit test for the property 'TcpStateManipulationDosProtection'
        }

        /// <summary>
        /// Test the property 'SequentialAddresses'
        /// </summary>
        [Fact]
        public void SequentialAddressesTest()
        {
            // TODO unit test for the property 'SequentialAddresses'
        }

        /// <summary>
        /// Test the property 'DefaultPolicyEditable'
        /// </summary>
        [Fact]
        public void DefaultPolicyEditableTest()
        {
            // TODO unit test for the property 'DefaultPolicyEditable'
        }

        /// <summary>
        /// Test the property 'AutoAddedNatPolicyDisabling'
        /// </summary>
        [Fact]
        public void AutoAddedNatPolicyDisablingTest()
        {
            // TODO unit test for the property 'AutoAddedNatPolicyDisabling'
        }

        /// <summary>
        /// Test the property 'UdpIcmpFloodDetecting'
        /// </summary>
        [Fact]
        public void UdpIcmpFloodDetectingTest()
        {
            // TODO unit test for the property 'UdpIcmpFloodDetecting'
        }

        /// <summary>
        /// Test the property 'ControlPanelFloodProtection'
        /// </summary>
        [Fact]
        public void ControlPanelFloodProtectionTest()
        {
            // TODO unit test for the property 'ControlPanelFloodProtection'
        }

        /// <summary>
        /// Test the property 'UdpIcmpFloodProtection'
        /// </summary>
        [Fact]
        public void UdpIcmpFloodProtectionTest()
        {
            // TODO unit test for the property 'UdpIcmpFloodProtection'
        }

        /// <summary>
        /// Test the property 'SystemOverloadProtection'
        /// </summary>
        [Fact]
        public void SystemOverloadProtectionTest()
        {
            // TODO unit test for the property 'SystemOverloadProtection'
        }

        /// <summary>
        /// Test the property 'SystemOverloadThreshold'
        /// </summary>
        [Fact]
        public void SystemOverloadThresholdTest()
        {
            // TODO unit test for the property 'SystemOverloadThreshold'
        }

        /// <summary>
        /// Test the property 'BypassVpnTraffic'
        /// </summary>
        [Fact]
        public void BypassVpnTrafficTest()
        {
            // TODO unit test for the property 'BypassVpnTraffic'
        }

        /// <summary>
        /// Test the property 'LogObjectName'
        /// </summary>
        [Fact]
        public void LogObjectNameTest()
        {
            // TODO unit test for the property 'LogObjectName'
        }

        /// <summary>
        /// Test the property 'PoliciesConnectionLimitation'
        /// </summary>
        [Fact]
        public void PoliciesConnectionLimitationTest()
        {
            // TODO unit test for the property 'PoliciesConnectionLimitation'
        }

        /// <summary>
        /// Test the property 'ResetLoginCounter'
        /// </summary>
        [Fact]
        public void ResetLoginCounterTest()
        {
            // TODO unit test for the property 'ResetLoginCounter'
        }

        /// <summary>
        /// Test the property 'SendRstOnTimeout'
        /// </summary>
        [Fact]
        public void SendRstOnTimeoutTest()
        {
            // TODO unit test for the property 'SendRstOnTimeout'
        }

        /// <summary>
        /// Test the property 'AsyncSaveFlashPeriod'
        /// </summary>
        [Fact]
        public void AsyncSaveFlashPeriodTest()
        {
            // TODO unit test for the property 'AsyncSaveFlashPeriod'
        }
    }
}