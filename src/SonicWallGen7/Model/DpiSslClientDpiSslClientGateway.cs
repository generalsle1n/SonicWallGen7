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
    /// Enable gateway anti-virus or anti-spyware for client DPI-SSL.
    /// </summary>
    [DataContract(Name = "dpi_ssl_client_dpi_ssl_client_gateway")]
    public partial class DpiSslClientDpiSslClientGateway : IEquatable<DpiSslClientDpiSslClientGateway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientGateway" /> class.
        /// </summary>
        /// <param name="antiVirus">Enable gateway anti-virus for client DPI-SSL..</param>
        /// <param name="antiSpyware">Enable gateway anti-spyware for client DPI-SSL..</param>
        public DpiSslClientDpiSslClientGateway(bool antiVirus = default(bool), bool antiSpyware = default(bool))
        {
            this.AntiVirus = antiVirus;
            this.AntiSpyware = antiSpyware;
        }

        /// <summary>
        /// Enable gateway anti-virus for client DPI-SSL.
        /// </summary>
        /// <value>Enable gateway anti-virus for client DPI-SSL.</value>
        [DataMember(Name = "anti_virus", EmitDefaultValue = true)]
        public bool AntiVirus { get; set; }

        /// <summary>
        /// Enable gateway anti-spyware for client DPI-SSL.
        /// </summary>
        /// <value>Enable gateway anti-spyware for client DPI-SSL.</value>
        [DataMember(Name = "anti_spyware", EmitDefaultValue = true)]
        public bool AntiSpyware { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DpiSslClientDpiSslClientGateway {\n");
            sb.Append("  AntiVirus: ").Append(AntiVirus).Append("\n");
            sb.Append("  AntiSpyware: ").Append(AntiSpyware).Append("\n");
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
            return this.Equals(input as DpiSslClientDpiSslClientGateway);
        }

        /// <summary>
        /// Returns true if DpiSslClientDpiSslClientGateway instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSslClientDpiSslClientGateway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSslClientDpiSslClientGateway input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AntiVirus == input.AntiVirus ||
                    this.AntiVirus.Equals(input.AntiVirus)
                ) && 
                (
                    this.AntiSpyware == input.AntiSpyware ||
                    this.AntiSpyware.Equals(input.AntiSpyware)
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
                hashCode = (hashCode * 59) + this.AntiVirus.GetHashCode();
                hashCode = (hashCode * 59) + this.AntiSpyware.GetHashCode();
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
