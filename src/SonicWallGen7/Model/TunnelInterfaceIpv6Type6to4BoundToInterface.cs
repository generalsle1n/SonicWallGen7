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
    /// TunnelInterfaceIpv6Type6to4BoundToInterface
    /// </summary>
    [DataContract(Name = "tunnel_interface_ipv6_type_6to4_bound_to_interface")]
    public partial class TunnelInterfaceIpv6Type6to4BoundToInterface : IEquatable<TunnelInterfaceIpv6Type6to4BoundToInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6Type6to4BoundToInterface" /> class.
        /// </summary>
        /// <param name="varInterface">Bound to interface..</param>
        public TunnelInterfaceIpv6Type6to4BoundToInterface(string varInterface = default(string))
        {
            this.VarInterface = varInterface;
        }

        /// <summary>
        /// Bound to interface.
        /// </summary>
        /// <value>Bound to interface.</value>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public string VarInterface { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TunnelInterfaceIpv6Type6to4BoundToInterface {\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
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
            return this.Equals(input as TunnelInterfaceIpv6Type6to4BoundToInterface);
        }

        /// <summary>
        /// Returns true if TunnelInterfaceIpv6Type6to4BoundToInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of TunnelInterfaceIpv6Type6to4BoundToInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TunnelInterfaceIpv6Type6to4BoundToInterface input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
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
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
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
