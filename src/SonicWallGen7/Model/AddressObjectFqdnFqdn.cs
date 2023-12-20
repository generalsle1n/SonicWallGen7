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
    /// FQDN address object.
    /// </summary>
    [DataContract(Name = "address_object_fqdn_fqdn")]
    public partial class AddressObjectFqdnFqdn : IEquatable<AddressObjectFqdnFqdn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressObjectFqdnFqdn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressObjectFqdnFqdn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressObjectFqdnFqdn" /> class.
        /// </summary>
        /// <param name="name">Address object name. (required).</param>
        /// <param name="domain">Set address object fully qualified domain name (FQDN)..</param>
        /// <param name="zone">Address object zone..</param>
        /// <param name="dnsTtl">Manually set DNS entries&#39; TTL..</param>
        public AddressObjectFqdnFqdn(string name = default(string), string domain = default(string), string zone = default(string), decimal dnsTtl = default(decimal))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddressObjectFqdnFqdn and cannot be null");
            }
            this.Name = name;
            this.Domain = domain;
            this.Zone = zone;
            this.DnsTtl = dnsTtl;
        }

        /// <summary>
        /// Address object name.
        /// </summary>
        /// <value>Address object name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Address object UUID.
        /// </summary>
        /// <value>Address object UUID.</value>
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
        /// Set address object fully qualified domain name (FQDN).
        /// </summary>
        /// <value>Set address object fully qualified domain name (FQDN).</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Address object zone.
        /// </summary>
        /// <value>Address object zone.</value>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        public string Zone { get; set; }

        /// <summary>
        /// Manually set DNS entries&#39; TTL.
        /// </summary>
        /// <value>Manually set DNS entries&#39; TTL.</value>
        [DataMember(Name = "dns_ttl", EmitDefaultValue = false)]
        public decimal DnsTtl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressObjectFqdnFqdn {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  DnsTtl: ").Append(DnsTtl).Append("\n");
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
            return this.Equals(input as AddressObjectFqdnFqdn);
        }

        /// <summary>
        /// Returns true if AddressObjectFqdnFqdn instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressObjectFqdnFqdn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressObjectFqdnFqdn input)
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
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.DnsTtl == input.DnsTtl ||
                    this.DnsTtl.Equals(input.DnsTtl)
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Zone != null)
                {
                    hashCode = (hashCode * 59) + this.Zone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DnsTtl.GetHashCode();
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
