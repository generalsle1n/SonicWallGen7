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
    /// ShowStatusFlbMemberStatusListInner
    /// </summary>
    [DataContract(Name = "show_status_flb_member_status_list_inner")]
    public partial class ShowStatusFlbMemberStatusListInner : IEquatable<ShowStatusFlbMemberStatusListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusFlbMemberStatusListInner" /> class.
        /// </summary>
        /// <param name="groupName">groupName.</param>
        /// <param name="memberName">memberName.</param>
        /// <param name="linkStatus">linkStatus.</param>
        /// <param name="lbStatus">lbStatus.</param>
        /// <param name="probeStatus">probeStatus.</param>
        /// <param name="mainTargetStatus">mainTargetStatus.</param>
        /// <param name="alternateTargetStatus">alternateTargetStatus.</param>
        public ShowStatusFlbMemberStatusListInner(string groupName = default(string), string memberName = default(string), string linkStatus = default(string), string lbStatus = default(string), string probeStatus = default(string), string mainTargetStatus = default(string), string alternateTargetStatus = default(string))
        {
            this.GroupName = groupName;
            this.MemberName = memberName;
            this.LinkStatus = linkStatus;
            this.LbStatus = lbStatus;
            this.ProbeStatus = probeStatus;
            this.MainTargetStatus = mainTargetStatus;
            this.AlternateTargetStatus = alternateTargetStatus;
        }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "group_name", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets MemberName
        /// </summary>
        [DataMember(Name = "member_name", EmitDefaultValue = false)]
        public string MemberName { get; set; }

        /// <summary>
        /// Gets or Sets LinkStatus
        /// </summary>
        [DataMember(Name = "link_status", EmitDefaultValue = false)]
        public string LinkStatus { get; set; }

        /// <summary>
        /// Gets or Sets LbStatus
        /// </summary>
        [DataMember(Name = "lb_status", EmitDefaultValue = false)]
        public string LbStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProbeStatus
        /// </summary>
        [DataMember(Name = "probe_status", EmitDefaultValue = false)]
        public string ProbeStatus { get; set; }

        /// <summary>
        /// Gets or Sets MainTargetStatus
        /// </summary>
        [DataMember(Name = "main_target_status", EmitDefaultValue = false)]
        public string MainTargetStatus { get; set; }

        /// <summary>
        /// Gets or Sets AlternateTargetStatus
        /// </summary>
        [DataMember(Name = "alternate_target_status", EmitDefaultValue = false)]
        public string AlternateTargetStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusFlbMemberStatusListInner {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  MemberName: ").Append(MemberName).Append("\n");
            sb.Append("  LinkStatus: ").Append(LinkStatus).Append("\n");
            sb.Append("  LbStatus: ").Append(LbStatus).Append("\n");
            sb.Append("  ProbeStatus: ").Append(ProbeStatus).Append("\n");
            sb.Append("  MainTargetStatus: ").Append(MainTargetStatus).Append("\n");
            sb.Append("  AlternateTargetStatus: ").Append(AlternateTargetStatus).Append("\n");
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
            return this.Equals(input as ShowStatusFlbMemberStatusListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusFlbMemberStatusListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusFlbMemberStatusListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusFlbMemberStatusListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.MemberName == input.MemberName ||
                    (this.MemberName != null &&
                    this.MemberName.Equals(input.MemberName))
                ) && 
                (
                    this.LinkStatus == input.LinkStatus ||
                    (this.LinkStatus != null &&
                    this.LinkStatus.Equals(input.LinkStatus))
                ) && 
                (
                    this.LbStatus == input.LbStatus ||
                    (this.LbStatus != null &&
                    this.LbStatus.Equals(input.LbStatus))
                ) && 
                (
                    this.ProbeStatus == input.ProbeStatus ||
                    (this.ProbeStatus != null &&
                    this.ProbeStatus.Equals(input.ProbeStatus))
                ) && 
                (
                    this.MainTargetStatus == input.MainTargetStatus ||
                    (this.MainTargetStatus != null &&
                    this.MainTargetStatus.Equals(input.MainTargetStatus))
                ) && 
                (
                    this.AlternateTargetStatus == input.AlternateTargetStatus ||
                    (this.AlternateTargetStatus != null &&
                    this.AlternateTargetStatus.Equals(input.AlternateTargetStatus))
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
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.MemberName != null)
                {
                    hashCode = (hashCode * 59) + this.MemberName.GetHashCode();
                }
                if (this.LinkStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LinkStatus.GetHashCode();
                }
                if (this.LbStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LbStatus.GetHashCode();
                }
                if (this.ProbeStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ProbeStatus.GetHashCode();
                }
                if (this.MainTargetStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MainTargetStatus.GetHashCode();
                }
                if (this.AlternateTargetStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateTargetStatus.GetHashCode();
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
