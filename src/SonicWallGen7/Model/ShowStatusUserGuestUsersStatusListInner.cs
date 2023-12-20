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
    /// ShowStatusUserGuestUsersStatusListInner
    /// </summary>
    [DataContract(Name = "show_status_user_guest_users_status_list_inner")]
    public partial class ShowStatusUserGuestUsersStatusListInner : IEquatable<ShowStatusUserGuestUsersStatusListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusUserGuestUsersStatusListInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="ip">ip.</param>
        /// <param name="varInterface">varInterface.</param>
        /// <param name="zone">zone.</param>
        /// <param name="mac">mac.</param>
        /// <param name="accountExpiration">accountExpiration.</param>
        /// <param name="quotaCycle">quotaCycle.</param>
        /// <param name="sessionExpiration">sessionExpiration.</param>
        /// <param name="receiveLimit">receiveLimit.</param>
        /// <param name="transmitLimit">transmitLimit.</param>
        public ShowStatusUserGuestUsersStatusListInner(string name = default(string), string ip = default(string), string varInterface = default(string), string zone = default(string), string mac = default(string), string accountExpiration = default(string), string quotaCycle = default(string), string sessionExpiration = default(string), string receiveLimit = default(string), string transmitLimit = default(string))
        {
            this.Name = name;
            this.Ip = ip;
            this.VarInterface = varInterface;
            this.Zone = zone;
            this.Mac = mac;
            this.AccountExpiration = accountExpiration;
            this.QuotaCycle = quotaCycle;
            this.SessionExpiration = sessionExpiration;
            this.ReceiveLimit = receiveLimit;
            this.TransmitLimit = transmitLimit;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets VarInterface
        /// </summary>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public string VarInterface { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        public string Zone { get; set; }

        /// <summary>
        /// Gets or Sets Mac
        /// </summary>
        [DataMember(Name = "mac", EmitDefaultValue = false)]
        public string Mac { get; set; }

        /// <summary>
        /// Gets or Sets AccountExpiration
        /// </summary>
        [DataMember(Name = "account_expiration", EmitDefaultValue = false)]
        public string AccountExpiration { get; set; }

        /// <summary>
        /// Gets or Sets QuotaCycle
        /// </summary>
        [DataMember(Name = "quota_cycle", EmitDefaultValue = false)]
        public string QuotaCycle { get; set; }

        /// <summary>
        /// Gets or Sets SessionExpiration
        /// </summary>
        [DataMember(Name = "session_expiration", EmitDefaultValue = false)]
        public string SessionExpiration { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveLimit
        /// </summary>
        [DataMember(Name = "receive_limit", EmitDefaultValue = false)]
        public string ReceiveLimit { get; set; }

        /// <summary>
        /// Gets or Sets TransmitLimit
        /// </summary>
        [DataMember(Name = "transmit_limit", EmitDefaultValue = false)]
        public string TransmitLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusUserGuestUsersStatusListInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  AccountExpiration: ").Append(AccountExpiration).Append("\n");
            sb.Append("  QuotaCycle: ").Append(QuotaCycle).Append("\n");
            sb.Append("  SessionExpiration: ").Append(SessionExpiration).Append("\n");
            sb.Append("  ReceiveLimit: ").Append(ReceiveLimit).Append("\n");
            sb.Append("  TransmitLimit: ").Append(TransmitLimit).Append("\n");
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
            return this.Equals(input as ShowStatusUserGuestUsersStatusListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusUserGuestUsersStatusListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusUserGuestUsersStatusListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusUserGuestUsersStatusListInner input)
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
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.AccountExpiration == input.AccountExpiration ||
                    (this.AccountExpiration != null &&
                    this.AccountExpiration.Equals(input.AccountExpiration))
                ) && 
                (
                    this.QuotaCycle == input.QuotaCycle ||
                    (this.QuotaCycle != null &&
                    this.QuotaCycle.Equals(input.QuotaCycle))
                ) && 
                (
                    this.SessionExpiration == input.SessionExpiration ||
                    (this.SessionExpiration != null &&
                    this.SessionExpiration.Equals(input.SessionExpiration))
                ) && 
                (
                    this.ReceiveLimit == input.ReceiveLimit ||
                    (this.ReceiveLimit != null &&
                    this.ReceiveLimit.Equals(input.ReceiveLimit))
                ) && 
                (
                    this.TransmitLimit == input.TransmitLimit ||
                    (this.TransmitLimit != null &&
                    this.TransmitLimit.Equals(input.TransmitLimit))
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
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
                }
                if (this.Zone != null)
                {
                    hashCode = (hashCode * 59) + this.Zone.GetHashCode();
                }
                if (this.Mac != null)
                {
                    hashCode = (hashCode * 59) + this.Mac.GetHashCode();
                }
                if (this.AccountExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.AccountExpiration.GetHashCode();
                }
                if (this.QuotaCycle != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaCycle.GetHashCode();
                }
                if (this.SessionExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.SessionExpiration.GetHashCode();
                }
                if (this.ReceiveLimit != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiveLimit.GetHashCode();
                }
                if (this.TransmitLimit != null)
                {
                    hashCode = (hashCode * 59) + this.TransmitLimit.GetHashCode();
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