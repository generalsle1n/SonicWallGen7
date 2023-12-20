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
    /// Set idle timeout for custom guest policy page. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "zone_guest_services_policy_page_non_authentication_idle_timeout")]
    public partial class ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout : IEquatable<ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout>, IValidatableObject
    {
        /// <summary>
        /// Set the idle timeout in seconds.
        /// </summary>
        /// <value>Set the idle timeout in seconds.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum Seconds for value: seconds
            /// </summary>
            [EnumMember(Value = "seconds")]
            Seconds = 1,

            /// <summary>
            /// Enum Minutes for value: minutes
            /// </summary>
            [EnumMember(Value = "minutes")]
            Minutes = 2,

            /// <summary>
            /// Enum Hours for value: hours
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours = 3,

            /// <summary>
            /// Enum Days for value: days
            /// </summary>
            [EnumMember(Value = "days")]
            Days = 4
        }


        /// <summary>
        /// Set the idle timeout in seconds.
        /// </summary>
        /// <value>Set the idle timeout in seconds.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="unit">Set the idle timeout in seconds..</param>
        public ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout(decimal value = default(decimal), UnitEnum? unit = default(UnitEnum?))
        {
            this.Value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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