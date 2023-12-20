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
    /// Set SD-WAN probe interval.
    /// </summary>
    [DataContract(Name = "sdwan_sla_probe_ipv4_ipv4_interval")]
    public partial class SdwanSlaProbeIpv4Ipv4Interval : IEquatable<SdwanSlaProbeIpv4Ipv4Interval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanSlaProbeIpv4Ipv4Interval" /> class.
        /// </summary>
        /// <param name="missed">Probe state is set to DOWN after specified number of missed intervals..</param>
        /// <param name="successful">Probe state is set to UP after specified number of successful intervals..</param>
        public SdwanSlaProbeIpv4Ipv4Interval(decimal missed = default(decimal), decimal successful = default(decimal))
        {
            this.Missed = missed;
            this.Successful = successful;
        }

        /// <summary>
        /// Probe state is set to DOWN after specified number of missed intervals.
        /// </summary>
        /// <value>Probe state is set to DOWN after specified number of missed intervals.</value>
        [DataMember(Name = "missed", EmitDefaultValue = false)]
        public decimal Missed { get; set; }

        /// <summary>
        /// Probe state is set to UP after specified number of successful intervals.
        /// </summary>
        /// <value>Probe state is set to UP after specified number of successful intervals.</value>
        [DataMember(Name = "successful", EmitDefaultValue = false)]
        public decimal Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SdwanSlaProbeIpv4Ipv4Interval {\n");
            sb.Append("  Missed: ").Append(Missed).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as SdwanSlaProbeIpv4Ipv4Interval);
        }

        /// <summary>
        /// Returns true if SdwanSlaProbeIpv4Ipv4Interval instances are equal
        /// </summary>
        /// <param name="input">Instance of SdwanSlaProbeIpv4Ipv4Interval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SdwanSlaProbeIpv4Ipv4Interval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Missed == input.Missed ||
                    this.Missed.Equals(input.Missed)
                ) && 
                (
                    this.Successful == input.Successful ||
                    this.Successful.Equals(input.Successful)
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
                hashCode = (hashCode * 59) + this.Missed.GetHashCode();
                hashCode = (hashCode * 59) + this.Successful.GetHashCode();
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
