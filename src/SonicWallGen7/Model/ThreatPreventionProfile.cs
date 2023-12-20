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
    /// Threat prevention profile configuration.
    /// </summary>
    [DataContract(Name = "threat_prevention_profile")]
    public partial class ThreatPreventionProfile : IEquatable<ThreatPreventionProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatPreventionProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThreatPreventionProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatPreventionProfile" /> class.
        /// </summary>
        /// <param name="name">Threat prevention profile name. (required).</param>
        /// <param name="negate">Enable threat prevention profile negate..</param>
        /// <param name="threatPreventionObject">Assign threat-prevention-object to profile..</param>
        public ThreatPreventionProfile(string name = default(string), bool negate = default(bool), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> threatPreventionObject = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ThreatPreventionProfile and cannot be null");
            }
            this.Name = name;
            this.Negate = negate;
            this.ThreatPreventionObject = threatPreventionObject;
        }

        /// <summary>
        /// Threat prevention profile name.
        /// </summary>
        /// <value>Threat prevention profile name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Threat prevention profile UUID.
        /// </summary>
        /// <value>Threat prevention profile UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Enable threat prevention profile negate.
        /// </summary>
        /// <value>Enable threat prevention profile negate.</value>
        [DataMember(Name = "negate", EmitDefaultValue = true)]
        public bool Negate { get; set; }

        /// <summary>
        /// Assign threat-prevention-object to profile.
        /// </summary>
        /// <value>Assign threat-prevention-object to profile.</value>
        [DataMember(Name = "threat_prevention_object", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> ThreatPreventionObject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreatPreventionProfile {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Negate: ").Append(Negate).Append("\n");
            sb.Append("  ThreatPreventionObject: ").Append(ThreatPreventionObject).Append("\n");
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
            return this.Equals(input as ThreatPreventionProfile);
        }

        /// <summary>
        /// Returns true if ThreatPreventionProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreatPreventionProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreatPreventionProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Negate == input.Negate ||
                    this.Negate.Equals(input.Negate)
                ) && 
                (
                    this.ThreatPreventionObject == input.ThreatPreventionObject ||
                    this.ThreatPreventionObject != null &&
                    input.ThreatPreventionObject != null &&
                    this.ThreatPreventionObject.SequenceEqual(input.ThreatPreventionObject)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Negate.GetHashCode();
                if (this.ThreatPreventionObject != null)
                {
                    hashCode = (hashCode * 59) + this.ThreatPreventionObject.GetHashCode();
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