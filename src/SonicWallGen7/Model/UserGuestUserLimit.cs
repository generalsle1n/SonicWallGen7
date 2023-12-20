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
    /// Set the receive or transmit limit in MB for the guest account.
    /// </summary>
    [DataContract(Name = "user_guest_user_limit")]
    public partial class UserGuestUserLimit : IEquatable<UserGuestUserLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGuestUserLimit" /> class.
        /// </summary>
        /// <param name="receive">Set the receive limit in MB for the guest account..</param>
        /// <param name="transmit">Set the transmit limit in MB for the guest account..</param>
        public UserGuestUserLimit(decimal receive = default(decimal), decimal transmit = default(decimal))
        {
            this.Receive = receive;
            this.Transmit = transmit;
        }

        /// <summary>
        /// Set the receive limit in MB for the guest account.
        /// </summary>
        /// <value>Set the receive limit in MB for the guest account.</value>
        [DataMember(Name = "receive", EmitDefaultValue = false)]
        public decimal Receive { get; set; }

        /// <summary>
        /// Set the transmit limit in MB for the guest account.
        /// </summary>
        /// <value>Set the transmit limit in MB for the guest account.</value>
        [DataMember(Name = "transmit", EmitDefaultValue = false)]
        public decimal Transmit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGuestUserLimit {\n");
            sb.Append("  Receive: ").Append(Receive).Append("\n");
            sb.Append("  Transmit: ").Append(Transmit).Append("\n");
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
            return this.Equals(input as UserGuestUserLimit);
        }

        /// <summary>
        /// Returns true if UserGuestUserLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of UserGuestUserLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGuestUserLimit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Receive == input.Receive ||
                    this.Receive.Equals(input.Receive)
                ) && 
                (
                    this.Transmit == input.Transmit ||
                    this.Transmit.Equals(input.Transmit)
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
                hashCode = (hashCode * 59) + this.Receive.GetHashCode();
                hashCode = (hashCode * 59) + this.Transmit.GetHashCode();
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