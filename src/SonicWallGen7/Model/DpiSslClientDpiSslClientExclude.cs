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
    /// Set DPI-SSL exclusion.
    /// </summary>
    [DataContract(Name = "dpi_ssl_client_dpi_ssl_client_exclude")]
    public partial class DpiSslClientDpiSslClientExclude : IEquatable<DpiSslClientDpiSslClientExclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientExclude" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="service">service.</param>
        /// <param name="user">user.</param>
        /// <param name="cfsCategoryUnavailable">Enable exclude connection if content filter category is not available..</param>
        public DpiSslClientDpiSslClientExclude(DpiSslClientDpiSslClientExcludeAddress address = default(DpiSslClientDpiSslClientExcludeAddress), DpiSslClientDpiSslClientExcludeService service = default(DpiSslClientDpiSslClientExcludeService), DpiSslClientDpiSslClientExcludeUser user = default(DpiSslClientDpiSslClientExcludeUser), bool cfsCategoryUnavailable = default(bool))
        {
            this.Address = address;
            this.Service = service;
            this.User = user;
            this.CfsCategoryUnavailable = cfsCategoryUnavailable;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public DpiSslClientDpiSslClientExcludeAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public DpiSslClientDpiSslClientExcludeService Service { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public DpiSslClientDpiSslClientExcludeUser User { get; set; }

        /// <summary>
        /// Enable exclude connection if content filter category is not available.
        /// </summary>
        /// <value>Enable exclude connection if content filter category is not available.</value>
        [DataMember(Name = "cfs_category_unavailable", EmitDefaultValue = true)]
        public bool CfsCategoryUnavailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DpiSslClientDpiSslClientExclude {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CfsCategoryUnavailable: ").Append(CfsCategoryUnavailable).Append("\n");
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
            return this.Equals(input as DpiSslClientDpiSslClientExclude);
        }

        /// <summary>
        /// Returns true if DpiSslClientDpiSslClientExclude instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSslClientDpiSslClientExclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSslClientDpiSslClientExclude input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.CfsCategoryUnavailable == input.CfsCategoryUnavailable ||
                    this.CfsCategoryUnavailable.Equals(input.CfsCategoryUnavailable)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CfsCategoryUnavailable.GetHashCode();
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