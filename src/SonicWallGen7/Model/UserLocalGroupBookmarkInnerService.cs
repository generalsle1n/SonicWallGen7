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
    /// Set bookmark service type.
    /// </summary>
    [DataContract(Name = "user_local_group_bookmark_inner_service")]
    public partial class UserLocalGroupBookmarkInnerService : IEquatable<UserLocalGroupBookmarkInnerService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalGroupBookmarkInnerService" /> class.
        /// </summary>
        /// <param name="rdp">rdp.</param>
        /// <param name="vnc">vnc.</param>
        /// <param name="telnet">telnet.</param>
        /// <param name="sshv2">sshv2.</param>
        public UserLocalGroupBookmarkInnerService(UserLocalGroupBookmarkInnerServiceRdp rdp = default(UserLocalGroupBookmarkInnerServiceRdp), UserLocalGroupBookmarkInnerServiceVnc vnc = default(UserLocalGroupBookmarkInnerServiceVnc), UserLocalGroupBookmarkInnerServiceTelnet telnet = default(UserLocalGroupBookmarkInnerServiceTelnet), UserLocalGroupBookmarkInnerServiceSshv2 sshv2 = default(UserLocalGroupBookmarkInnerServiceSshv2))
        {
            this.Rdp = rdp;
            this.Vnc = vnc;
            this.Telnet = telnet;
            this.Sshv2 = sshv2;
        }

        /// <summary>
        /// Gets or Sets Rdp
        /// </summary>
        [DataMember(Name = "rdp", EmitDefaultValue = false)]
        public UserLocalGroupBookmarkInnerServiceRdp Rdp { get; set; }

        /// <summary>
        /// Gets or Sets Vnc
        /// </summary>
        [DataMember(Name = "vnc", EmitDefaultValue = false)]
        public UserLocalGroupBookmarkInnerServiceVnc Vnc { get; set; }

        /// <summary>
        /// Gets or Sets Telnet
        /// </summary>
        [DataMember(Name = "telnet", EmitDefaultValue = false)]
        public UserLocalGroupBookmarkInnerServiceTelnet Telnet { get; set; }

        /// <summary>
        /// Gets or Sets Sshv2
        /// </summary>
        [DataMember(Name = "sshv2", EmitDefaultValue = false)]
        public UserLocalGroupBookmarkInnerServiceSshv2 Sshv2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLocalGroupBookmarkInnerService {\n");
            sb.Append("  Rdp: ").Append(Rdp).Append("\n");
            sb.Append("  Vnc: ").Append(Vnc).Append("\n");
            sb.Append("  Telnet: ").Append(Telnet).Append("\n");
            sb.Append("  Sshv2: ").Append(Sshv2).Append("\n");
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
            return this.Equals(input as UserLocalGroupBookmarkInnerService);
        }

        /// <summary>
        /// Returns true if UserLocalGroupBookmarkInnerService instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLocalGroupBookmarkInnerService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocalGroupBookmarkInnerService input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rdp == input.Rdp ||
                    (this.Rdp != null &&
                    this.Rdp.Equals(input.Rdp))
                ) && 
                (
                    this.Vnc == input.Vnc ||
                    (this.Vnc != null &&
                    this.Vnc.Equals(input.Vnc))
                ) && 
                (
                    this.Telnet == input.Telnet ||
                    (this.Telnet != null &&
                    this.Telnet.Equals(input.Telnet))
                ) && 
                (
                    this.Sshv2 == input.Sshv2 ||
                    (this.Sshv2 != null &&
                    this.Sshv2.Equals(input.Sshv2))
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
                if (this.Rdp != null)
                {
                    hashCode = (hashCode * 59) + this.Rdp.GetHashCode();
                }
                if (this.Vnc != null)
                {
                    hashCode = (hashCode * 59) + this.Vnc.GetHashCode();
                }
                if (this.Telnet != null)
                {
                    hashCode = (hashCode * 59) + this.Telnet.GetHashCode();
                }
                if (this.Sshv2 != null)
                {
                    hashCode = (hashCode * 59) + this.Sshv2.GetHashCode();
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
