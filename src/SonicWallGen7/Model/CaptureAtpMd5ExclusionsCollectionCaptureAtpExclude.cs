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
    /// Set capture ATP exclusion.
    /// </summary>
    [DataContract(Name = "capture_atp_md5_exclusions_collection_capture_atp_exclude")]
    public partial class CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude : IEquatable<CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude" /> class.
        /// </summary>
        /// <param name="md5Entry">Add an entry to the capture ATP MD5 exclusion list..</param>
        public CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude(List<CaptureAtpMd5Exclusions> md5Entry = default(List<CaptureAtpMd5Exclusions>))
        {
            this.Md5Entry = md5Entry;
        }

        /// <summary>
        /// Add an entry to the capture ATP MD5 exclusion list.
        /// </summary>
        /// <value>Add an entry to the capture ATP MD5 exclusion list.</value>
        [DataMember(Name = "md5_entry", EmitDefaultValue = false)]
        public List<CaptureAtpMd5Exclusions> Md5Entry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude {\n");
            sb.Append("  Md5Entry: ").Append(Md5Entry).Append("\n");
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
            return this.Equals(input as CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude);
        }

        /// <summary>
        /// Returns true if CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude instances are equal
        /// </summary>
        /// <param name="input">Instance of CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureAtpMd5ExclusionsCollectionCaptureAtpExclude input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Md5Entry == input.Md5Entry ||
                    this.Md5Entry != null &&
                    input.Md5Entry != null &&
                    this.Md5Entry.SequenceEqual(input.Md5Entry)
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
                if (this.Md5Entry != null)
                {
                    hashCode = (hashCode * 59) + this.Md5Entry.GetHashCode();
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
