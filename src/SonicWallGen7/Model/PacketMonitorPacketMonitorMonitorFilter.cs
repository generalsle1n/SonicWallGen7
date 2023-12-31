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
    /// Specify packet monitor filter.
    /// </summary>
    [DataContract(Name = "packet_monitor_packet_monitor_monitor_filter")]
    public partial class PacketMonitorPacketMonitorMonitorFilter : IEquatable<PacketMonitorPacketMonitorMonitorFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketMonitorPacketMonitorMonitorFilter" /> class.
        /// </summary>
        /// <param name="firewallGenerated">Enable monitoring of firewall generated packets. (This will                bypass interface filter)..</param>
        /// <param name="intermediate">intermediate.</param>
        /// <param name="basedOnFirewallRule">Enable packet monitor filter based on the firewall                access/app rules..</param>
        /// <param name="interfaces">Specify name of interface(s) on which packet capture needs                to be performed (maximum 10)..</param>
        /// <param name="etherTypes">Specify name of ether type(s) on which packet capture needs                to be performed..</param>
        /// <param name="ipTypes">Specify name of ip type(s) on which packet capture needs                to be performed..</param>
        /// <param name="sourceIps">Specify source IP addresses on which packet capture needs to                be performed..</param>
        /// <param name="sourcePorts">Specify source TCP/UDP ports on which packet capture needs to                be performed..</param>
        /// <param name="destinationIps">Specify destination IP addresses on which packet capture needs                to be performed..</param>
        /// <param name="destinationPorts">Specify destination TCP/UDP ports on which packet capture needs                to be performed..</param>
        /// <param name="bidirectional">Enable bidirectional address and port matching..</param>
        /// <param name="status">status.</param>
        public PacketMonitorPacketMonitorMonitorFilter(bool firewallGenerated = default(bool), PacketMonitorPacketMonitorMonitorFilterIntermediate intermediate = default(PacketMonitorPacketMonitorMonitorFilterIntermediate), bool basedOnFirewallRule = default(bool), string interfaces = default(string), string etherTypes = default(string), string ipTypes = default(string), string sourceIps = default(string), string sourcePorts = default(string), string destinationIps = default(string), string destinationPorts = default(string), bool bidirectional = default(bool), PacketMonitorPacketMonitorMonitorFilterStatus status = default(PacketMonitorPacketMonitorMonitorFilterStatus))
        {
            this.FirewallGenerated = firewallGenerated;
            this.Intermediate = intermediate;
            this.BasedOnFirewallRule = basedOnFirewallRule;
            this.Interfaces = interfaces;
            this.EtherTypes = etherTypes;
            this.IpTypes = ipTypes;
            this.SourceIps = sourceIps;
            this.SourcePorts = sourcePorts;
            this.DestinationIps = destinationIps;
            this.DestinationPorts = destinationPorts;
            this.Bidirectional = bidirectional;
            this.Status = status;
        }

        /// <summary>
        /// Enable monitoring of firewall generated packets. (This will                bypass interface filter).
        /// </summary>
        /// <value>Enable monitoring of firewall generated packets. (This will                bypass interface filter).</value>
        [DataMember(Name = "firewall_generated", EmitDefaultValue = true)]
        public bool FirewallGenerated { get; set; }

        /// <summary>
        /// Gets or Sets Intermediate
        /// </summary>
        [DataMember(Name = "intermediate", EmitDefaultValue = false)]
        public PacketMonitorPacketMonitorMonitorFilterIntermediate Intermediate { get; set; }

        /// <summary>
        /// Enable packet monitor filter based on the firewall                access/app rules.
        /// </summary>
        /// <value>Enable packet monitor filter based on the firewall                access/app rules.</value>
        [DataMember(Name = "based_on_firewall_rule", EmitDefaultValue = true)]
        public bool BasedOnFirewallRule { get; set; }

        /// <summary>
        /// Specify name of interface(s) on which packet capture needs                to be performed (maximum 10).
        /// </summary>
        /// <value>Specify name of interface(s) on which packet capture needs                to be performed (maximum 10).</value>
        [DataMember(Name = "interfaces", EmitDefaultValue = false)]
        public string Interfaces { get; set; }

        /// <summary>
        /// Specify name of ether type(s) on which packet capture needs                to be performed.
        /// </summary>
        /// <value>Specify name of ether type(s) on which packet capture needs                to be performed.</value>
        [DataMember(Name = "ether_types", EmitDefaultValue = false)]
        public string EtherTypes { get; set; }

        /// <summary>
        /// Specify name of ip type(s) on which packet capture needs                to be performed.
        /// </summary>
        /// <value>Specify name of ip type(s) on which packet capture needs                to be performed.</value>
        [DataMember(Name = "ip_types", EmitDefaultValue = false)]
        public string IpTypes { get; set; }

        /// <summary>
        /// Specify source IP addresses on which packet capture needs to                be performed.
        /// </summary>
        /// <value>Specify source IP addresses on which packet capture needs to                be performed.</value>
        [DataMember(Name = "source_ips", EmitDefaultValue = false)]
        public string SourceIps { get; set; }

        /// <summary>
        /// Specify source TCP/UDP ports on which packet capture needs to                be performed.
        /// </summary>
        /// <value>Specify source TCP/UDP ports on which packet capture needs to                be performed.</value>
        [DataMember(Name = "source_ports", EmitDefaultValue = false)]
        public string SourcePorts { get; set; }

        /// <summary>
        /// Specify destination IP addresses on which packet capture needs                to be performed.
        /// </summary>
        /// <value>Specify destination IP addresses on which packet capture needs                to be performed.</value>
        [DataMember(Name = "destination_ips", EmitDefaultValue = false)]
        public string DestinationIps { get; set; }

        /// <summary>
        /// Specify destination TCP/UDP ports on which packet capture needs                to be performed.
        /// </summary>
        /// <value>Specify destination TCP/UDP ports on which packet capture needs                to be performed.</value>
        [DataMember(Name = "destination_ports", EmitDefaultValue = false)]
        public string DestinationPorts { get; set; }

        /// <summary>
        /// Enable bidirectional address and port matching.
        /// </summary>
        /// <value>Enable bidirectional address and port matching.</value>
        [DataMember(Name = "bidirectional", EmitDefaultValue = true)]
        public bool Bidirectional { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public PacketMonitorPacketMonitorMonitorFilterStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketMonitorPacketMonitorMonitorFilter {\n");
            sb.Append("  FirewallGenerated: ").Append(FirewallGenerated).Append("\n");
            sb.Append("  Intermediate: ").Append(Intermediate).Append("\n");
            sb.Append("  BasedOnFirewallRule: ").Append(BasedOnFirewallRule).Append("\n");
            sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
            sb.Append("  EtherTypes: ").Append(EtherTypes).Append("\n");
            sb.Append("  IpTypes: ").Append(IpTypes).Append("\n");
            sb.Append("  SourceIps: ").Append(SourceIps).Append("\n");
            sb.Append("  SourcePorts: ").Append(SourcePorts).Append("\n");
            sb.Append("  DestinationIps: ").Append(DestinationIps).Append("\n");
            sb.Append("  DestinationPorts: ").Append(DestinationPorts).Append("\n");
            sb.Append("  Bidirectional: ").Append(Bidirectional).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PacketMonitorPacketMonitorMonitorFilter);
        }

        /// <summary>
        /// Returns true if PacketMonitorPacketMonitorMonitorFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketMonitorPacketMonitorMonitorFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketMonitorPacketMonitorMonitorFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirewallGenerated == input.FirewallGenerated ||
                    this.FirewallGenerated.Equals(input.FirewallGenerated)
                ) && 
                (
                    this.Intermediate == input.Intermediate ||
                    (this.Intermediate != null &&
                    this.Intermediate.Equals(input.Intermediate))
                ) && 
                (
                    this.BasedOnFirewallRule == input.BasedOnFirewallRule ||
                    this.BasedOnFirewallRule.Equals(input.BasedOnFirewallRule)
                ) && 
                (
                    this.Interfaces == input.Interfaces ||
                    (this.Interfaces != null &&
                    this.Interfaces.Equals(input.Interfaces))
                ) && 
                (
                    this.EtherTypes == input.EtherTypes ||
                    (this.EtherTypes != null &&
                    this.EtherTypes.Equals(input.EtherTypes))
                ) && 
                (
                    this.IpTypes == input.IpTypes ||
                    (this.IpTypes != null &&
                    this.IpTypes.Equals(input.IpTypes))
                ) && 
                (
                    this.SourceIps == input.SourceIps ||
                    (this.SourceIps != null &&
                    this.SourceIps.Equals(input.SourceIps))
                ) && 
                (
                    this.SourcePorts == input.SourcePorts ||
                    (this.SourcePorts != null &&
                    this.SourcePorts.Equals(input.SourcePorts))
                ) && 
                (
                    this.DestinationIps == input.DestinationIps ||
                    (this.DestinationIps != null &&
                    this.DestinationIps.Equals(input.DestinationIps))
                ) && 
                (
                    this.DestinationPorts == input.DestinationPorts ||
                    (this.DestinationPorts != null &&
                    this.DestinationPorts.Equals(input.DestinationPorts))
                ) && 
                (
                    this.Bidirectional == input.Bidirectional ||
                    this.Bidirectional.Equals(input.Bidirectional)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.FirewallGenerated.GetHashCode();
                if (this.Intermediate != null)
                {
                    hashCode = (hashCode * 59) + this.Intermediate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BasedOnFirewallRule.GetHashCode();
                if (this.Interfaces != null)
                {
                    hashCode = (hashCode * 59) + this.Interfaces.GetHashCode();
                }
                if (this.EtherTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EtherTypes.GetHashCode();
                }
                if (this.IpTypes != null)
                {
                    hashCode = (hashCode * 59) + this.IpTypes.GetHashCode();
                }
                if (this.SourceIps != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIps.GetHashCode();
                }
                if (this.SourcePorts != null)
                {
                    hashCode = (hashCode * 59) + this.SourcePorts.GetHashCode();
                }
                if (this.DestinationIps != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationIps.GetHashCode();
                }
                if (this.DestinationPorts != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationPorts.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bidirectional.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
