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
    /// Configure and enter to SonicDns proxy mode.
    /// </summary>
    [DataContract(Name = "SonicDns_proxy_cache_entry_collection_SonicDns_proxy")]
    public partial class SonicDnsProxyCacheEntryCollectionSonicDnsProxy : IEquatable<SonicDnsProxyCacheEntryCollectionSonicDnsProxy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SonicDnsProxyCacheEntryCollectionSonicDnsProxy" /> class.
        /// </summary>
        /// <param name="cacheEntry">Add/edit the static SonicDns cache and enter its configuration mode..</param>
        public SonicDnsProxyCacheEntryCollectionSonicDnsProxy(List<SonicDnsProxyCacheEntry> cacheEntry = default(List<SonicDnsProxyCacheEntry>))
        {
            this.CacheEntry = cacheEntry;
        }

        /// <summary>
        /// Add/edit the static SonicDns cache and enter its configuration mode.
        /// </summary>
        /// <value>Add/edit the static SonicDns cache and enter its configuration mode.</value>
        [DataMember(Name = "cache_entry", EmitDefaultValue = false)]
        public List<SonicDnsProxyCacheEntry> CacheEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SonicDnsProxyCacheEntryCollectionSonicDnsProxy {\n");
            sb.Append("  CacheEntry: ").Append(CacheEntry).Append("\n");
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
            return this.Equals(input as SonicDnsProxyCacheEntryCollectionSonicDnsProxy);
        }

        /// <summary>
        /// Returns true if SonicDnsProxyCacheEntryCollectionSonicDnsProxy instances are equal
        /// </summary>
        /// <param name="input">Instance of SonicDnsProxyCacheEntryCollectionSonicDnsProxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SonicDnsProxyCacheEntryCollectionSonicDnsProxy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CacheEntry == input.CacheEntry ||
                    this.CacheEntry != null &&
                    input.CacheEntry != null &&
                    this.CacheEntry.SequenceEqual(input.CacheEntry)
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
                if (this.CacheEntry != null)
                {
                    hashCode = (hashCode * 59) + this.CacheEntry.GetHashCode();
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
