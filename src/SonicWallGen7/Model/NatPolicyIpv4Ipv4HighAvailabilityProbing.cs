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
    /// Enable HA probing and enter configuration mode. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "nat_policy_ipv4_ipv4_high_availability_probing")]
    public partial class NatPolicyIpv4Ipv4HighAvailabilityProbing : IEquatable<NatPolicyIpv4Ipv4HighAvailabilityProbing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv4Ipv4HighAvailabilityProbing" /> class.
        /// </summary>
        /// <param name="probeEvery">Probe interval (in seconds)..</param>
        /// <param name="probeType">probeType.</param>
        /// <param name="replyTimeout">Set reply timeout (in seconds)..</param>
        /// <param name="deactivateAfter">Set number of missed probes required before deactivating the NAT policy..</param>
        /// <param name="reactivateAfter">Set number of successful probes required before reactivating the NAT policy..</param>
        /// <param name="rstAsMiss">Enable count RST response as miss..</param>
        /// <param name="portProbing">Enable port probing..</param>
        public NatPolicyIpv4Ipv4HighAvailabilityProbing(decimal probeEvery = default(decimal), NatPolicyIpv4Ipv4HighAvailabilityProbingProbeType probeType = default(NatPolicyIpv4Ipv4HighAvailabilityProbingProbeType), decimal replyTimeout = default(decimal), decimal deactivateAfter = default(decimal), decimal reactivateAfter = default(decimal), bool rstAsMiss = default(bool), bool portProbing = default(bool))
        {
            this.ProbeEvery = probeEvery;
            this.ProbeType = probeType;
            this.ReplyTimeout = replyTimeout;
            this.DeactivateAfter = deactivateAfter;
            this.ReactivateAfter = reactivateAfter;
            this.RstAsMiss = rstAsMiss;
            this.PortProbing = portProbing;
        }

        /// <summary>
        /// Probe interval (in seconds).
        /// </summary>
        /// <value>Probe interval (in seconds).</value>
        [DataMember(Name = "probe_every", EmitDefaultValue = false)]
        public decimal ProbeEvery { get; set; }

        /// <summary>
        /// Gets or Sets ProbeType
        /// </summary>
        [DataMember(Name = "probe_type", EmitDefaultValue = false)]
        public NatPolicyIpv4Ipv4HighAvailabilityProbingProbeType ProbeType { get; set; }

        /// <summary>
        /// Set reply timeout (in seconds).
        /// </summary>
        /// <value>Set reply timeout (in seconds).</value>
        [DataMember(Name = "reply_timeout", EmitDefaultValue = false)]
        public decimal ReplyTimeout { get; set; }

        /// <summary>
        /// Set number of missed probes required before deactivating the NAT policy.
        /// </summary>
        /// <value>Set number of missed probes required before deactivating the NAT policy.</value>
        [DataMember(Name = "deactivate_after", EmitDefaultValue = false)]
        public decimal DeactivateAfter { get; set; }

        /// <summary>
        /// Set number of successful probes required before reactivating the NAT policy.
        /// </summary>
        /// <value>Set number of successful probes required before reactivating the NAT policy.</value>
        [DataMember(Name = "reactivate_after", EmitDefaultValue = false)]
        public decimal ReactivateAfter { get; set; }

        /// <summary>
        /// Enable count RST response as miss.
        /// </summary>
        /// <value>Enable count RST response as miss.</value>
        [DataMember(Name = "rst_as_miss", EmitDefaultValue = true)]
        public bool RstAsMiss { get; set; }

        /// <summary>
        /// Enable port probing.
        /// </summary>
        /// <value>Enable port probing.</value>
        [DataMember(Name = "port_probing", EmitDefaultValue = true)]
        public bool PortProbing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NatPolicyIpv4Ipv4HighAvailabilityProbing {\n");
            sb.Append("  ProbeEvery: ").Append(ProbeEvery).Append("\n");
            sb.Append("  ProbeType: ").Append(ProbeType).Append("\n");
            sb.Append("  ReplyTimeout: ").Append(ReplyTimeout).Append("\n");
            sb.Append("  DeactivateAfter: ").Append(DeactivateAfter).Append("\n");
            sb.Append("  ReactivateAfter: ").Append(ReactivateAfter).Append("\n");
            sb.Append("  RstAsMiss: ").Append(RstAsMiss).Append("\n");
            sb.Append("  PortProbing: ").Append(PortProbing).Append("\n");
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
            return this.Equals(input as NatPolicyIpv4Ipv4HighAvailabilityProbing);
        }

        /// <summary>
        /// Returns true if NatPolicyIpv4Ipv4HighAvailabilityProbing instances are equal
        /// </summary>
        /// <param name="input">Instance of NatPolicyIpv4Ipv4HighAvailabilityProbing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NatPolicyIpv4Ipv4HighAvailabilityProbing input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProbeEvery == input.ProbeEvery ||
                    this.ProbeEvery.Equals(input.ProbeEvery)
                ) && 
                (
                    this.ProbeType == input.ProbeType ||
                    (this.ProbeType != null &&
                    this.ProbeType.Equals(input.ProbeType))
                ) && 
                (
                    this.ReplyTimeout == input.ReplyTimeout ||
                    this.ReplyTimeout.Equals(input.ReplyTimeout)
                ) && 
                (
                    this.DeactivateAfter == input.DeactivateAfter ||
                    this.DeactivateAfter.Equals(input.DeactivateAfter)
                ) && 
                (
                    this.ReactivateAfter == input.ReactivateAfter ||
                    this.ReactivateAfter.Equals(input.ReactivateAfter)
                ) && 
                (
                    this.RstAsMiss == input.RstAsMiss ||
                    this.RstAsMiss.Equals(input.RstAsMiss)
                ) && 
                (
                    this.PortProbing == input.PortProbing ||
                    this.PortProbing.Equals(input.PortProbing)
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
                hashCode = (hashCode * 59) + this.ProbeEvery.GetHashCode();
                if (this.ProbeType != null)
                {
                    hashCode = (hashCode * 59) + this.ProbeType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReplyTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.DeactivateAfter.GetHashCode();
                hashCode = (hashCode * 59) + this.ReactivateAfter.GetHashCode();
                hashCode = (hashCode * 59) + this.RstAsMiss.GetHashCode();
                hashCode = (hashCode * 59) + this.PortProbing.GetHashCode();
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