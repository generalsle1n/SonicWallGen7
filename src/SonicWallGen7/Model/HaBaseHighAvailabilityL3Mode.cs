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
    /// Enter HA L3 mode.
    /// </summary>
    [DataContract(Name = "ha_base_high_availability_l3_mode")]
    public partial class HaBaseHighAvailabilityL3Mode : IEquatable<HaBaseHighAvailabilityL3Mode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HaBaseHighAvailabilityL3Mode" /> class.
        /// </summary>
        /// <param name="enable">Enable L3 mode HA..</param>
        /// <param name="primaryIp">Configure L3 mode HA primary unit IP..</param>
        /// <param name="secondaryIp">Configure L3 mode HA secondary unit IP..</param>
        /// <param name="primaryGateway">Configure L3 mode HA primary unit gateway IP..</param>
        /// <param name="secondaryGateway">Configure L3 mode HA secondary unit gateway IP..</param>
        public HaBaseHighAvailabilityL3Mode(bool enable = default(bool), string primaryIp = default(string), string secondaryIp = default(string), string primaryGateway = default(string), string secondaryGateway = default(string))
        {
            this.Enable = enable;
            this.PrimaryIp = primaryIp;
            this.SecondaryIp = secondaryIp;
            this.PrimaryGateway = primaryGateway;
            this.SecondaryGateway = secondaryGateway;
        }

        /// <summary>
        /// Enable L3 mode HA.
        /// </summary>
        /// <value>Enable L3 mode HA.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Configure L3 mode HA primary unit IP.
        /// </summary>
        /// <value>Configure L3 mode HA primary unit IP.</value>
        [DataMember(Name = "primary_ip", EmitDefaultValue = false)]
        public string PrimaryIp { get; set; }

        /// <summary>
        /// Configure L3 mode HA secondary unit IP.
        /// </summary>
        /// <value>Configure L3 mode HA secondary unit IP.</value>
        [DataMember(Name = "secondary_ip", EmitDefaultValue = false)]
        public string SecondaryIp { get; set; }

        /// <summary>
        /// Configure L3 mode HA primary unit gateway IP.
        /// </summary>
        /// <value>Configure L3 mode HA primary unit gateway IP.</value>
        [DataMember(Name = "primary_gateway", EmitDefaultValue = false)]
        public string PrimaryGateway { get; set; }

        /// <summary>
        /// Configure L3 mode HA secondary unit gateway IP.
        /// </summary>
        /// <value>Configure L3 mode HA secondary unit gateway IP.</value>
        [DataMember(Name = "secondary_gateway", EmitDefaultValue = false)]
        public string SecondaryGateway { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HaBaseHighAvailabilityL3Mode {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  PrimaryIp: ").Append(PrimaryIp).Append("\n");
            sb.Append("  SecondaryIp: ").Append(SecondaryIp).Append("\n");
            sb.Append("  PrimaryGateway: ").Append(PrimaryGateway).Append("\n");
            sb.Append("  SecondaryGateway: ").Append(SecondaryGateway).Append("\n");
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
            return this.Equals(input as HaBaseHighAvailabilityL3Mode);
        }

        /// <summary>
        /// Returns true if HaBaseHighAvailabilityL3Mode instances are equal
        /// </summary>
        /// <param name="input">Instance of HaBaseHighAvailabilityL3Mode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HaBaseHighAvailabilityL3Mode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.PrimaryIp == input.PrimaryIp ||
                    (this.PrimaryIp != null &&
                    this.PrimaryIp.Equals(input.PrimaryIp))
                ) && 
                (
                    this.SecondaryIp == input.SecondaryIp ||
                    (this.SecondaryIp != null &&
                    this.SecondaryIp.Equals(input.SecondaryIp))
                ) && 
                (
                    this.PrimaryGateway == input.PrimaryGateway ||
                    (this.PrimaryGateway != null &&
                    this.PrimaryGateway.Equals(input.PrimaryGateway))
                ) && 
                (
                    this.SecondaryGateway == input.SecondaryGateway ||
                    (this.SecondaryGateway != null &&
                    this.SecondaryGateway.Equals(input.SecondaryGateway))
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.PrimaryIp != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryIp.GetHashCode();
                }
                if (this.SecondaryIp != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryIp.GetHashCode();
                }
                if (this.PrimaryGateway != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryGateway.GetHashCode();
                }
                if (this.SecondaryGateway != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryGateway.GetHashCode();
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
