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
    /// Bypass decryption.
    /// </summary>
    [DataContract(Name = "policies_setting_base_policies_setting_bypass_decryption")]
    public partial class PoliciesSettingBasePoliciesSettingBypassDecryption : IEquatable<PoliciesSettingBasePoliciesSettingBypassDecryption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesSettingBasePoliciesSettingBypassDecryption" /> class.
        /// </summary>
        /// <param name="cfsNotLicensed">Enable bypass decryption when CFS is not licensed and rules need web content..</param>
        /// <param name="cfsFailConnect">Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating..</param>
        /// <param name="geoipDatabaseNotDownloaded">Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating..</param>
        public PoliciesSettingBasePoliciesSettingBypassDecryption(bool cfsNotLicensed = default(bool), bool cfsFailConnect = default(bool), bool geoipDatabaseNotDownloaded = default(bool))
        {
            this.CfsNotLicensed = cfsNotLicensed;
            this.CfsFailConnect = cfsFailConnect;
            this.GeoipDatabaseNotDownloaded = geoipDatabaseNotDownloaded;
        }

        /// <summary>
        /// Enable bypass decryption when CFS is not licensed and rules need web content.
        /// </summary>
        /// <value>Enable bypass decryption when CFS is not licensed and rules need web content.</value>
        [DataMember(Name = "cfs_not_licensed", EmitDefaultValue = true)]
        public bool CfsNotLicensed { get; set; }

        /// <summary>
        /// Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating.
        /// </summary>
        /// <value>Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating.</value>
        [DataMember(Name = "cfs_fail_connect", EmitDefaultValue = true)]
        public bool CfsFailConnect { get; set; }

        /// <summary>
        /// Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating.
        /// </summary>
        /// <value>Enable bypass decryption when CFS fails to connect to backend rating server and rules need web rating.</value>
        [DataMember(Name = "geoip_database_not_downloaded", EmitDefaultValue = true)]
        public bool GeoipDatabaseNotDownloaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PoliciesSettingBasePoliciesSettingBypassDecryption {\n");
            sb.Append("  CfsNotLicensed: ").Append(CfsNotLicensed).Append("\n");
            sb.Append("  CfsFailConnect: ").Append(CfsFailConnect).Append("\n");
            sb.Append("  GeoipDatabaseNotDownloaded: ").Append(GeoipDatabaseNotDownloaded).Append("\n");
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
            return this.Equals(input as PoliciesSettingBasePoliciesSettingBypassDecryption);
        }

        /// <summary>
        /// Returns true if PoliciesSettingBasePoliciesSettingBypassDecryption instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliciesSettingBasePoliciesSettingBypassDecryption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliciesSettingBasePoliciesSettingBypassDecryption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CfsNotLicensed == input.CfsNotLicensed ||
                    this.CfsNotLicensed.Equals(input.CfsNotLicensed)
                ) && 
                (
                    this.CfsFailConnect == input.CfsFailConnect ||
                    this.CfsFailConnect.Equals(input.CfsFailConnect)
                ) && 
                (
                    this.GeoipDatabaseNotDownloaded == input.GeoipDatabaseNotDownloaded ||
                    this.GeoipDatabaseNotDownloaded.Equals(input.GeoipDatabaseNotDownloaded)
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
                hashCode = (hashCode * 59) + this.CfsNotLicensed.GetHashCode();
                hashCode = (hashCode * 59) + this.CfsFailConnect.GetHashCode();
                hashCode = (hashCode * 59) + this.GeoipDatabaseNotDownloaded.GetHashCode();
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
