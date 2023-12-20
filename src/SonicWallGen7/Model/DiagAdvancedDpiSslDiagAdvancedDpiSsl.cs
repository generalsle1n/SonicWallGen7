/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SonicWallGen7.Client.OpenAPIDateConverter;

namespace SonicWallGen7.Model
{
    /// <summary>
    /// Configure advanced diag DPI-SSL settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_dpi_ssl_diag_advanced_dpi_ssl")]
    public partial class DiagAdvancedDpiSslDiagAdvancedDpiSsl : IEquatable<DiagAdvancedDpiSslDiagAdvancedDpiSsl>, IValidatableObject
    {
        /// <summary>
        /// Set ssl version.
        /// </summary>
        /// <value>Set ssl version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SslVersionEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum SslV3 for value: ssl-v3
            /// </summary>
            [EnumMember(Value = "ssl-v3")]
            SslV3 = 2,

            /// <summary>
            /// Enum TlsV10 for value: tls-v10
            /// </summary>
            [EnumMember(Value = "tls-v10")]
            TlsV10 = 3,

            /// <summary>
            /// Enum TlsV11 for value: tls-v11
            /// </summary>
            [EnumMember(Value = "tls-v11")]
            TlsV11 = 4,

            /// <summary>
            /// Enum TlsV12 for value: tls-v12
            /// </summary>
            [EnumMember(Value = "tls-v12")]
            TlsV12 = 5
        }


        /// <summary>
        /// Set ssl version.
        /// </summary>
        /// <value>Set ssl version.</value>
        [DataMember(Name = "ssl_version", EmitDefaultValue = false)]
        public SslVersionEnum? SslVersion { get; set; }
        /// <summary>
        /// Set ssl cipher method.
        /// </summary>
        /// <value>Set ssl cipher method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CipherMethodEnum
        {
            /// <summary>
            /// Enum Secure for value: secure
            /// </summary>
            [EnumMember(Value = "secure")]
            Secure = 1,

            /// <summary>
            /// Enum Compatible for value: compatible
            /// </summary>
            [EnumMember(Value = "compatible")]
            Compatible = 2
        }


