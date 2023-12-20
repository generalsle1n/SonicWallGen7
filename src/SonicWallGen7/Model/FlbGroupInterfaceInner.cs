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
    /// FlbGroupInterfaceInner
    /// </summary>
    [DataContract(Name = "flb_group_interface_inner")]
    public partial class FlbGroupInterfaceInner : IEquatable<FlbGroupInterfaceInner>, IValidatableObject
    {
        /// <summary>
        /// Configure probing type.
        /// </summary>
        /// <value>Configure probing type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProbeTypeEnum
        {
            /// <summary>
            /// Enum Physical for value: physical
            /// </summary>
            [EnumMember(Value = "physical")]
            Physical = 1,

            /// <summary>
            /// Enum Logical for value: logical
            /// </summary>
            [EnumMember(Value = "logical")]
            Logical = 2
        }


        /// <summary>
        /// Configure probing type.
        /// </summary>
        /// <value>Configure probing type.</value>
        [DataMember(Name = "probe_type", EmitDefaultValue = false)]
        public ProbeTypeEnum? ProbeType { get; set; }
        /// <summary>
        /// Configure under what condition probes succeed.
        /// </summary>
        /// <value>Configure under what condition probes succeed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProbeConditionEnum
        {
            /// <summary>
            /// Enum Main for value: main
            /// </summary>
            [EnumMember(Value = "main")]
            Main = 1,

            /// <summary>
            /// Enum Either for value: either
            /// </summary>
            [EnumMember(Value = "either")]
            Either = 2,

            /// <summary>
            /// Enum Both for value: both
            /// </summary>
            [EnumMember(Value = "both")]
            Both = 3,

            /// <summary>
            /// Enum Always for value: always
            /// </summary>
            [EnumMember(Value = "always")]
            Always = 4
        }


        /// <summary>
        /// Configure under what condition probes succeed.
        /// </summary>
        /// <value>Configure under what condition probes succeed.</value>
        [DataMember(Name = "probe_condition", EmitDefaultValue = false)]
        public ProbeConditionEnum? ProbeCondition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlbGroupInterfaceInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlbGroupInterfaceInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlbGroupInterfaceInner" /> class.
        /// </summary>
        /// <param name="name">Edit interface load balancing group member name. (required).</param>
        /// <param name="rank">Interface rank..</param>
        /// <param name="probeType">Configure probing type..</param>
        /// <param name="probeCondition">Configure under what condition probes succeed..</param>
        /// <param name="mainTarget">mainTarget.</param>
        /// <param name="alternateTarget">alternateTarget.</param>
        /// <param name="defaultTarget">defaultTarget.</param>
        public FlbGroupInterfaceInner(string name = default(string), decimal rank = default(decimal), ProbeTypeEnum? probeType = default(ProbeTypeEnum?), ProbeConditionEnum? probeCondition = default(ProbeConditionEnum?), FlbGroupInterfaceInnerMainTarget mainTarget = default(FlbGroupInterfaceInnerMainTarget), FlbGroupInterfaceInnerAlternateTarget alternateTarget = default(FlbGroupInterfaceInnerAlternateTarget), FlbGroupInterfaceInnerDefaultTarget defaultTarget = default(FlbGroupInterfaceInnerDefaultTarget))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FlbGroupInterfaceInner and cannot be null");
            }
            this.Name = name;
            this.Rank = rank;
            this.ProbeType = probeType;
            this.ProbeCondition = probeCondition;
            this.MainTarget = mainTarget;
            this.AlternateTarget = alternateTarget;
            this.DefaultTarget = defaultTarget;
        }

        /// <summary>
        /// Edit interface load balancing group member name.
        /// </summary>
        /// <value>Edit interface load balancing group member name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Interface rank.
        /// </summary>
        /// <value>Interface rank.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public decimal Rank { get; set; }

        /// <summary>
        /// Gets or Sets MainTarget
        /// </summary>
        [DataMember(Name = "main_target", EmitDefaultValue = false)]
        public FlbGroupInterfaceInnerMainTarget MainTarget { get; set; }

        /// <summary>
        /// Gets or Sets AlternateTarget
        /// </summary>
        [DataMember(Name = "alternate_target", EmitDefaultValue = false)]
        public FlbGroupInterfaceInnerAlternateTarget AlternateTarget { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTarget
        /// </summary>
        [DataMember(Name = "default_target", EmitDefaultValue = true)]
        public FlbGroupInterfaceInnerDefaultTarget DefaultTarget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlbGroupInterfaceInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  ProbeType: ").Append(ProbeType).Append("\n");
            sb.Append("  ProbeCondition: ").Append(ProbeCondition).Append("\n");
            sb.Append("  MainTarget: ").Append(MainTarget).Append("\n");
            sb.Append("  AlternateTarget: ").Append(AlternateTarget).Append("\n");
            sb.Append("  DefaultTarget: ").Append(DefaultTarget).Append("\n");
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
            return this.Equals(input as FlbGroupInterfaceInner);
        }

        /// <summary>
        /// Returns true if FlbGroupInterfaceInner instances are equal
        /// </summary>
        /// <param name="input">Instance of FlbGroupInterfaceInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlbGroupInterfaceInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) && 
                (
                    this.ProbeType == input.ProbeType ||
                    this.ProbeType.Equals(input.ProbeType)
                ) && 
                (
                    this.ProbeCondition == input.ProbeCondition ||
                    this.ProbeCondition.Equals(input.ProbeCondition)
                ) && 
                (
                    this.MainTarget == input.MainTarget ||
                    (this.MainTarget != null &&
                    this.MainTarget.Equals(input.MainTarget))
                ) && 
                (
                    this.AlternateTarget == input.AlternateTarget ||
                    (this.AlternateTarget != null &&
                    this.AlternateTarget.Equals(input.AlternateTarget))
                ) && 
                (
                    this.DefaultTarget == input.DefaultTarget ||
                    (this.DefaultTarget != null &&
                    this.DefaultTarget.Equals(input.DefaultTarget))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                hashCode = (hashCode * 59) + this.ProbeType.GetHashCode();
                hashCode = (hashCode * 59) + this.ProbeCondition.GetHashCode();
                if (this.MainTarget != null)
                {
                    hashCode = (hashCode * 59) + this.MainTarget.GetHashCode();
                }
                if (this.AlternateTarget != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateTarget.GetHashCode();
                }
                if (this.DefaultTarget != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTarget.GetHashCode();
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