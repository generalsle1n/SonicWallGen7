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
    /// Enter multicast configuration mode.
    /// </summary>
    [DataContract(Name = "multicast_multicast")]
    public partial class MulticastMulticast : IEquatable<MulticastMulticast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticast" /> class.
        /// </summary>
        /// <param name="enable">Enable multicast configuration..</param>
        /// <param name="enableRequireIgmpMembership">Enable require IGMP membership reports for multicast data forwarding..</param>
        /// <param name="requireIgmpMembershipTimeout">Set the multicast state table entry timeout in minutes..</param>
        /// <param name="reception">reception.</param>
        public MulticastMulticast(bool enable = default(bool), bool enableRequireIgmpMembership = default(bool), decimal requireIgmpMembershipTimeout = default(decimal), MulticastMulticastReception reception = default(MulticastMulticastReception))
        {
            this.Enable = enable;
            this.EnableRequireIgmpMembership = enableRequireIgmpMembership;
            this.RequireIgmpMembershipTimeout = requireIgmpMembershipTimeout;
            this.Reception = reception;
        }

        /// <summary>
        /// Enable multicast configuration.
        /// </summary>
        /// <value>Enable multicast configuration.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Enable require IGMP membership reports for multicast data forwarding.
        /// </summary>
        /// <value>Enable require IGMP membership reports for multicast data forwarding.</value>
        [DataMember(Name = "enable_require_igmp_membership", EmitDefaultValue = true)]
        public bool EnableRequireIgmpMembership { get; set; }

        /// <summary>
        /// Set the multicast state table entry timeout in minutes.
        /// </summary>
        /// <value>Set the multicast state table entry timeout in minutes.</value>
        [DataMember(Name = "require_igmp_membership_timeout", EmitDefaultValue = false)]
        public decimal RequireIgmpMembershipTimeout { get; set; }

        /// <summary>
        /// Gets or Sets Reception
        /// </summary>
        [DataMember(Name = "reception", EmitDefaultValue = false)]
        public MulticastMulticastReception Reception { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MulticastMulticast {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  EnableRequireIgmpMembership: ").Append(EnableRequireIgmpMembership).Append("\n");
            sb.Append("  RequireIgmpMembershipTimeout: ").Append(RequireIgmpMembershipTimeout).Append("\n");
            sb.Append("  Reception: ").Append(Reception).Append("\n");
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
            return this.Equals(input as MulticastMulticast);
        }

        /// <summary>
        /// Returns true if MulticastMulticast instances are equal
        /// </summary>
        /// <param name="input">Instance of MulticastMulticast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MulticastMulticast input)
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
                    this.EnableRequireIgmpMembership == input.EnableRequireIgmpMembership ||
                    this.EnableRequireIgmpMembership.Equals(input.EnableRequireIgmpMembership)
                ) && 
                (
                    this.RequireIgmpMembershipTimeout == input.RequireIgmpMembershipTimeout ||
                    this.RequireIgmpMembershipTimeout.Equals(input.RequireIgmpMembershipTimeout)
                ) && 
                (
                    this.Reception == input.Reception ||
                    (this.Reception != null &&
                    this.Reception.Equals(input.Reception))
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
                hashCode = (hashCode * 59) + this.EnableRequireIgmpMembership.GetHashCode();
                hashCode = (hashCode * 59) + this.RequireIgmpMembershipTimeout.GetHashCode();
                if (this.Reception != null)
                {
                    hashCode = (hashCode * 59) + this.Reception.GetHashCode();
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