        /// <summary>
        /// Set ssl cipher method.
        /// </summary>
        /// <value>Set ssl cipher method.</value>
        [DataMember(Name = "cipher_method", EmitDefaultValue = false)]
        public CipherMethodEnum? CipherMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedDpiSslDiagAdvancedDpiSsl" /> class.
        /// </summary>
        /// <param name="rewrittenCertificateSnModifier">Set rewritten certificate SN modifier..</param>
        /// <param name="clientSpoofedCertificateCaching">Enable client spoofed certificate caching..</param>
        /// <param name="removeTcpTimestampOption">Enable removing TCP timestamp option..</param>
        /// <param name="dropSslOnLowMemory">Enable dropping SSL packets when memory low..</param>
        /// <param name="dpiSslSignedCertificateTrust">Trust DPI-SSL signed certificate..</param>
        /// <param name="proxylessSslWhenLimitExceeded">Enable allowing SSL without proxy when connection limit exceeded..</param>
        /// <param name="serverFacingSessionReuse">Enable server facing cache..</param>
        /// <param name="clientFacingSessionReuse">Enable client facing cache..</param>
        /// <param name="ipBasedExclusionCache">Enable IP based exclusion cache..</param>
        /// <param name="use2048BitCertificateKey">Use 2048 bit spoof certificate key in DPI SSL..</param>
        /// <param name="dynamicExclusionForExcludedConnections">Enable Dynamic Exclusion for exclude connections..</param>
        /// <param name="connectionFailures">connectionFailures.</param>
        /// <param name="revocationCheckServerCerificate">Enable check for server certificate revocation..</param>
        /// <param name="expiredCertificateAuthority">Allow expired certificate authority..</param>
        /// <param name="dpiSslExtendedMemory">Allow DPI-SSL connections to use extended memory..</param>
        /// <param name="endpointTcpWindowSetup">Enable endpoint TCP window setup..</param>
        /// <param name="blockUntrustedCertificateConnections">Enable blocking connections to sites with untrusted certificates..</param>
        /// <param name="maxStreamOffset">Set max stream offset to check for SSL client-hello resemblance..</param>
        /// <param name="sslVersion">Set ssl version..</param>
        /// <param name="tcpWindowMultiplier">Set TCP window multiplier (N *64k)..</param>
        /// <param name="tcpDuplicateAckResponseThreshold">Set TCP Duplicate Ack response threshold..</param>
        /// <param name="extendedMemoryImplementation">Settings for Extended Memory Implementation..</param>
        /// <param name="maxProxiedConnections">Set the override for max proxied SSL connections..</param>
        /// <param name="cipherMethod">Set ssl cipher method..</param>
        public DiagAdvancedDpiSslDiagAdvancedDpiSsl(decimal rewrittenCertificateSnModifier = default(decimal), bool clientSpoofedCertificateCaching = default(bool), bool removeTcpTimestampOption = default(bool), bool dropSslOnLowMemory = default(bool), bool dpiSslSignedCertificateTrust = default(bool), bool proxylessSslWhenLimitExceeded = default(bool), bool serverFacingSessionReuse = default(bool), bool clientFacingSessionReuse = default(bool), bool ipBasedExclusionCache = default(bool), bool use2048BitCertificateKey = default(bool), bool dynamicExclusionForExcludedConnections = default(bool), DiagAdvancedDpiSslDiagAdvancedDpiSslConnectionFailures connectionFailures = default(DiagAdvancedDpiSslDiagAdvancedDpiSslConnectionFailures), bool revocationCheckServerCerificate = default(bool), bool expiredCertificateAuthority = default(bool), bool dpiSslExtendedMemory = default(bool), bool endpointTcpWindowSetup = default(bool), bool blockUntrustedCertificateConnections = default(bool), decimal maxStreamOffset = default(decimal), SslVersionEnum? sslVersion = default(SslVersionEnum?), decimal tcpWindowMultiplier = default(decimal), decimal tcpDuplicateAckResponseThreshold = default(decimal), decimal extendedMemoryImplementation = default(decimal), decimal maxProxiedConnections = default(decimal), CipherMethodEnum? cipherMethod = default(CipherMethodEnum?))
        {
            this.RewrittenCertificateSnModifier = rewrittenCertificateSnModifier;
            this.ClientSpoofedCertificateCaching = clientSpoofedCertificateCaching;
            this.RemoveTcpTimestampOption = removeTcpTimestampOption;
            this.DropSslOnLowMemory = dropSslOnLowMemory;
            this.DpiSslSignedCertificateTrust = dpiSslSignedCertificateTrust;
            this.ProxylessSslWhenLimitExceeded = proxylessSslWhenLimitExceeded;
            this.ServerFacingSessionReuse = serverFacingSessionReuse;
            this.ClientFacingSessionReuse = clientFacingSessionReuse;
            this.IpBasedExclusionCache = ipBasedExclusionCache;
            this.Use2048BitCertificateKey = use2048BitCertificateKey;
            this.DynamicExclusionForExcludedConnections = dynamicExclusionForExcludedConnections;
            this.ConnectionFailures = connectionFailures;
            this.RevocationCheckServerCerificate = revocationCheckServerCerificate;
            this.ExpiredCertificateAuthority = expiredCertificateAuthority;
            this.DpiSslExtendedMemory = dpiSslExtendedMemory;
            this.EndpointTcpWindowSetup = endpointTcpWindowSetup;
            this.BlockUntrustedCertificateConnections = blockUntrustedCertificateConnections;
            this.MaxStreamOffset = maxStreamOffset;
            this.SslVersion = sslVersion;
            this.TcpWindowMultiplier = tcpWindowMultiplier;
            this.TcpDuplicateAckResponseThreshold = tcpDuplicateAckResponseThreshold;
            this.ExtendedMemoryImplementation = extendedMemoryImplementation;
            this.MaxProxiedConnections = maxProxiedConnections;
            this.CipherMethod = cipherMethod;
        }

