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
    /// Configure advanced diag SonicDns proxy settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_SonicDns_proxy_diag_advanced_SonicDns_proxy")]
    public partial class DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy : IEquatable<DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy>, IValidatableObject
    {
        /// <summary>
        /// Configure the SonicDns over transport protocol.
        /// </summary>
        /// <value>Configure the SonicDns over transport protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SonicDnsOverTransportEnum
        {
            /// <summary>
            /// Enum TcpUdp for value: tcp-udp
            /// </summary>
            [EnumMember(Value = "tcp-udp")]
            TcpUdp = 1,

            /// <summary>
            /// Enum UdpOnly for value: udp-only
            /// </summary>
            [EnumMember(Value = "udp-only")]
            UdpOnly = 2
        }


        /// <summary>
        /// Configure the SonicDns over transport protocol.
        /// </summary>
        /// <value>Configure the SonicDns over transport protocol.</value>
        [DataMember(Name = "SonicDns_over_transport", EmitDefaultValue = false)]
        public SonicDnsOverTransportEnum? SonicDnsOverTransport { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy" /> class.
        /// </summary>
        /// <param name="requestSizePercentage">Configure the Percentage of proxy process ability..</param>
        /// <param name="supportFragmentation">Enable Support fragmentation process on SonicDns packet..</param>
        /// <param name="serverFailoverTimes">Resolution failure times that trigger SonicDns server failover. * Set to null to represent an unconfigured state..</param>
        /// <param name="cacheLifetime">Lifetime of connection cache for SonicDns proxy packets. * Set to null to represent an unconfigured state..</param>
        /// <param name="SonicDnsOverTransport">Configure the SonicDns over transport protocol..</param>
        /// <param name="excludeVpnTraffic">Exclude incoming VPN traffic from SonicDns Proxy processing..</param>
        public DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy(decimal requestSizePercentage = default(decimal), bool supportFragmentation = default(bool), decimal? serverFailoverTimes = default(decimal?), decimal? cacheLifetime = default(decimal?), SonicDnsOverTransportEnum? SonicDnsOverTransport = default(SonicDnsOverTransportEnum?), bool excludeVpnTraffic = default(bool))
        {
            this.RequestSizePercentage = requestSizePercentage;
            this.SupportFragmentation = supportFragmentation;
            this.ServerFailoverTimes = serverFailoverTimes;
            this.CacheLifetime = cacheLifetime;
            this.SonicDnsOverTransport = SonicDnsOverTransport;
            this.ExcludeVpnTraffic = excludeVpnTraffic;
        }

        /// <summary>
        /// Configure the Percentage of proxy process ability.
        /// </summary>
        /// <value>Configure the Percentage of proxy process ability.</value>
        [DataMember(Name = "request_size_percentage", EmitDefaultValue = false)]
        public decimal RequestSizePercentage { get; set; }

        /// <summary>
        /// Enable Support fragmentation process on SonicDns packet.
        /// </summary>
        /// <value>Enable Support fragmentation process on SonicDns packet.</value>
        [DataMember(Name = "support_fragmentation", EmitDefaultValue = true)]
        public bool SupportFragmentation { get; set; }

        /// <summary>
        /// Resolution failure times that trigger SonicDns server failover. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Resolution failure times that trigger SonicDns server failover. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "server_failover_times", EmitDefaultValue = true)]
        public decimal? ServerFailoverTimes { get; set; }

        /// <summary>
        /// Lifetime of connection cache for SonicDns proxy packets. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Lifetime of connection cache for SonicDns proxy packets. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "cache_lifetime", EmitDefaultValue = true)]
        public decimal? CacheLifetime { get; set; }

        /// <summary>
        /// Exclude incoming VPN traffic from SonicDns Proxy processing.
        /// </summary>
        /// <value>Exclude incoming VPN traffic from SonicDns Proxy processing.</value>
        [DataMember(Name = "exclude_vpn_traffic", EmitDefaultValue = true)]
        public bool ExcludeVpnTraffic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy {\n");
            sb.Append("  RequestSizePercentage: ").Append(RequestSizePercentage).Append("\n");
            sb.Append("  SupportFragmentation: ").Append(SupportFragmentation).Append("\n");
            sb.Append("  ServerFailoverTimes: ").Append(ServerFailoverTimes).Append("\n");
            sb.Append("  CacheLifetime: ").Append(CacheLifetime).Append("\n");
            sb.Append("  SonicDnsOverTransport: ").Append(SonicDnsOverTransport).Append("\n");
            sb.Append("  ExcludeVpnTraffic: ").Append(ExcludeVpnTraffic).Append("\n");
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
            return this.Equals(input as DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy);
        }

        /// <summary>
        /// Returns true if DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedSonicDnsProxyDiagAdvancedSonicDnsProxy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestSizePercentage == input.RequestSizePercentage ||
                    this.RequestSizePercentage.Equals(input.RequestSizePercentage)
                ) && 
                (
                    this.SupportFragmentation == input.SupportFragmentation ||
                    this.SupportFragmentation.Equals(input.SupportFragmentation)
                ) && 
                (
                    this.ServerFailoverTimes == input.ServerFailoverTimes ||
                    (this.ServerFailoverTimes != null &&
                    this.ServerFailoverTimes.Equals(input.ServerFailoverTimes))
                ) && 
                (
                    this.CacheLifetime == input.CacheLifetime ||
                    (this.CacheLifetime != null &&
                    this.CacheLifetime.Equals(input.CacheLifetime))
                ) && 
                (
                    this.SonicDnsOverTransport == input.SonicDnsOverTransport ||
                    this.SonicDnsOverTransport.Equals(input.SonicDnsOverTransport)
                ) && 
                (
                    this.ExcludeVpnTraffic == input.ExcludeVpnTraffic ||
                    this.ExcludeVpnTraffic.Equals(input.ExcludeVpnTraffic)
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
                hashCode = (hashCode * 59) + this.RequestSizePercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.SupportFragmentation.GetHashCode();
                if (this.ServerFailoverTimes != null)
                {
                    hashCode = (hashCode * 59) + this.ServerFailoverTimes.GetHashCode();
                }
                if (this.CacheLifetime != null)
                {
                    hashCode = (hashCode * 59) + this.CacheLifetime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SonicDnsOverTransport.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeVpnTraffic.GetHashCode();
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
