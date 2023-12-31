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
    /// Enter its configuration mode.
    /// </summary>
    [DataContract(Name = "zone_guest_services_policy_page_non_authentication")]
    public partial class ZoneGuestServicesPolicyPageNonAuthentication : IEquatable<ZoneGuestServicesPolicyPageNonAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesPolicyPageNonAuthentication" /> class.
        /// </summary>
        /// <param name="enable">Enable policy page without authentication..</param>
        /// <param name="guestUsagePolicy">Set custom login page which may inculde HTML formatting..</param>
        /// <param name="idleTimeout">idleTimeout.</param>
        /// <param name="autoAccept">Enable auto accept policy page..</param>
        public ZoneGuestServicesPolicyPageNonAuthentication(bool enable = default(bool), string guestUsagePolicy = default(string), ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout idleTimeout = default(ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout), bool autoAccept = default(bool))
        {
            this.Enable = enable;
            this.GuestUsagePolicy = guestUsagePolicy;
            this.IdleTimeout = idleTimeout;
            this.AutoAccept = autoAccept;
        }

        /// <summary>
        /// Enable policy page without authentication.
        /// </summary>
        /// <value>Enable policy page without authentication.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set custom login page which may inculde HTML formatting.
        /// </summary>
        /// <value>Set custom login page which may inculde HTML formatting.</value>
        [DataMember(Name = "guest_usage_policy", EmitDefaultValue = false)]
        public string GuestUsagePolicy { get; set; }

        /// <summary>
        /// Gets or Sets IdleTimeout
        /// </summary>
        [DataMember(Name = "idle_timeout", EmitDefaultValue = true)]
        public ZoneGuestServicesPolicyPageNonAuthenticationIdleTimeout IdleTimeout { get; set; }

        /// <summary>
        /// Enable auto accept policy page.
        /// </summary>
        /// <value>Enable auto accept policy page.</value>
        [DataMember(Name = "auto_accept", EmitDefaultValue = true)]
        public bool AutoAccept { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesPolicyPageNonAuthentication {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  GuestUsagePolicy: ").Append(GuestUsagePolicy).Append("\n");
            sb.Append("  IdleTimeout: ").Append(IdleTimeout).Append("\n");
            sb.Append("  AutoAccept: ").Append(AutoAccept).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesPolicyPageNonAuthentication);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesPolicyPageNonAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesPolicyPageNonAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesPolicyPageNonAuthentication input)
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
                    this.GuestUsagePolicy == input.GuestUsagePolicy ||
                    (this.GuestUsagePolicy != null &&
                    this.GuestUsagePolicy.Equals(input.GuestUsagePolicy))
                ) && 
                (
                    this.IdleTimeout == input.IdleTimeout ||
                    (this.IdleTimeout != null &&
                    this.IdleTimeout.Equals(input.IdleTimeout))
                ) && 
                (
                    this.AutoAccept == input.AutoAccept ||
                    this.AutoAccept.Equals(input.AutoAccept)
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
                if (this.GuestUsagePolicy != null)
                {
                    hashCode = (hashCode * 59) + this.GuestUsagePolicy.GetHashCode();
                }
                if (this.IdleTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.IdleTimeout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoAccept.GetHashCode();
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