        /// <summary>
        /// Set rewritten certificate SN modifier.
        /// </summary>
        /// <value>Set rewritten certificate SN modifier.</value>
        [DataMember(Name = "rewritten_certificate_sn_modifier", EmitDefaultValue = false)]
        public decimal RewrittenCertificateSnModifier { get; set; }

        /// <summary>
        /// Enable client spoofed certificate caching.
        /// </summary>
        /// <value>Enable client spoofed certificate caching.</value>
        [DataMember(Name = "client_spoofed_certificate_caching", EmitDefaultValue = true)]
        public bool ClientSpoofedCertificateCaching { get; set; }

        /// <summary>
        /// Enable removing TCP timestamp option.
        /// </summary>
        /// <value>Enable removing TCP timestamp option.</value>
        [DataMember(Name = "remove_tcp_timestamp_option", EmitDefaultValue = true)]
        public bool RemoveTcpTimestampOption { get; set; }

        /// <summary>
        /// Enable dropping SSL packets when memory low.
        /// </summary>
        /// <value>Enable dropping SSL packets when memory low.</value>
        [DataMember(Name = "drop_ssl_on_low_memory", EmitDefaultValue = true)]
        public bool DropSslOnLowMemory { get; set; }

        /// <summary>
        /// Trust DPI-SSL signed certificate.
        /// </summary>
        /// <value>Trust DPI-SSL signed certificate.</value>
        [DataMember(Name = "dpi_ssl_signed_certificate_trust", EmitDefaultValue = true)]
        public bool DpiSslSignedCertificateTrust { get; set; }

        /// <summary>
        /// Enable allowing SSL without proxy when connection limit exceeded.
        /// </summary>
        /// <value>Enable allowing SSL without proxy when connection limit exceeded.</value>
        [DataMember(Name = "proxyless_ssl_when_limit_exceeded", EmitDefaultValue = true)]
        public bool ProxylessSslWhenLimitExceeded { get; set; }

        /// <summary>
        /// Enable server facing cache.
        /// </summary>
        /// <value>Enable server facing cache.</value>
        [DataMember(Name = "server_facing_session_reuse", EmitDefaultValue = true)]
        public bool ServerFacingSessionReuse { get; set; }

        /// <summary>
        /// Enable client facing cache.
        /// </summary>
        /// <value>Enable client facing cache.</value>
        [DataMember(Name = "client_facing_session_reuse", EmitDefaultValue = true)]
        public bool ClientFacingSessionReuse { get; set; }

        /// <summary>
        /// Enable IP based exclusion cache.
        /// </summary>
        /// <value>Enable IP based exclusion cache.</value>
        [DataMember(Name = "ip_based_exclusion_cache", EmitDefaultValue = true)]
        public bool IpBasedExclusionCache { get; set; }

        /// <summary>
        /// Use 2048 bit spoof certificate key in DPI SSL.
        /// </summary>
        /// <value>Use 2048 bit spoof certificate key in DPI SSL.</value>
        [DataMember(Name = "use_2048_bit_certificate_key", EmitDefaultValue = true)]
        public bool Use2048BitCertificateKey { get; set; }

