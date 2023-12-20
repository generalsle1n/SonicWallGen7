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
    /// Set IPv6 router advertisement interval range.
    /// </summary>
    [DataContract(Name = "interface_ipv6_base_ipv6_ip_assignment_mode_static_static_router_advertisement_interval")]
    public partial class InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval : IEquatable<InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval" /> class.
        /// </summary>
        /// <param name="min">Router advertisement interval range minimum..</param>
        /// <param name="max">Router advertisement interval range maximum..</param>
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval(decimal min = default(decimal), decimal max = default(decimal))
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Router advertisement interval range minimum.
        /// </summary>
        /// <value>Router advertisement interval range minimum.</value>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public decimal Min { get; set; }

        /// <summary>
        /// Router advertisement interval range maximum.
        /// </summary>
        /// <value>Router advertisement interval range maximum.</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public decimal Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return this.Equals(input as InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
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
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
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