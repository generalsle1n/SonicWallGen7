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
    /// Enable dynamic external object periodic download. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "dynamic_external_object_periodic_download")]
    public partial class DynamicExternalObjectPeriodicDownload : IEquatable<DynamicExternalObjectPeriodicDownload>, IValidatableObject
    {
        /// <summary>
        /// Set the dynamic external object periodic download interval.
        /// </summary>
        /// <value>Set the dynamic external object periodic download interval.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            /// <summary>
            /// Enum _5Minutes for value: 5-minutes
            /// </summary>
            [EnumMember(Value = "5-minutes")]
            _5Minutes = 1,

            /// <summary>
            /// Enum _15Minutes for value: 15-minutes
            /// </summary>
            [EnumMember(Value = "15-minutes")]
            _15Minutes = 2,

            /// <summary>
            /// Enum _1Hour for value: 1-hour
            /// </summary>
            [EnumMember(Value = "1-hour")]
            _1Hour = 3,

            /// <summary>
            /// Enum _24Hours for value: 24-hours
            /// </summary>
            [EnumMember(Value = "24-hours")]
            _24Hours = 4
        }


        /// <summary>
        /// Set the dynamic external object periodic download interval.
        /// </summary>
        /// <value>Set the dynamic external object periodic download interval.</value>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicExternalObjectPeriodicDownload" /> class.
        /// </summary>
        /// <param name="interval">Set the dynamic external object periodic download interval..</param>
        public DynamicExternalObjectPeriodicDownload(IntervalEnum? interval = default(IntervalEnum?))
        {
            this.Interval = interval;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicExternalObjectPeriodicDownload {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
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
            return this.Equals(input as DynamicExternalObjectPeriodicDownload);
        }

        /// <summary>
        /// Returns true if DynamicExternalObjectPeriodicDownload instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicExternalObjectPeriodicDownload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicExternalObjectPeriodicDownload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
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
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
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
