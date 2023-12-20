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
    /// Enter VoIP configuration mode.
    /// </summary>
    [DataContract(Name = "voip_voip")]
    public partial class VoipVoip : IEquatable<VoipVoip>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoipVoip" /> class.
        /// </summary>
        /// <param name="consistentNat">Enable consistent nat..</param>
        /// <param name="sip">sip.</param>
        /// <param name="h323">h323.</param>
        public VoipVoip(bool consistentNat = default(bool), VoipVoipSip sip = default(VoipVoipSip), VoipVoipH323 h323 = default(VoipVoipH323))
        {
            this.ConsistentNat = consistentNat;
            this.Sip = sip;
            this.H323 = h323;
        }

        /// <summary>
        /// Enable consistent nat.
        /// </summary>
        /// <value>Enable consistent nat.</value>
        [DataMember(Name = "consistent_nat", EmitDefaultValue = true)]
        public bool ConsistentNat { get; set; }

        /// <summary>
        /// Gets or Sets Sip
        /// </summary>
        [DataMember(Name = "sip", EmitDefaultValue = true)]
        public VoipVoipSip Sip { get; set; }

        /// <summary>
        /// Gets or Sets H323
        /// </summary>
        [DataMember(Name = "h323", EmitDefaultValue = true)]
        public VoipVoipH323 H323 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoipVoip {\n");
            sb.Append("  ConsistentNat: ").Append(ConsistentNat).Append("\n");
            sb.Append("  Sip: ").Append(Sip).Append("\n");
            sb.Append("  H323: ").Append(H323).Append("\n");
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
            return this.Equals(input as VoipVoip);
        }

        /// <summary>
        /// Returns true if VoipVoip instances are equal
        /// </summary>
        /// <param name="input">Instance of VoipVoip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoipVoip input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsistentNat == input.ConsistentNat ||
                    this.ConsistentNat.Equals(input.ConsistentNat)
                ) && 
                (
                    this.Sip == input.Sip ||
                    (this.Sip != null &&
                    this.Sip.Equals(input.Sip))
                ) && 
                (
                    this.H323 == input.H323 ||
                    (this.H323 != null &&
                    this.H323.Equals(input.H323))
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
                hashCode = (hashCode * 59) + this.ConsistentNat.GetHashCode();
                if (this.Sip != null)
                {
                    hashCode = (hashCode * 59) + this.Sip.GetHashCode();
                }
                if (this.H323 != null)
                {
                    hashCode = (hashCode * 59) + this.H323.GetHashCode();
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