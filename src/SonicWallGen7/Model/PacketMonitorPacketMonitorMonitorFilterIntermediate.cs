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
    /// Enable monitoring of intermediate packet.
    /// </summary>
    [DataContract(Name = "packet_monitor_packet_monitor_monitor_filter_intermediate")]
    public partial class PacketMonitorPacketMonitorMonitorFilterIntermediate : IEquatable<PacketMonitorPacketMonitorMonitorFilterIntermediate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketMonitorPacketMonitorMonitorFilterIntermediate" /> class.
        /// </summary>
        /// <param name="intermediatePackets">Enable monitoring intermediate packets..</param>
        /// <param name="multicast">Enable monitoring of intermediate multicast traffic..</param>
        /// <param name="iphelper">Enable monitoring of intermediate IP helper traffic..</param>
        /// <param name="reassembled">Enable monitoring of intermediate reassembled traffic..</param>
        /// <param name="fragmented">Enable monitoring of intermediate fragmented traffic..</param>
        /// <param name="remoteMirrored">Enable monitoring of intermediate remote mirrored traffic..</param>
        /// <param name="ipsec">Enable monitoring of intermediate IPSEC traffic..</param>
        /// <param name="ssl">Enable monitoring of intermediate SSL decrypted traffic..</param>
        /// <param name="restorePortsSsl">Enable restore original ports on SSL decrypted traffic..</param>
        /// <param name="ldapOverTls">Enable monitoring of intermediate decrypted LDAP over                TLS traffic..</param>
        /// <param name="ssoAgent">Enable monitoring of intermediate decrypted Single Sign On                agent messages..</param>
        public PacketMonitorPacketMonitorMonitorFilterIntermediate(bool intermediatePackets = default(bool), bool multicast = default(bool), bool iphelper = default(bool), bool reassembled = default(bool), bool fragmented = default(bool), bool remoteMirrored = default(bool), bool ipsec = default(bool), bool ssl = default(bool), bool restorePortsSsl = default(bool), bool ldapOverTls = default(bool), bool ssoAgent = default(bool))
        {
            this.IntermediatePackets = intermediatePackets;
            this.Multicast = multicast;
            this.Iphelper = iphelper;
            this.Reassembled = reassembled;
            this.Fragmented = fragmented;
            this.RemoteMirrored = remoteMirrored;
            this.Ipsec = ipsec;
            this.Ssl = ssl;
            this.RestorePortsSsl = restorePortsSsl;
            this.LdapOverTls = ldapOverTls;
            this.SsoAgent = ssoAgent;
        }

        /// <summary>
        /// Enable monitoring intermediate packets.
        /// </summary>
        /// <value>Enable monitoring intermediate packets.</value>
        [DataMember(Name = "intermediate_packets", EmitDefaultValue = true)]
        public bool IntermediatePackets { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate multicast traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate multicast traffic.</value>
        [DataMember(Name = "multicast", EmitDefaultValue = true)]
        public bool Multicast { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate IP helper traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate IP helper traffic.</value>
        [DataMember(Name = "iphelper", EmitDefaultValue = true)]
        public bool Iphelper { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate reassembled traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate reassembled traffic.</value>
        [DataMember(Name = "reassembled", EmitDefaultValue = true)]
        public bool Reassembled { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate fragmented traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate fragmented traffic.</value>
        [DataMember(Name = "fragmented", EmitDefaultValue = true)]
        public bool Fragmented { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate remote mirrored traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate remote mirrored traffic.</value>
        [DataMember(Name = "remote_mirrored", EmitDefaultValue = true)]
        public bool RemoteMirrored { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate IPSEC traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate IPSEC traffic.</value>
        [DataMember(Name = "ipsec", EmitDefaultValue = true)]
        public bool Ipsec { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate SSL decrypted traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate SSL decrypted traffic.</value>
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// Enable restore original ports on SSL decrypted traffic.
        /// </summary>
        /// <value>Enable restore original ports on SSL decrypted traffic.</value>
        [DataMember(Name = "restore_ports_ssl", EmitDefaultValue = true)]
        public bool RestorePortsSsl { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate decrypted LDAP over                TLS traffic.
        /// </summary>
        /// <value>Enable monitoring of intermediate decrypted LDAP over                TLS traffic.</value>
        [DataMember(Name = "ldap_over_tls", EmitDefaultValue = true)]
        public bool LdapOverTls { get; set; }

        /// <summary>
        /// Enable monitoring of intermediate decrypted Single Sign On                agent messages.
        /// </summary>
        /// <value>Enable monitoring of intermediate decrypted Single Sign On                agent messages.</value>
        [DataMember(Name = "sso_agent", EmitDefaultValue = true)]
        public bool SsoAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketMonitorPacketMonitorMonitorFilterIntermediate {\n");
            sb.Append("  IntermediatePackets: ").Append(IntermediatePackets).Append("\n");
            sb.Append("  Multicast: ").Append(Multicast).Append("\n");
            sb.Append("  Iphelper: ").Append(Iphelper).Append("\n");
            sb.Append("  Reassembled: ").Append(Reassembled).Append("\n");
            sb.Append("  Fragmented: ").Append(Fragmented).Append("\n");
            sb.Append("  RemoteMirrored: ").Append(RemoteMirrored).Append("\n");
            sb.Append("  Ipsec: ").Append(Ipsec).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  RestorePortsSsl: ").Append(RestorePortsSsl).Append("\n");
            sb.Append("  LdapOverTls: ").Append(LdapOverTls).Append("\n");
            sb.Append("  SsoAgent: ").Append(SsoAgent).Append("\n");
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
            return this.Equals(input as PacketMonitorPacketMonitorMonitorFilterIntermediate);
        }

        /// <summary>
        /// Returns true if PacketMonitorPacketMonitorMonitorFilterIntermediate instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketMonitorPacketMonitorMonitorFilterIntermediate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketMonitorPacketMonitorMonitorFilterIntermediate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntermediatePackets == input.IntermediatePackets ||
                    this.IntermediatePackets.Equals(input.IntermediatePackets)
                ) && 
                (
                    this.Multicast == input.Multicast ||
                    this.Multicast.Equals(input.Multicast)
                ) && 
                (
                    this.Iphelper == input.Iphelper ||
                    this.Iphelper.Equals(input.Iphelper)
                ) && 
                (
                    this.Reassembled == input.Reassembled ||
                    this.Reassembled.Equals(input.Reassembled)
                ) && 
                (
                    this.Fragmented == input.Fragmented ||
                    this.Fragmented.Equals(input.Fragmented)
                ) && 
                (
                    this.RemoteMirrored == input.RemoteMirrored ||
                    this.RemoteMirrored.Equals(input.RemoteMirrored)
                ) && 
                (
                    this.Ipsec == input.Ipsec ||
                    this.Ipsec.Equals(input.Ipsec)
                ) && 
                (
                    this.Ssl == input.Ssl ||
                    this.Ssl.Equals(input.Ssl)
                ) && 
                (
                    this.RestorePortsSsl == input.RestorePortsSsl ||
                    this.RestorePortsSsl.Equals(input.RestorePortsSsl)
                ) && 
                (
                    this.LdapOverTls == input.LdapOverTls ||
                    this.LdapOverTls.Equals(input.LdapOverTls)
                ) && 
                (
                    this.SsoAgent == input.SsoAgent ||
                    this.SsoAgent.Equals(input.SsoAgent)
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
                hashCode = (hashCode * 59) + this.IntermediatePackets.GetHashCode();
                hashCode = (hashCode * 59) + this.Multicast.GetHashCode();
                hashCode = (hashCode * 59) + this.Iphelper.GetHashCode();
                hashCode = (hashCode * 59) + this.Reassembled.GetHashCode();
                hashCode = (hashCode * 59) + this.Fragmented.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoteMirrored.GetHashCode();
                hashCode = (hashCode * 59) + this.Ipsec.GetHashCode();
                hashCode = (hashCode * 59) + this.Ssl.GetHashCode();
                hashCode = (hashCode * 59) + this.RestorePortsSsl.GetHashCode();
                hashCode = (hashCode * 59) + this.LdapOverTls.GetHashCode();
                hashCode = (hashCode * 59) + this.SsoAgent.GetHashCode();
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