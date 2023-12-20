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
    /// Enter virtual assist configuration mode.
    /// </summary>
    [DataContract(Name = "virtual_assist_virtual_assist")]
    public partial class VirtualAssistVirtualAssist : IEquatable<VirtualAssistVirtualAssist>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualAssistVirtualAssist" /> class.
        /// </summary>
        /// <param name="assistanceCode">Set virtual assist assistance code..</param>
        /// <param name="supportWithoutInvitation">Enable support without invitation..</param>
        /// <param name="disclaimer">Set virtual assist disclaimer..</param>
        /// <param name="customerAccessLink">Set virtual assist customer access link..</param>
        /// <param name="linkOnPortalLogin">Enable display virtual assist link from portal login..</param>
        /// <param name="technicianEmailList">Set virtual assist technician e-mail list..</param>
        /// <param name="invitationSubject">Set technician subject of invitation..</param>
        /// <param name="invitationMessage">Set technician invitation message..</param>
        /// <param name="maxRequests">Set maximum requests..</param>
        /// <param name="limitMessage">Set technician limit message..</param>
        /// <param name="maxRequestsOneIp">maxRequestsOneIp.</param>
        /// <param name="pendingRequestExpiration">pendingRequestExpiration.</param>
        public VirtualAssistVirtualAssist(string assistanceCode = default(string), bool supportWithoutInvitation = default(bool), string disclaimer = default(string), string customerAccessLink = default(string), bool linkOnPortalLogin = default(bool), string technicianEmailList = default(string), string invitationSubject = default(string), string invitationMessage = default(string), decimal maxRequests = default(decimal), string limitMessage = default(string), VirtualAssistVirtualAssistMaxRequestsOneIp maxRequestsOneIp = default(VirtualAssistVirtualAssistMaxRequestsOneIp), VirtualAssistVirtualAssistPendingRequestExpiration pendingRequestExpiration = default(VirtualAssistVirtualAssistPendingRequestExpiration))
        {
            this.AssistanceCode = assistanceCode;
            this.SupportWithoutInvitation = supportWithoutInvitation;
            this.Disclaimer = disclaimer;
            this.CustomerAccessLink = customerAccessLink;
            this.LinkOnPortalLogin = linkOnPortalLogin;
            this.TechnicianEmailList = technicianEmailList;
            this.InvitationSubject = invitationSubject;
            this.InvitationMessage = invitationMessage;
            this.MaxRequests = maxRequests;
            this.LimitMessage = limitMessage;
            this.MaxRequestsOneIp = maxRequestsOneIp;
            this.PendingRequestExpiration = pendingRequestExpiration;
        }

        /// <summary>
        /// Set virtual assist assistance code.
        /// </summary>
        /// <value>Set virtual assist assistance code.</value>
        [DataMember(Name = "assistance_code", EmitDefaultValue = false)]
        public string AssistanceCode { get; set; }

        /// <summary>
        /// Enable support without invitation.
        /// </summary>
        /// <value>Enable support without invitation.</value>
        [DataMember(Name = "support_without_invitation", EmitDefaultValue = true)]
        public bool SupportWithoutInvitation { get; set; }

        /// <summary>
        /// Set virtual assist disclaimer.
        /// </summary>
        /// <value>Set virtual assist disclaimer.</value>
        [DataMember(Name = "disclaimer", EmitDefaultValue = false)]
        public string Disclaimer { get; set; }

        /// <summary>
        /// Set virtual assist customer access link.
        /// </summary>
        /// <value>Set virtual assist customer access link.</value>
        [DataMember(Name = "customer_access_link", EmitDefaultValue = false)]
        public string CustomerAccessLink { get; set; }

        /// <summary>
        /// Enable display virtual assist link from portal login.
        /// </summary>
        /// <value>Enable display virtual assist link from portal login.</value>
        [DataMember(Name = "link_on_portal_login", EmitDefaultValue = true)]
        public bool LinkOnPortalLogin { get; set; }

        /// <summary>
        /// Set virtual assist technician e-mail list.
        /// </summary>
        /// <value>Set virtual assist technician e-mail list.</value>
        [DataMember(Name = "technician_email_list", EmitDefaultValue = false)]
        public string TechnicianEmailList { get; set; }

        /// <summary>
        /// Set technician subject of invitation.
        /// </summary>
        /// <value>Set technician subject of invitation.</value>
        [DataMember(Name = "invitation_subject", EmitDefaultValue = false)]
        public string InvitationSubject { get; set; }

        /// <summary>
        /// Set technician invitation message.
        /// </summary>
        /// <value>Set technician invitation message.</value>
        [DataMember(Name = "invitation_message", EmitDefaultValue = false)]
        public string InvitationMessage { get; set; }

        /// <summary>
        /// Set maximum requests.
        /// </summary>
        /// <value>Set maximum requests.</value>
        [DataMember(Name = "max_requests", EmitDefaultValue = false)]
        public decimal MaxRequests { get; set; }

        /// <summary>
        /// Set technician limit message.
        /// </summary>
        /// <value>Set technician limit message.</value>
        [DataMember(Name = "limit_message", EmitDefaultValue = false)]
        public string LimitMessage { get; set; }

        /// <summary>
        /// Gets or Sets MaxRequestsOneIp
        /// </summary>
        [DataMember(Name = "max_requests_one_ip", EmitDefaultValue = true)]
        public VirtualAssistVirtualAssistMaxRequestsOneIp MaxRequestsOneIp { get; set; }

        /// <summary>
        /// Gets or Sets PendingRequestExpiration
        /// </summary>
        [DataMember(Name = "pending_request_expiration", EmitDefaultValue = true)]
        public VirtualAssistVirtualAssistPendingRequestExpiration PendingRequestExpiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirtualAssistVirtualAssist {\n");
            sb.Append("  AssistanceCode: ").Append(AssistanceCode).Append("\n");
            sb.Append("  SupportWithoutInvitation: ").Append(SupportWithoutInvitation).Append("\n");
            sb.Append("  Disclaimer: ").Append(Disclaimer).Append("\n");
            sb.Append("  CustomerAccessLink: ").Append(CustomerAccessLink).Append("\n");
            sb.Append("  LinkOnPortalLogin: ").Append(LinkOnPortalLogin).Append("\n");
            sb.Append("  TechnicianEmailList: ").Append(TechnicianEmailList).Append("\n");
            sb.Append("  InvitationSubject: ").Append(InvitationSubject).Append("\n");
            sb.Append("  InvitationMessage: ").Append(InvitationMessage).Append("\n");
            sb.Append("  MaxRequests: ").Append(MaxRequests).Append("\n");
            sb.Append("  LimitMessage: ").Append(LimitMessage).Append("\n");
            sb.Append("  MaxRequestsOneIp: ").Append(MaxRequestsOneIp).Append("\n");
            sb.Append("  PendingRequestExpiration: ").Append(PendingRequestExpiration).Append("\n");
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
            return this.Equals(input as VirtualAssistVirtualAssist);
        }

        /// <summary>
        /// Returns true if VirtualAssistVirtualAssist instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualAssistVirtualAssist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualAssistVirtualAssist input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssistanceCode == input.AssistanceCode ||
                    (this.AssistanceCode != null &&
                    this.AssistanceCode.Equals(input.AssistanceCode))
                ) && 
                (
                    this.SupportWithoutInvitation == input.SupportWithoutInvitation ||
                    this.SupportWithoutInvitation.Equals(input.SupportWithoutInvitation)
                ) && 
                (
                    this.Disclaimer == input.Disclaimer ||
                    (this.Disclaimer != null &&
                    this.Disclaimer.Equals(input.Disclaimer))
                ) && 
                (
                    this.CustomerAccessLink == input.CustomerAccessLink ||
                    (this.CustomerAccessLink != null &&
                    this.CustomerAccessLink.Equals(input.CustomerAccessLink))
                ) && 
                (
                    this.LinkOnPortalLogin == input.LinkOnPortalLogin ||
                    this.LinkOnPortalLogin.Equals(input.LinkOnPortalLogin)
                ) && 
                (
                    this.TechnicianEmailList == input.TechnicianEmailList ||
                    (this.TechnicianEmailList != null &&
                    this.TechnicianEmailList.Equals(input.TechnicianEmailList))
                ) && 
                (
                    this.InvitationSubject == input.InvitationSubject ||
                    (this.InvitationSubject != null &&
                    this.InvitationSubject.Equals(input.InvitationSubject))
                ) && 
                (
                    this.InvitationMessage == input.InvitationMessage ||
                    (this.InvitationMessage != null &&
                    this.InvitationMessage.Equals(input.InvitationMessage))
                ) && 
                (
                    this.MaxRequests == input.MaxRequests ||
                    this.MaxRequests.Equals(input.MaxRequests)
                ) && 
                (
                    this.LimitMessage == input.LimitMessage ||
                    (this.LimitMessage != null &&
                    this.LimitMessage.Equals(input.LimitMessage))
                ) && 
                (
                    this.MaxRequestsOneIp == input.MaxRequestsOneIp ||
                    (this.MaxRequestsOneIp != null &&
                    this.MaxRequestsOneIp.Equals(input.MaxRequestsOneIp))
                ) && 
                (
                    this.PendingRequestExpiration == input.PendingRequestExpiration ||
                    (this.PendingRequestExpiration != null &&
                    this.PendingRequestExpiration.Equals(input.PendingRequestExpiration))
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
                if (this.AssistanceCode != null)
                {
                    hashCode = (hashCode * 59) + this.AssistanceCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SupportWithoutInvitation.GetHashCode();
                if (this.Disclaimer != null)
                {
                    hashCode = (hashCode * 59) + this.Disclaimer.GetHashCode();
                }
                if (this.CustomerAccessLink != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerAccessLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LinkOnPortalLogin.GetHashCode();
                if (this.TechnicianEmailList != null)
                {
                    hashCode = (hashCode * 59) + this.TechnicianEmailList.GetHashCode();
                }
                if (this.InvitationSubject != null)
                {
                    hashCode = (hashCode * 59) + this.InvitationSubject.GetHashCode();
                }
                if (this.InvitationMessage != null)
                {
                    hashCode = (hashCode * 59) + this.InvitationMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxRequests.GetHashCode();
                if (this.LimitMessage != null)
                {
                    hashCode = (hashCode * 59) + this.LimitMessage.GetHashCode();
                }
                if (this.MaxRequestsOneIp != null)
                {
                    hashCode = (hashCode * 59) + this.MaxRequestsOneIp.GetHashCode();
                }
                if (this.PendingRequestExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.PendingRequestExpiration.GetHashCode();
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