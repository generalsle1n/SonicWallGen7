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
    /// Configure gateway AV protocol exclusion address objects.
    /// </summary>
    [DataContract(Name = "gateway_antivirus_gateway_antivirus_exclusion_object")]
    public partial class GatewayAntivirusGatewayAntivirusExclusionObject : IEquatable<GatewayAntivirusGatewayAntivirusExclusionObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayAntivirusGatewayAntivirusExclusionObject" /> class.
        /// </summary>
        /// <param name="http">http.</param>
        /// <param name="ftp">ftp.</param>
        /// <param name="imap">imap.</param>
        /// <param name="smtp">smtp.</param>
        /// <param name="pop3">pop3.</param>
        /// <param name="cifsNetbios">cifsNetbios.</param>
        public GatewayAntivirusGatewayAntivirusExclusionObject(GatewayAntivirusGatewayAntivirusExclusionObjectHttp http = default(GatewayAntivirusGatewayAntivirusExclusionObjectHttp), GatewayAntivirusGatewayAntivirusExclusionObjectFtp ftp = default(GatewayAntivirusGatewayAntivirusExclusionObjectFtp), GatewayAntivirusGatewayAntivirusExclusionObjectImap imap = default(GatewayAntivirusGatewayAntivirusExclusionObjectImap), GatewayAntivirusGatewayAntivirusExclusionObjectSmtp smtp = default(GatewayAntivirusGatewayAntivirusExclusionObjectSmtp), GatewayAntivirusGatewayAntivirusExclusionObjectPop3 pop3 = default(GatewayAntivirusGatewayAntivirusExclusionObjectPop3), GatewayAntivirusGatewayAntivirusExclusionObjectCifsNetbios cifsNetbios = default(GatewayAntivirusGatewayAntivirusExclusionObjectCifsNetbios))
        {
            this.Http = http;
            this.Ftp = ftp;
            this.Imap = imap;
            this.Smtp = smtp;
            this.Pop3 = pop3;
            this.CifsNetbios = cifsNetbios;
        }

        /// <summary>
        /// Gets or Sets Http
        /// </summary>
        [DataMember(Name = "http", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectHttp Http { get; set; }

        /// <summary>
        /// Gets or Sets Ftp
        /// </summary>
        [DataMember(Name = "ftp", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectFtp Ftp { get; set; }

        /// <summary>
        /// Gets or Sets Imap
        /// </summary>
        [DataMember(Name = "imap", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectImap Imap { get; set; }

        /// <summary>
        /// Gets or Sets Smtp
        /// </summary>
        [DataMember(Name = "smtp", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectSmtp Smtp { get; set; }

        /// <summary>
        /// Gets or Sets Pop3
        /// </summary>
        [DataMember(Name = "pop3", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectPop3 Pop3 { get; set; }

        /// <summary>
        /// Gets or Sets CifsNetbios
        /// </summary>
        [DataMember(Name = "cifs_netbios", EmitDefaultValue = true)]
        public GatewayAntivirusGatewayAntivirusExclusionObjectCifsNetbios CifsNetbios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayAntivirusGatewayAntivirusExclusionObject {\n");
            sb.Append("  Http: ").Append(Http).Append("\n");
            sb.Append("  Ftp: ").Append(Ftp).Append("\n");
            sb.Append("  Imap: ").Append(Imap).Append("\n");
            sb.Append("  Smtp: ").Append(Smtp).Append("\n");
            sb.Append("  Pop3: ").Append(Pop3).Append("\n");
            sb.Append("  CifsNetbios: ").Append(CifsNetbios).Append("\n");
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
            return this.Equals(input as GatewayAntivirusGatewayAntivirusExclusionObject);
        }

        /// <summary>
        /// Returns true if GatewayAntivirusGatewayAntivirusExclusionObject instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayAntivirusGatewayAntivirusExclusionObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayAntivirusGatewayAntivirusExclusionObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Http == input.Http ||
                    (this.Http != null &&
                    this.Http.Equals(input.Http))
                ) && 
                (
                    this.Ftp == input.Ftp ||
                    (this.Ftp != null &&
                    this.Ftp.Equals(input.Ftp))
                ) && 
                (
                    this.Imap == input.Imap ||
                    (this.Imap != null &&
                    this.Imap.Equals(input.Imap))
                ) && 
                (
                    this.Smtp == input.Smtp ||
                    (this.Smtp != null &&
                    this.Smtp.Equals(input.Smtp))
                ) && 
                (
                    this.Pop3 == input.Pop3 ||
                    (this.Pop3 != null &&
                    this.Pop3.Equals(input.Pop3))
                ) && 
                (
                    this.CifsNetbios == input.CifsNetbios ||
                    (this.CifsNetbios != null &&
                    this.CifsNetbios.Equals(input.CifsNetbios))
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
                if (this.Http != null)
                {
                    hashCode = (hashCode * 59) + this.Http.GetHashCode();
                }
                if (this.Ftp != null)
                {
                    hashCode = (hashCode * 59) + this.Ftp.GetHashCode();
                }
                if (this.Imap != null)
                {
                    hashCode = (hashCode * 59) + this.Imap.GetHashCode();
                }
                if (this.Smtp != null)
                {
                    hashCode = (hashCode * 59) + this.Smtp.GetHashCode();
                }
                if (this.Pop3 != null)
                {
                    hashCode = (hashCode * 59) + this.Pop3.GetHashCode();
                }
                if (this.CifsNetbios != null)
                {
                    hashCode = (hashCode * 59) + this.CifsNetbios.GetHashCode();
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
