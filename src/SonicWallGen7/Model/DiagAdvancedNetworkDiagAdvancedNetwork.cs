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
    /// Configure advanced diag network and routing settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_network_diag_advanced_network")]
    public partial class DiagAdvancedNetworkDiagAdvancedNetwork : IEquatable<DiagAdvancedNetworkDiagAdvancedNetwork>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedNetworkDiagAdvancedNetwork" /> class.
        /// </summary>
        /// <param name="flushAlternatePathFlows">Enable flushing flows on alternate path when normal route path is enabled (affects existing connections)..</param>
        /// <param name="updateRouteVersion">Enable updating route version when route is enabled/disabled (affects existing connections)..</param>
        /// <param name="tcpPacketOptionTagging">Enable TCP packet option tagging..</param>
        /// <param name="fixMalformedTcpHeaders">Enable fix/ignore malformed TCP headers..</param>
        /// <param name="sequenceNumberRandomization">Enable TCP sequence number randomization..</param>
        /// <param name="synValidation">Enable performing SYN validation when not operating in strict TCP compliance mode..</param>
        /// <param name="debounceInterfaceStateChanges">Enable Debounce Interface State Changes for routing protocols.</param>
        /// <param name="clearDfBit">Enable clear DF (don&#39;t fragment) bit..</param>
        /// <param name="smallerFirstFragment">Enable smaller first fragment packets..</param>
        /// <param name="ipv6SmallFragment">Enable IPv6 Fragmentation Packets smaller than 1280 bytes..</param>
        /// <param name="overrideMac">Enable override MAC address when NAT..</param>
        /// <param name="dropRecordRoute">Enable droping record route packets..</param>
        /// <param name="advertiseFqdnRoute">Enable advertisement of FQDN based policy route to dynamic routing protocol..</param>
        /// <param name="generateInterfaceDefaultRoute">Generate an interface specific default route..</param>
        /// <param name="zebosGranularDebug">Enable granular debug in routing protocols..</param>
        /// <param name="dmzIcmpRedirect">Enable ICMP redirect on DMZ zone..</param>
        /// <param name="enforceStrictTcpComplianceRfc5961">Enforce Strict TCP Compliance with RFC5961.</param>
        public DiagAdvancedNetworkDiagAdvancedNetwork(bool flushAlternatePathFlows = default(bool), bool updateRouteVersion = default(bool), bool tcpPacketOptionTagging = default(bool), bool fixMalformedTcpHeaders = default(bool), bool sequenceNumberRandomization = default(bool), bool synValidation = default(bool), bool debounceInterfaceStateChanges = default(bool), bool clearDfBit = default(bool), bool smallerFirstFragment = default(bool), bool ipv6SmallFragment = default(bool), bool overrideMac = default(bool), bool dropRecordRoute = default(bool), bool advertiseFqdnRoute = default(bool), bool generateInterfaceDefaultRoute = default(bool), bool zebosGranularDebug = default(bool), bool dmzIcmpRedirect = default(bool), bool enforceStrictTcpComplianceRfc5961 = default(bool))
        {
            this.FlushAlternatePathFlows = flushAlternatePathFlows;
            this.UpdateRouteVersion = updateRouteVersion;
            this.TcpPacketOptionTagging = tcpPacketOptionTagging;
            this.FixMalformedTcpHeaders = fixMalformedTcpHeaders;
            this.SequenceNumberRandomization = sequenceNumberRandomization;
            this.SynValidation = synValidation;
            this.DebounceInterfaceStateChanges = debounceInterfaceStateChanges;
            this.ClearDfBit = clearDfBit;
            this.SmallerFirstFragment = smallerFirstFragment;
            this.Ipv6SmallFragment = ipv6SmallFragment;
            this.OverrideMac = overrideMac;
            this.DropRecordRoute = dropRecordRoute;
            this.AdvertiseFqdnRoute = advertiseFqdnRoute;
            this.GenerateInterfaceDefaultRoute = generateInterfaceDefaultRoute;
            this.ZebosGranularDebug = zebosGranularDebug;
            this.DmzIcmpRedirect = dmzIcmpRedirect;
            this.EnforceStrictTcpComplianceRfc5961 = enforceStrictTcpComplianceRfc5961;
        }

        /// <summary>
        /// Enable flushing flows on alternate path when normal route path is enabled (affects existing connections).
        /// </summary>
        /// <value>Enable flushing flows on alternate path when normal route path is enabled (affects existing connections).</value>
        [DataMember(Name = "flush_alternate_path_flows", EmitDefaultValue = true)]
        public bool FlushAlternatePathFlows { get; set; }

        /// <summary>
        /// Enable updating route version when route is enabled/disabled (affects existing connections).
        /// </summary>
        /// <value>Enable updating route version when route is enabled/disabled (affects existing connections).</value>
        [DataMember(Name = "update_route_version", EmitDefaultValue = true)]
        public bool UpdateRouteVersion { get; set; }

        /// <summary>
        /// Enable TCP packet option tagging.
        /// </summary>
        /// <value>Enable TCP packet option tagging.</value>
        [DataMember(Name = "tcp_packet_option_tagging", EmitDefaultValue = true)]
        public bool TcpPacketOptionTagging { get; set; }

        /// <summary>
        /// Enable fix/ignore malformed TCP headers.
        /// </summary>
        /// <value>Enable fix/ignore malformed TCP headers.</value>
        [DataMember(Name = "fix_malformed_tcp_headers", EmitDefaultValue = true)]
        public bool FixMalformedTcpHeaders { get; set; }

        /// <summary>
        /// Enable TCP sequence number randomization.
        /// </summary>
        /// <value>Enable TCP sequence number randomization.</value>
        [DataMember(Name = "sequence_number_randomization", EmitDefaultValue = true)]
        public bool SequenceNumberRandomization { get; set; }

        /// <summary>
        /// Enable performing SYN validation when not operating in strict TCP compliance mode.
        /// </summary>
        /// <value>Enable performing SYN validation when not operating in strict TCP compliance mode.</value>
        [DataMember(Name = "syn_validation", EmitDefaultValue = true)]
        public bool SynValidation { get; set; }

        /// <summary>
        /// Enable Debounce Interface State Changes for routing protocols
        /// </summary>
        /// <value>Enable Debounce Interface State Changes for routing protocols</value>
        [DataMember(Name = "debounce_interface_state_changes", EmitDefaultValue = true)]
        public bool DebounceInterfaceStateChanges { get; set; }

        /// <summary>
        /// Enable clear DF (don&#39;t fragment) bit.
        /// </summary>
        /// <value>Enable clear DF (don&#39;t fragment) bit.</value>
        [DataMember(Name = "clear_df_bit", EmitDefaultValue = true)]
        public bool ClearDfBit { get; set; }

        /// <summary>
        /// Enable smaller first fragment packets.
        /// </summary>
        /// <value>Enable smaller first fragment packets.</value>
        [DataMember(Name = "smaller_first_fragment", EmitDefaultValue = true)]
        public bool SmallerFirstFragment { get; set; }

        /// <summary>
        /// Enable IPv6 Fragmentation Packets smaller than 1280 bytes.
        /// </summary>
        /// <value>Enable IPv6 Fragmentation Packets smaller than 1280 bytes.</value>
        [DataMember(Name = "ipv6_small_fragment", EmitDefaultValue = true)]
        public bool Ipv6SmallFragment { get; set; }

        /// <summary>
        /// Enable override MAC address when NAT.
        /// </summary>
        /// <value>Enable override MAC address when NAT.</value>
        [DataMember(Name = "override_mac", EmitDefaultValue = true)]
        public bool OverrideMac { get; set; }

        /// <summary>
        /// Enable droping record route packets.
        /// </summary>
        /// <value>Enable droping record route packets.</value>
        [DataMember(Name = "drop_record_route", EmitDefaultValue = true)]
        public bool DropRecordRoute { get; set; }

        /// <summary>
        /// Enable advertisement of FQDN based policy route to dynamic routing protocol.
        /// </summary>
        /// <value>Enable advertisement of FQDN based policy route to dynamic routing protocol.</value>
        [DataMember(Name = "advertise_fqdn_route", EmitDefaultValue = true)]
        public bool AdvertiseFqdnRoute { get; set; }

        /// <summary>
        /// Generate an interface specific default route.
        /// </summary>
        /// <value>Generate an interface specific default route.</value>
        [DataMember(Name = "generate_interface_default_route", EmitDefaultValue = true)]
        public bool GenerateInterfaceDefaultRoute { get; set; }

        /// <summary>
        /// Enable granular debug in routing protocols.
        /// </summary>
        /// <value>Enable granular debug in routing protocols.</value>
        [DataMember(Name = "zebos_granular_debug", EmitDefaultValue = true)]
        public bool ZebosGranularDebug { get; set; }

        /// <summary>
        /// Enable ICMP redirect on DMZ zone.
        /// </summary>
        /// <value>Enable ICMP redirect on DMZ zone.</value>
        [DataMember(Name = "dmz_icmp_redirect", EmitDefaultValue = true)]
        public bool DmzIcmpRedirect { get; set; }

        /// <summary>
        /// Enforce Strict TCP Compliance with RFC5961
        /// </summary>
        /// <value>Enforce Strict TCP Compliance with RFC5961</value>
        [DataMember(Name = "enforce_strict_tcp_compliance_rfc5961", EmitDefaultValue = true)]
        public bool EnforceStrictTcpComplianceRfc5961 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedNetworkDiagAdvancedNetwork {\n");
            sb.Append("  FlushAlternatePathFlows: ").Append(FlushAlternatePathFlows).Append("\n");
            sb.Append("  UpdateRouteVersion: ").Append(UpdateRouteVersion).Append("\n");
            sb.Append("  TcpPacketOptionTagging: ").Append(TcpPacketOptionTagging).Append("\n");
            sb.Append("  FixMalformedTcpHeaders: ").Append(FixMalformedTcpHeaders).Append("\n");
            sb.Append("  SequenceNumberRandomization: ").Append(SequenceNumberRandomization).Append("\n");
            sb.Append("  SynValidation: ").Append(SynValidation).Append("\n");
            sb.Append("  DebounceInterfaceStateChanges: ").Append(DebounceInterfaceStateChanges).Append("\n");
            sb.Append("  ClearDfBit: ").Append(ClearDfBit).Append("\n");
            sb.Append("  SmallerFirstFragment: ").Append(SmallerFirstFragment).Append("\n");
            sb.Append("  Ipv6SmallFragment: ").Append(Ipv6SmallFragment).Append("\n");
            sb.Append("  OverrideMac: ").Append(OverrideMac).Append("\n");
            sb.Append("  DropRecordRoute: ").Append(DropRecordRoute).Append("\n");
            sb.Append("  AdvertiseFqdnRoute: ").Append(AdvertiseFqdnRoute).Append("\n");
            sb.Append("  GenerateInterfaceDefaultRoute: ").Append(GenerateInterfaceDefaultRoute).Append("\n");
            sb.Append("  ZebosGranularDebug: ").Append(ZebosGranularDebug).Append("\n");
            sb.Append("  DmzIcmpRedirect: ").Append(DmzIcmpRedirect).Append("\n");
            sb.Append("  EnforceStrictTcpComplianceRfc5961: ").Append(EnforceStrictTcpComplianceRfc5961).Append("\n");
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
            return this.Equals(input as DiagAdvancedNetworkDiagAdvancedNetwork);
        }

        /// <summary>
        /// Returns true if DiagAdvancedNetworkDiagAdvancedNetwork instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedNetworkDiagAdvancedNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedNetworkDiagAdvancedNetwork input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FlushAlternatePathFlows == input.FlushAlternatePathFlows ||
                    this.FlushAlternatePathFlows.Equals(input.FlushAlternatePathFlows)
                ) && 
                (
                    this.UpdateRouteVersion == input.UpdateRouteVersion ||
                    this.UpdateRouteVersion.Equals(input.UpdateRouteVersion)
                ) && 
                (
                    this.TcpPacketOptionTagging == input.TcpPacketOptionTagging ||
                    this.TcpPacketOptionTagging.Equals(input.TcpPacketOptionTagging)
                ) && 
                (
                    this.FixMalformedTcpHeaders == input.FixMalformedTcpHeaders ||
                    this.FixMalformedTcpHeaders.Equals(input.FixMalformedTcpHeaders)
                ) && 
                (
                    this.SequenceNumberRandomization == input.SequenceNumberRandomization ||
                    this.SequenceNumberRandomization.Equals(input.SequenceNumberRandomization)
                ) && 
                (
                    this.SynValidation == input.SynValidation ||
                    this.SynValidation.Equals(input.SynValidation)
                ) && 
                (
                    this.DebounceInterfaceStateChanges == input.DebounceInterfaceStateChanges ||
                    this.DebounceInterfaceStateChanges.Equals(input.DebounceInterfaceStateChanges)
                ) && 
                (
                    this.ClearDfBit == input.ClearDfBit ||
                    this.ClearDfBit.Equals(input.ClearDfBit)
                ) && 
                (
                    this.SmallerFirstFragment == input.SmallerFirstFragment ||
                    this.SmallerFirstFragment.Equals(input.SmallerFirstFragment)
                ) && 
                (
                    this.Ipv6SmallFragment == input.Ipv6SmallFragment ||
                    this.Ipv6SmallFragment.Equals(input.Ipv6SmallFragment)
                ) && 
                (
                    this.OverrideMac == input.OverrideMac ||
                    this.OverrideMac.Equals(input.OverrideMac)
                ) && 
                (
                    this.DropRecordRoute == input.DropRecordRoute ||
                    this.DropRecordRoute.Equals(input.DropRecordRoute)
                ) && 
                (
                    this.AdvertiseFqdnRoute == input.AdvertiseFqdnRoute ||
                    this.AdvertiseFqdnRoute.Equals(input.AdvertiseFqdnRoute)
                ) && 
                (
                    this.GenerateInterfaceDefaultRoute == input.GenerateInterfaceDefaultRoute ||
                    this.GenerateInterfaceDefaultRoute.Equals(input.GenerateInterfaceDefaultRoute)
                ) && 
                (
                    this.ZebosGranularDebug == input.ZebosGranularDebug ||
                    this.ZebosGranularDebug.Equals(input.ZebosGranularDebug)
                ) && 
                (
                    this.DmzIcmpRedirect == input.DmzIcmpRedirect ||
                    this.DmzIcmpRedirect.Equals(input.DmzIcmpRedirect)
                ) && 
                (
                    this.EnforceStrictTcpComplianceRfc5961 == input.EnforceStrictTcpComplianceRfc5961 ||
                    this.EnforceStrictTcpComplianceRfc5961.Equals(input.EnforceStrictTcpComplianceRfc5961)
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
                hashCode = (hashCode * 59) + this.FlushAlternatePathFlows.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateRouteVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.TcpPacketOptionTagging.GetHashCode();
                hashCode = (hashCode * 59) + this.FixMalformedTcpHeaders.GetHashCode();
                hashCode = (hashCode * 59) + this.SequenceNumberRandomization.GetHashCode();
                hashCode = (hashCode * 59) + this.SynValidation.GetHashCode();
                hashCode = (hashCode * 59) + this.DebounceInterfaceStateChanges.GetHashCode();
                hashCode = (hashCode * 59) + this.ClearDfBit.GetHashCode();
                hashCode = (hashCode * 59) + this.SmallerFirstFragment.GetHashCode();
                hashCode = (hashCode * 59) + this.Ipv6SmallFragment.GetHashCode();
                hashCode = (hashCode * 59) + this.OverrideMac.GetHashCode();
                hashCode = (hashCode * 59) + this.DropRecordRoute.GetHashCode();
                hashCode = (hashCode * 59) + this.AdvertiseFqdnRoute.GetHashCode();
                hashCode = (hashCode * 59) + this.GenerateInterfaceDefaultRoute.GetHashCode();
                hashCode = (hashCode * 59) + this.ZebosGranularDebug.GetHashCode();
                hashCode = (hashCode * 59) + this.DmzIcmpRedirect.GetHashCode();
                hashCode = (hashCode * 59) + this.EnforceStrictTcpComplianceRfc5961.GetHashCode();
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
