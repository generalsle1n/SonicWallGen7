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
    /// geo ip status detail schema.
    /// </summary>
    [DataContract(Name = "show_status_geo_ip_status_detail")]
    public partial class ShowStatusGeoIpStatusDetail : IEquatable<ShowStatusGeoIpStatusDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusGeoIpStatusDetail" /> class.
        /// </summary>
        /// <param name="countryDatabase">countryDatabase.</param>
        /// <param name="message">message.</param>
        public ShowStatusGeoIpStatusDetail(string countryDatabase = default(string), string message = default(string))
        {
            this.CountryDatabase = countryDatabase;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets CountryDatabase
        /// </summary>
        [DataMember(Name = "country_database", EmitDefaultValue = false)]
        public string CountryDatabase { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusGeoIpStatusDetail {\n");
            sb.Append("  CountryDatabase: ").Append(CountryDatabase).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ShowStatusGeoIpStatusDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusGeoIpStatusDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusGeoIpStatusDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusGeoIpStatusDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryDatabase == input.CountryDatabase ||
                    (this.CountryDatabase != null &&
                    this.CountryDatabase.Equals(input.CountryDatabase))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.CountryDatabase != null)
                {
                    hashCode = (hashCode * 59) + this.CountryDatabase.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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