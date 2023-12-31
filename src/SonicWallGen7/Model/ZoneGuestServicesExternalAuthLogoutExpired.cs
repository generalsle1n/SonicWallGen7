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
    /// Enable auto-session logout.
    /// </summary>
    [DataContract(Name = "zone_guest_services_external_auth_logout_expired")]
    public partial class ZoneGuestServicesExternalAuthLogoutExpired : IEquatable<ZoneGuestServicesExternalAuthLogoutExpired>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesExternalAuthLogoutExpired" /> class.
        /// </summary>
        /// <param name="enable">Disable Auto-Session Logout..</param>
        /// <param name="every">Set auto-logout expired session every (minutes)..</param>
        /// <param name="cgi">cgi.</param>
        public ZoneGuestServicesExternalAuthLogoutExpired(bool enable = default(bool), decimal every = default(decimal), ZoneGuestServicesExternalAuthLogoutExpiredCgi cgi = default(ZoneGuestServicesExternalAuthLogoutExpiredCgi))
        {
            this.Enable = enable;
            this.Every = every;
            this.Cgi = cgi;
        }

        /// <summary>
        /// Disable Auto-Session Logout.
        /// </summary>
        /// <value>Disable Auto-Session Logout.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set auto-logout expired session every (minutes).
        /// </summary>
        /// <value>Set auto-logout expired session every (minutes).</value>
        [DataMember(Name = "every", EmitDefaultValue = false)]
        public decimal Every { get; set; }

        /// <summary>
        /// Gets or Sets Cgi
        /// </summary>
        [DataMember(Name = "cgi", EmitDefaultValue = false)]
        public ZoneGuestServicesExternalAuthLogoutExpiredCgi Cgi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesExternalAuthLogoutExpired {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Cgi: ").Append(Cgi).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesExternalAuthLogoutExpired);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesExternalAuthLogoutExpired instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesExternalAuthLogoutExpired to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesExternalAuthLogoutExpired input)
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
                    this.Every == input.Every ||
                    this.Every.Equals(input.Every)
                ) && 
                (
                    this.Cgi == input.Cgi ||
                    (this.Cgi != null &&
                    this.Cgi.Equals(input.Cgi))
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
                hashCode = (hashCode * 59) + this.Every.GetHashCode();
                if (this.Cgi != null)
                {
                    hashCode = (hashCode * 59) + this.Cgi.GetHashCode();
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
