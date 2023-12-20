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
    /// Use IPSEC tunnel.
    /// </summary>
    [DataContract(Name = "administration_gms_management_ipsec_tunnel_ipsec_tunnel")]
    public partial class AdministrationGmsManagementIpsecTunnelIpsecTunnel : IEquatable<AdministrationGmsManagementIpsecTunnelIpsecTunnel>, IValidatableObject
    {
        /// <summary>
        /// Set IPSEC encryption type.
        /// </summary>
        /// <value>Set IPSEC encryption type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionTypeEnum
        {
            /// <summary>
            /// Enum DesMd5 for value: des-md5
            /// </summary>
            [EnumMember(Value = "des-md5")]
            DesMd5 = 1
        }


        /// <summary>
        /// Set IPSEC encryption type.
        /// </summary>
        /// <value>Set IPSEC encryption type.</value>
        [DataMember(Name = "encryption_type", EmitDefaultValue = false)]
        public EncryptionTypeEnum? EncryptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationGmsManagementIpsecTunnelIpsecTunnel" /> class.
        /// </summary>
        /// <param name="hostName">Set the GMS server IP or hostname..</param>
        /// <param name="syslogServerPort">Set the syslog server port of the GMS server..</param>
        /// <param name="heartbeatStatusOnly">Enable send heartbeat status messages Only..</param>
        /// <param name="behindNatDevice">behindNatDevice.</param>
        /// <param name="spi">Set Incoming / Outgoing IPSEC SPI..</param>
        /// <param name="encryptionType">Set IPSEC encryption type..</param>
        /// <param name="encryptionKey">Set IPSEC encryption key..</param>
        /// <param name="authenticationKey">Set IPSEC authentication key..</param>
        public AdministrationGmsManagementIpsecTunnelIpsecTunnel(string hostName = default(string), decimal syslogServerPort = default(decimal), bool heartbeatStatusOnly = default(bool), AdministrationGmsManagementIpsecTunnelIpsecTunnelBehindNatDevice behindNatDevice = default(AdministrationGmsManagementIpsecTunnelIpsecTunnelBehindNatDevice), string spi = default(string), EncryptionTypeEnum? encryptionType = default(EncryptionTypeEnum?), string encryptionKey = default(string), string authenticationKey = default(string))
        {
            this.HostName = hostName;
            this.SyslogServerPort = syslogServerPort;
            this.HeartbeatStatusOnly = heartbeatStatusOnly;
            this.BehindNatDevice = behindNatDevice;
            this.Spi = spi;
            this.EncryptionType = encryptionType;
            this.EncryptionKey = encryptionKey;
            this.AuthenticationKey = authenticationKey;
        }

        /// <summary>
        /// Set the GMS server IP or hostname.
        /// </summary>
        /// <value>Set the GMS server IP or hostname.</value>
        [DataMember(Name = "host_name", EmitDefaultValue = false)]
        public string HostName { get; set; }

        /// <summary>
        /// Set the syslog server port of the GMS server.
        /// </summary>
        /// <value>Set the syslog server port of the GMS server.</value>
        [DataMember(Name = "syslog_server_port", EmitDefaultValue = false)]
        public decimal SyslogServerPort { get; set; }

        /// <summary>
        /// Enable send heartbeat status messages Only.
        /// </summary>
        /// <value>Enable send heartbeat status messages Only.</value>
        [DataMember(Name = "heartbeat_status_only", EmitDefaultValue = true)]
        public bool HeartbeatStatusOnly { get; set; }

        /// <summary>
        /// Gets or Sets BehindNatDevice
        /// </summary>
        [DataMember(Name = "behind_nat_device", EmitDefaultValue = true)]
        public AdministrationGmsManagementIpsecTunnelIpsecTunnelBehindNatDevice BehindNatDevice { get; set; }

        /// <summary>
        /// Set Incoming / Outgoing IPSEC SPI.
        /// </summary>
        /// <value>Set Incoming / Outgoing IPSEC SPI.</value>
        [DataMember(Name = "spi", EmitDefaultValue = false)]
        public string Spi { get; set; }

        /// <summary>
        /// Set IPSEC encryption key.
        /// </summary>
        /// <value>Set IPSEC encryption key.</value>
        [DataMember(Name = "encryption_key", EmitDefaultValue = false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Set IPSEC authentication key.
        /// </summary>
        /// <value>Set IPSEC authentication key.</value>
        [DataMember(Name = "authentication_key", EmitDefaultValue = false)]
        public string AuthenticationKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationGmsManagementIpsecTunnelIpsecTunnel {\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  SyslogServerPort: ").Append(SyslogServerPort).Append("\n");
            sb.Append("  HeartbeatStatusOnly: ").Append(HeartbeatStatusOnly).Append("\n");
            sb.Append("  BehindNatDevice: ").Append(BehindNatDevice).Append("\n");
            sb.Append("  Spi: ").Append(Spi).Append("\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
            sb.Append("  AuthenticationKey: ").Append(AuthenticationKey).Append("\n");
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
            return this.Equals(input as AdministrationGmsManagementIpsecTunnelIpsecTunnel);
        }

        /// <summary>
        /// Returns true if AdministrationGmsManagementIpsecTunnelIpsecTunnel instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationGmsManagementIpsecTunnelIpsecTunnel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationGmsManagementIpsecTunnelIpsecTunnel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.SyslogServerPort == input.SyslogServerPort ||
                    this.SyslogServerPort.Equals(input.SyslogServerPort)
                ) && 
                (
                    this.HeartbeatStatusOnly == input.HeartbeatStatusOnly ||
                    this.HeartbeatStatusOnly.Equals(input.HeartbeatStatusOnly)
                ) && 
                (
                    this.BehindNatDevice == input.BehindNatDevice ||
                    (this.BehindNatDevice != null &&
                    this.BehindNatDevice.Equals(input.BehindNatDevice))
                ) && 
                (
                    this.Spi == input.Spi ||
                    (this.Spi != null &&
                    this.Spi.Equals(input.Spi))
                ) && 
                (
                    this.EncryptionType == input.EncryptionType ||
                    this.EncryptionType.Equals(input.EncryptionType)
                ) && 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
                ) && 
                (
                    this.AuthenticationKey == input.AuthenticationKey ||
                    (this.AuthenticationKey != null &&
                    this.AuthenticationKey.Equals(input.AuthenticationKey))
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
                if (this.HostName != null)
                {
                    hashCode = (hashCode * 59) + this.HostName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SyslogServerPort.GetHashCode();
                hashCode = (hashCode * 59) + this.HeartbeatStatusOnly.GetHashCode();
                if (this.BehindNatDevice != null)
                {
                    hashCode = (hashCode * 59) + this.BehindNatDevice.GetHashCode();
                }
                if (this.Spi != null)
                {
                    hashCode = (hashCode * 59) + this.Spi.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EncryptionType.GetHashCode();
                if (this.EncryptionKey != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptionKey.GetHashCode();
                }
                if (this.AuthenticationKey != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationKey.GetHashCode();
                }
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