        /// <summary>
        /// Enable Dynamic Exclusion for exclude connections.
        /// </summary>
        /// <value>Enable Dynamic Exclusion for exclude connections.</value>
        [DataMember(Name = "dynamic_exclusion_for_excluded_connections", EmitDefaultValue = true)]
        public bool DynamicExclusionForExcludedConnections { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionFailures
        /// </summary>
        [DataMember(Name = "connection_failures", EmitDefaultValue = false)]
        public DiagAdvancedDpiSslDiagAdvancedDpiSslConnectionFailures ConnectionFailures { get; set; }

        /// <summary>
        /// Enable check for server certificate revocation.
        /// </summary>
        /// <value>Enable check for server certificate revocation.</value>
        [DataMember(Name = "revocation_check_server_cerificate", EmitDefaultValue = true)]
        public bool RevocationCheckServerCerificate { get; set; }

        /// <summary>
        /// Allow expired certificate authority.
        /// </summary>
        /// <value>Allow expired certificate authority.</value>
        [DataMember(Name = "expired_certificate_authority", EmitDefaultValue = true)]
        public bool ExpiredCertificateAuthority { get; set; }

        /// <summary>
        /// Allow DPI-SSL connections to use extended memory.
        /// </summary>
        /// <value>Allow DPI-SSL connections to use extended memory.</value>
        [DataMember(Name = "dpi_ssl_extended_memory", EmitDefaultValue = true)]
        public bool DpiSslExtendedMemory { get; set; }

        /// <summary>
        /// Enable endpoint TCP window setup.
        /// </summary>
        /// <value>Enable endpoint TCP window setup.</value>
        [DataMember(Name = "endpoint_tcp_window_setup", EmitDefaultValue = true)]
        public bool EndpointTcpWindowSetup { get; set; }

        /// <summary>
        /// Enable blocking connections to sites with untrusted certificates.
        /// </summary>
        /// <value>Enable blocking connections to sites with untrusted certificates.</value>
        [DataMember(Name = "block_untrusted_certificate_connections", EmitDefaultValue = true)]
        public bool BlockUntrustedCertificateConnections { get; set; }

        /// <summary>
        /// Set max stream offset to check for SSL client-hello resemblance.
        /// </summary>
        /// <value>Set max stream offset to check for SSL client-hello resemblance.</value>
        [DataMember(Name = "max_stream_offset", EmitDefaultValue = false)]
        public decimal MaxStreamOffset { get; set; }

        /// <summary>
        /// Set TCP window multiplier (N *64k).
        /// </summary>
        /// <value>Set TCP window multiplier (N *64k).</value>
        [DataMember(Name = "tcp_window_multiplier", EmitDefaultValue = false)]
        public decimal TcpWindowMultiplier { get; set; }

        /// <summary>
        /// Set TCP Duplicate Ack response threshold.
        /// </summary>
        /// <value>Set TCP Duplicate Ack response threshold.</value>
        [DataMember(Name = "tcp_duplicate_ack_response_threshold", EmitDefaultValue = false)]
        public decimal TcpDuplicateAckResponseThreshold { get; set; }

        /// <summary>
        /// Settings for Extended Memory Implementation.
        /// </summary>
        /// <value>Settings for Extended Memory Implementation.</value>
        [DataMember(Name = "extended_memory_implementation", EmitDefaultValue = false)]
        public decimal ExtendedMemoryImplementation { get; set; }

        /// <summary>
        /// Set the override for max proxied SSL connections.
        /// </summary>
        /// <value>Set the override for max proxied SSL connections.</value>
        [DataMember(Name = "max_proxied_connections", EmitDefaultValue = false)]
        public decimal MaxProxiedConnections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedDpiSslDiagAdvancedDpiSsl {\n");
            sb.Append("  RewrittenCertificateSnModifier: ").Append(RewrittenCertificateSnModifier).Append("\n");
            sb.Append("  ClientSpoofedCertificateCaching: ").Append(ClientSpoofedCertificateCaching).Append("\n");
            sb.Append("  RemoveTcpTimestampOption: ").Append(RemoveTcpTimestampOption).Append("\n");
            sb.Append("  DropSslOnLowMemory: ").Append(DropSslOnLowMemory).Append("\n");
            sb.Append("  DpiSslSignedCertificateTrust: ").Append(DpiSslSignedCertificateTrust).Append("\n");
            sb.Append("  ProxylessSslWhenLimitExceeded: ").Append(ProxylessSslWhenLimitExceeded).Append("\n");
            sb.Append("  ServerFacingSessionReuse: ").Append(ServerFacingSessionReuse).Append("\n");
            sb.Append("  ClientFacingSessionReuse: ").Append(ClientFacingSessionReuse).Append("\n");
            sb.Append("  IpBasedExclusionCache: ").Append(IpBasedExclusionCache).Append("\n");
            sb.Append("  Use2048BitCertificateKey: ").Append(Use2048BitCertificateKey).Append("\n");
            sb.Append("  DynamicExclusionForExcludedConnections: ").Append(DynamicExclusionForExcludedConnections).Append("\n");
            sb.Append("  ConnectionFailures: ").Append(ConnectionFailures).Append("\n");
            sb.Append("  RevocationCheckServerCerificate: ").Append(RevocationCheckServerCerificate).Append("\n");
            sb.Append("  ExpiredCertificateAuthority: ").Append(ExpiredCertificateAuthority).Append("\n");
            sb.Append("  DpiSslExtendedMemory: ").Append(DpiSslExtendedMemory).Append("\n");
            sb.Append("  EndpointTcpWindowSetup: ").Append(EndpointTcpWindowSetup).Append("\n");
            sb.Append("  BlockUntrustedCertificateConnections: ").Append(BlockUntrustedCertificateConnections).Append("\n");
            sb.Append("  MaxStreamOffset: ").Append(MaxStreamOffset).Append("\n");
            sb.Append("  SslVersion: ").Append(SslVersion).Append("\n");
            sb.Append("  TcpWindowMultiplier: ").Append(TcpWindowMultiplier).Append("\n");
            sb.Append("  TcpDuplicateAckResponseThreshold: ").Append(TcpDuplicateAckResponseThreshold).Append("\n");
            sb.Append("  ExtendedMemoryImplementation: ").Append(ExtendedMemoryImplementation).Append("\n");
            sb.Append("  MaxProxiedConnections: ").Append(MaxProxiedConnections).Append("\n");
            sb.Append("  CipherMethod: ").Append(CipherMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagAdvancedDpiSslDiagAdvancedDpiSsl);
        }

        /// <summary>
        /// Returns true if DiagAdvancedDpiSslDiagAdvancedDpiSsl instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedDpiSslDiagAdvancedDpiSsl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedDpiSslDiagAdvancedDpiSsl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RewrittenCertificateSnModifier == input.RewrittenCertificateSnModifier ||
                    this.RewrittenCertificateSnModifier.Equals(input.RewrittenCertificateSnModifier)
                ) && 
                (
                    this.ClientSpoofedCertificateCaching == input.ClientSpoofedCertificateCaching ||
                    this.ClientSpoofedCertificateCaching.Equals(input.ClientSpoofedCertificateCaching)
                ) && 
                (
                    this.RemoveTcpTimestampOption == input.RemoveTcpTimestampOption ||
                    this.RemoveTcpTimestampOption.Equals(input.RemoveTcpTimestampOption)
                ) && 
                (
                    this.DropSslOnLowMemory == input.DropSslOnLowMemory ||
                    this.DropSslOnLowMemory.Equals(input.DropSslOnLowMemory)
                ) && 
                (
                    this.DpiSslSignedCertificateTrust == input.DpiSslSignedCertificateTrust ||
                    this.DpiSslSignedCertificateTrust.Equals(input.DpiSslSignedCertificateTrust)
                ) && 
                (
                    this.ProxylessSslWhenLimitExceeded == input.ProxylessSslWhenLimitExceeded ||
                    this.ProxylessSslWhenLimitExceeded.Equals(input.ProxylessSslWhenLimitExceeded)
                ) && 
                (
                    this.ServerFacingSessionReuse == input.ServerFacingSessionReuse ||
                    this.ServerFacingSessionReuse.Equals(input.ServerFacingSessionReuse)
                ) && 
                (
                    this.ClientFacingSessionReuse == input.ClientFacingSessionReuse ||
                    this.ClientFacingSessionReuse.Equals(input.ClientFacingSessionReuse)
                ) && 
                (
                    this.IpBasedExclusionCache == input.IpBasedExclusionCache ||
                    this.IpBasedExclusionCache.Equals(input.IpBasedExclusionCache)
                ) && 
                (
                    this.Use2048BitCertificateKey == input.Use2048BitCertificateKey ||
                    this.Use2048BitCertificateKey.Equals(input.Use2048BitCertificateKey)
                ) && 
                (
                    this.DynamicExclusionForExcludedConnections == input.DynamicExclusionForExcludedConnections ||
                    this.DynamicExclusionForExcludedConnections.Equals(input.DynamicExclusionForExcludedConnections)
                ) && 
                (
                    this.ConnectionFailures == input.ConnectionFailures ||
                    (this.ConnectionFailures != null &&
                    this.ConnectionFailures.Equals(input.ConnectionFailures))
                ) && 
                (
                    this.RevocationCheckServerCerificate == input.RevocationCheckServerCerificate ||
                    this.RevocationCheckServerCerificate.Equals(input.RevocationCheckServerCerificate)
                ) && 
                (
                    this.ExpiredCertificateAuthority == input.ExpiredCertificateAuthority ||
                    this.ExpiredCertificateAuthority.Equals(input.ExpiredCertificateAuthority)
                ) && 
                (
                    this.DpiSslExtendedMemory == input.DpiSslExtendedMemory ||
                    this.DpiSslExtendedMemory.Equals(input.DpiSslExtendedMemory)
                ) && 
                (
                    this.EndpointTcpWindowSetup == input.EndpointTcpWindowSetup ||
                    this.EndpointTcpWindowSetup.Equals(input.EndpointTcpWindowSetup)
                ) && 
                (
                    this.BlockUntrustedCertificateConnections == input.BlockUntrustedCertificateConnections ||
                    this.BlockUntrustedCertificateConnections.Equals(input.BlockUntrustedCertificateConnections)
                ) && 
                (
                    this.MaxStreamOffset == input.MaxStreamOffset ||
                    this.MaxStreamOffset.Equals(input.MaxStreamOffset)
                ) && 
                (
                    this.SslVersion == input.SslVersion ||
                    this.SslVersion.Equals(input.SslVersion)
                ) && 
                (
                    this.TcpWindowMultiplier == input.TcpWindowMultiplier ||
                    this.TcpWindowMultiplier.Equals(input.TcpWindowMultiplier)
                ) && 
                (
                    this.TcpDuplicateAckResponseThreshold == input.TcpDuplicateAckResponseThreshold ||
                    this.TcpDuplicateAckResponseThreshold.Equals(input.TcpDuplicateAckResponseThreshold)
                ) && 
                (
                    this.ExtendedMemoryImplementation == input.ExtendedMemoryImplementation ||
                    this.ExtendedMemoryImplementation.Equals(input.ExtendedMemoryImplementation)
                ) && 
                (
                    this.MaxProxiedConnections == input.MaxProxiedConnections ||
                    this.MaxProxiedConnections.Equals(input.MaxProxiedConnections)
                ) && 
                (
                    this.CipherMethod == input.CipherMethod ||
                    this.CipherMethod.Equals(input.CipherMethod)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.RewrittenCertificateSnModifier.GetHashCode();
                hashCode = (hashCode * 59) + this.ClientSpoofedCertificateCaching.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoveTcpTimestampOption.GetHashCode();
                hashCode = (hashCode * 59) + this.DropSslOnLowMemory.GetHashCode();
                hashCode = (hashCode * 59) + this.DpiSslSignedCertificateTrust.GetHashCode();
                hashCode = (hashCode * 59) + this.ProxylessSslWhenLimitExceeded.GetHashCode();
                hashCode = (hashCode * 59) + this.ServerFacingSessionReuse.GetHashCode();
                hashCode = (hashCode * 59) + this.ClientFacingSessionReuse.GetHashCode();
                hashCode = (hashCode * 59) + this.IpBasedExclusionCache.GetHashCode();
                hashCode = (hashCode * 59) + this.Use2048BitCertificateKey.GetHashCode();
                hashCode = (hashCode * 59) + this.DynamicExclusionForExcludedConnections.GetHashCode();
                if (this.ConnectionFailures != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionFailures.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RevocationCheckServerCerificate.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpiredCertificateAuthority.GetHashCode();
                hashCode = (hashCode * 59) + this.DpiSslExtendedMemory.GetHashCode();
                hashCode = (hashCode * 59) + this.EndpointTcpWindowSetup.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockUntrustedCertificateConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxStreamOffset.GetHashCode();
                hashCode = (hashCode * 59) + this.SslVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.TcpWindowMultiplier.GetHashCode();
                hashCode = (hashCode * 59) + this.TcpDuplicateAckResponseThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.ExtendedMemoryImplementation.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxProxiedConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.CipherMethod.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}