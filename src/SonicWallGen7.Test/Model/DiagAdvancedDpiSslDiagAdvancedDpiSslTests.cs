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
    ///  Class for testing DiagAdvancedDpiSslDiagAdvancedDpiSsl
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedDpiSslDiagAdvancedDpiSslTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedDpiSslDiagAdvancedDpiSsl
        //private DiagAdvancedDpiSslDiagAdvancedDpiSsl instance;

        public DiagAdvancedDpiSslDiagAdvancedDpiSslTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedDpiSslDiagAdvancedDpiSsl
            //instance = new DiagAdvancedDpiSslDiagAdvancedDpiSsl();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedDpiSslDiagAdvancedDpiSsl
        /// </summary>
        [Fact]
        public void DiagAdvancedDpiSslDiagAdvancedDpiSslInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedDpiSslDiagAdvancedDpiSsl
            //Assert.IsType<DiagAdvancedDpiSslDiagAdvancedDpiSsl>(instance);
        }

        /// <summary>
        /// Test the property 'RewrittenCertificateSnModifier'
        /// </summary>
        [Fact]
        public void RewrittenCertificateSnModifierTest()
        {
            // TODO unit test for the property 'RewrittenCertificateSnModifier'
        }

        /// <summary>
        /// Test the property 'ClientSpoofedCertificateCaching'
        /// </summary>
        [Fact]
        public void ClientSpoofedCertificateCachingTest()
        {
            // TODO unit test for the property 'ClientSpoofedCertificateCaching'
        }

        /// <summary>
        /// Test the property 'RemoveTcpTimestampOption'
        /// </summary>
        [Fact]
        public void RemoveTcpTimestampOptionTest()
        {
            // TODO unit test for the property 'RemoveTcpTimestampOption'
        }

        /// <summary>
        /// Test the property 'DropSslOnLowMemory'
        /// </summary>
        [Fact]
        public void DropSslOnLowMemoryTest()
        {
            // TODO unit test for the property 'DropSslOnLowMemory'
        }

        /// <summary>
        /// Test the property 'DpiSslSignedCertificateTrust'
        /// </summary>
        [Fact]
        public void DpiSslSignedCertificateTrustTest()
        {
            // TODO unit test for the property 'DpiSslSignedCertificateTrust'
        }

        /// <summary>
        /// Test the property 'ProxylessSslWhenLimitExceeded'
        /// </summary>
        [Fact]
        public void ProxylessSslWhenLimitExceededTest()
        {
            // TODO unit test for the property 'ProxylessSslWhenLimitExceeded'
        }

        /// <summary>
        /// Test the property 'ServerFacingSessionReuse'
        /// </summary>
        [Fact]
        public void ServerFacingSessionReuseTest()
        {
            // TODO unit test for the property 'ServerFacingSessionReuse'
        }

        /// <summary>
        /// Test the property 'ClientFacingSessionReuse'
        /// </summary>
        [Fact]
        public void ClientFacingSessionReuseTest()
        {
            // TODO unit test for the property 'ClientFacingSessionReuse'
        }

        /// <summary>
        /// Test the property 'IpBasedExclusionCache'
        /// </summary>
        [Fact]
        public void IpBasedExclusionCacheTest()
        {
            // TODO unit test for the property 'IpBasedExclusionCache'
        }

        /// <summary>
        /// Test the property 'Use2048BitCertificateKey'
        /// </summary>
        [Fact]
        public void Use2048BitCertificateKeyTest()
        {
            // TODO unit test for the property 'Use2048BitCertificateKey'
        }

        /// <summary>
        /// Test the property 'DynamicExclusionForExcludedConnections'
        /// </summary>
        [Fact]
        public void DynamicExclusionForExcludedConnectionsTest()
        {
            // TODO unit test for the property 'DynamicExclusionForExcludedConnections'
        }

        /// <summary>
        /// Test the property 'ConnectionFailures'
        /// </summary>
        [Fact]
        public void ConnectionFailuresTest()
        {
            // TODO unit test for the property 'ConnectionFailures'
        }

        /// <summary>
        /// Test the property 'RevocationCheckServerCerificate'
        /// </summary>
        [Fact]
        public void RevocationCheckServerCerificateTest()
        {
            // TODO unit test for the property 'RevocationCheckServerCerificate'
        }

        /// <summary>
        /// Test the property 'ExpiredCertificateAuthority'
        /// </summary>
        [Fact]
        public void ExpiredCertificateAuthorityTest()
        {
            // TODO unit test for the property 'ExpiredCertificateAuthority'
        }

        /// <summary>
        /// Test the property 'DpiSslExtendedMemory'
        /// </summary>
        [Fact]
        public void DpiSslExtendedMemoryTest()
        {
            // TODO unit test for the property 'DpiSslExtendedMemory'
        }

        /// <summary>
        /// Test the property 'EndpointTcpWindowSetup'
        /// </summary>
        [Fact]
        public void EndpointTcpWindowSetupTest()
        {
            // TODO unit test for the property 'EndpointTcpWindowSetup'
        }

        /// <summary>
        /// Test the property 'BlockUntrustedCertificateConnections'
        /// </summary>
        [Fact]
        public void BlockUntrustedCertificateConnectionsTest()
        {
            // TODO unit test for the property 'BlockUntrustedCertificateConnections'
        }

        /// <summary>
        /// Test the property 'MaxStreamOffset'
        /// </summary>
        [Fact]
        public void MaxStreamOffsetTest()
        {
            // TODO unit test for the property 'MaxStreamOffset'
        }

        /// <summary>
        /// Test the property 'SslVersion'
        /// </summary>
        [Fact]
        public void SslVersionTest()
        {
            // TODO unit test for the property 'SslVersion'
        }

        /// <summary>
        /// Test the property 'TcpWindowMultiplier'
        /// </summary>
        [Fact]
        public void TcpWindowMultiplierTest()
        {
            // TODO unit test for the property 'TcpWindowMultiplier'
        }

        /// <summary>
        /// Test the property 'TcpDuplicateAckResponseThreshold'
        /// </summary>
        [Fact]
        public void TcpDuplicateAckResponseThresholdTest()
        {
            // TODO unit test for the property 'TcpDuplicateAckResponseThreshold'
        }

        /// <summary>
        /// Test the property 'ExtendedMemoryImplementation'
        /// </summary>
        [Fact]
        public void ExtendedMemoryImplementationTest()
        {
            // TODO unit test for the property 'ExtendedMemoryImplementation'
        }

        /// <summary>
        /// Test the property 'MaxProxiedConnections'
        /// </summary>
        [Fact]
        public void MaxProxiedConnectionsTest()
        {
            // TODO unit test for the property 'MaxProxiedConnections'
        }

        /// <summary>
        /// Test the property 'CipherMethod'
        /// </summary>
        [Fact]
        public void CipherMethodTest()
        {
            // TODO unit test for the property 'CipherMethod'
        }
    }
}
