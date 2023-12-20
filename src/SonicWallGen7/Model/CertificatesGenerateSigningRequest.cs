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
    /// Certificate signing request configuration schema.
    /// </summary>
    [DataContract(Name = "certificates_generate_signing_request")]
    public partial class CertificatesGenerateSigningRequest : IEquatable<CertificatesGenerateSigningRequest>, IValidatableObject
    {
        /// <summary>
        /// Configure certificate signing request signature algorithm.
        /// </summary>
        /// <value>Configure certificate signing request signature algorithm.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureAlgorithmEnum
        {
            /// <summary>
            /// Enum Md5 for value: md5
            /// </summary>
            [EnumMember(Value = "md5")]
            Md5 = 1,

            /// <summary>
            /// Enum Sha1 for value: sha-1
            /// </summary>
            [EnumMember(Value = "sha-1")]
            Sha1 = 2,

            /// <summary>
            /// Enum Sha256 for value: sha-256
            /// </summary>
            [EnumMember(Value = "sha-256")]
            Sha256 = 3,

            /// <summary>
            /// Enum Sha384 for value: sha-384
            /// </summary>
            [EnumMember(Value = "sha-384")]
            Sha384 = 4,

            /// <summary>
            /// Enum Sha512 for value: sha-512
            /// </summary>
            [EnumMember(Value = "sha-512")]
            Sha512 = 5
        }


        /// <summary>
        /// Configure certificate signing request signature algorithm.
        /// </summary>
        /// <value>Configure certificate signing request signature algorithm.</value>
        [DataMember(Name = "signature_algorithm", EmitDefaultValue = false)]
        public SignatureAlgorithmEnum? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatesGenerateSigningRequest" /> class.
        /// </summary>
        /// <param name="alias">Configure certificate signing request alias..</param>
        /// <param name="distinguishedName">distinguishedName.</param>
        /// <param name="alternateName">alternateName.</param>
        /// <param name="signatureAlgorithm">Configure certificate signing request signature algorithm..</param>
        /// <param name="key">key.</param>
        /// <param name="generate">Generate certificate signing request..</param>
        public CertificatesGenerateSigningRequest(string alias = default(string), CertificatesGenerateSigningRequestDistinguishedName distinguishedName = default(CertificatesGenerateSigningRequestDistinguishedName), CertificatesGenerateSigningRequestAlternateName alternateName = default(CertificatesGenerateSigningRequestAlternateName), SignatureAlgorithmEnum? signatureAlgorithm = default(SignatureAlgorithmEnum?), CertificatesGenerateSigningRequestKey key = default(CertificatesGenerateSigningRequestKey), bool generate = default(bool))
        {
            this.Alias = alias;
            this.DistinguishedName = distinguishedName;
            this.AlternateName = alternateName;
            this.SignatureAlgorithm = signatureAlgorithm;
            this.Key = key;
            this.Generate = generate;
        }

        /// <summary>
        /// Configure certificate signing request alias.
        /// </summary>
        /// <value>Configure certificate signing request alias.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets DistinguishedName
        /// </summary>
        [DataMember(Name = "distinguished_name", EmitDefaultValue = false)]
        public CertificatesGenerateSigningRequestDistinguishedName DistinguishedName { get; set; }

        /// <summary>
        /// Gets or Sets AlternateName
        /// </summary>
        [DataMember(Name = "alternate_name", EmitDefaultValue = false)]
        public CertificatesGenerateSigningRequestAlternateName AlternateName { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public CertificatesGenerateSigningRequestKey Key { get; set; }

        /// <summary>
        /// Generate certificate signing request.
        /// </summary>
        /// <value>Generate certificate signing request.</value>
        [DataMember(Name = "generate", EmitDefaultValue = true)]
        public bool Generate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificatesGenerateSigningRequest {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
            sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Generate: ").Append(Generate).Append("\n");
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
            return this.Equals(input as CertificatesGenerateSigningRequest);
        }

        /// <summary>
        /// Returns true if CertificatesGenerateSigningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificatesGenerateSigningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatesGenerateSigningRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.DistinguishedName == input.DistinguishedName ||
                    (this.DistinguishedName != null &&
                    this.DistinguishedName.Equals(input.DistinguishedName))
                ) && 
                (
                    this.AlternateName == input.AlternateName ||
                    (this.AlternateName != null &&
                    this.AlternateName.Equals(input.AlternateName))
                ) && 
                (
                    this.SignatureAlgorithm == input.SignatureAlgorithm ||
                    this.SignatureAlgorithm.Equals(input.SignatureAlgorithm)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Generate == input.Generate ||
                    this.Generate.Equals(input.Generate)
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
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.DistinguishedName != null)
                {
                    hashCode = (hashCode * 59) + this.DistinguishedName.GetHashCode();
                }
                if (this.AlternateName != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignatureAlgorithm.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Generate.GetHashCode();
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
