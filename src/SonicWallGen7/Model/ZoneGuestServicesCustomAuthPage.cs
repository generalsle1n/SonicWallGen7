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
    [DataContract(Name = "zone_guest_services_custom_auth_page")]
    public partial class ZoneGuestServicesCustomAuthPage : IEquatable<ZoneGuestServicesCustomAuthPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesCustomAuthPage" /> class.
        /// </summary>
        /// <param name="enable">Enable  custom authentication page..</param>
        /// <param name="header">header.</param>
        /// <param name="footer">footer.</param>
        public ZoneGuestServicesCustomAuthPage(bool enable = default(bool), ZoneGuestServicesCustomAuthPageHeader header = default(ZoneGuestServicesCustomAuthPageHeader), ZoneGuestServicesCustomAuthPageFooter footer = default(ZoneGuestServicesCustomAuthPageFooter))
        {
            this.Enable = enable;
            this.Header = header;
            this.Footer = footer;
        }

        /// <summary>
        /// Enable  custom authentication page.
        /// </summary>
        /// <value>Enable  custom authentication page.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", EmitDefaultValue = false)]
        public ZoneGuestServicesCustomAuthPageHeader Header { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name = "footer", EmitDefaultValue = false)]
        public ZoneGuestServicesCustomAuthPageFooter Footer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesCustomAuthPage {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesCustomAuthPage);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesCustomAuthPage instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesCustomAuthPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesCustomAuthPage input)
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
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Footer == input.Footer ||
                    (this.Footer != null &&
                    this.Footer.Equals(input.Footer))
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
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.Footer != null)
                {
                    hashCode = (hashCode * 59) + this.Footer.GetHashCode();
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
