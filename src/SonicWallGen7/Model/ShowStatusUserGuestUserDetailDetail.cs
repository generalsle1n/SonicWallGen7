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
    /// user guest user detail detail schema.
    /// </summary>
    [DataContract(Name = "show_status_user_guest_user_detail_detail")]
    public partial class ShowStatusUserGuestUserDetailDetail : IEquatable<ShowStatusUserGuestUserDetailDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusUserGuestUserDetailDetail" /> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="password">password.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="comment">comment.</param>
        /// <param name="created">created.</param>
        /// <param name="accountExpires">accountExpires.</param>
        /// <param name="accountLeftLifetime">accountLeftLifetime.</param>
        /// <param name="sessionExpires">sessionExpires.</param>
        /// <param name="sessionLifetime">sessionLifetime.</param>
        /// <param name="idleTimeout">idleTimeout.</param>
        /// <param name="receiveLimit">receiveLimit.</param>
        /// <param name="transmitLimit">transmitLimit.</param>
        /// <param name="quotaCycle">quotaCycle.</param>
        public ShowStatusUserGuestUserDetailDetail(string accountName = default(string), string uuid = default(string), string password = default(string), string enabled = default(string), string comment = default(string), string created = default(string), string accountExpires = default(string), string accountLeftLifetime = default(string), string sessionExpires = default(string), string sessionLifetime = default(string), string idleTimeout = default(string), string receiveLimit = default(string), string transmitLimit = default(string), string quotaCycle = default(string))
        {
            this.AccountName = accountName;
            this.Uuid = uuid;
            this.Password = password;
            this.Enabled = enabled;
            this.Comment = comment;
            this.Created = created;
            this.AccountExpires = accountExpires;
            this.AccountLeftLifetime = accountLeftLifetime;
            this.SessionExpires = sessionExpires;
            this.SessionLifetime = sessionLifetime;
            this.IdleTimeout = idleTimeout;
            this.ReceiveLimit = receiveLimit;
            this.TransmitLimit = transmitLimit;
            this.QuotaCycle = quotaCycle;
        }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public string Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets AccountExpires
        /// </summary>
        [DataMember(Name = "account_expires", EmitDefaultValue = false)]
        public string AccountExpires { get; set; }

        /// <summary>
        /// Gets or Sets AccountLeftLifetime
        /// </summary>
        [DataMember(Name = "account_left_lifetime", EmitDefaultValue = false)]
        public string AccountLeftLifetime { get; set; }

        /// <summary>
        /// Gets or Sets SessionExpires
        /// </summary>
        [DataMember(Name = "session_expires", EmitDefaultValue = false)]
        public string SessionExpires { get; set; }

        /// <summary>
        /// Gets or Sets SessionLifetime
        /// </summary>
        [DataMember(Name = "session_lifetime", EmitDefaultValue = false)]
        public string SessionLifetime { get; set; }

        /// <summary>
        /// Gets or Sets IdleTimeout
        /// </summary>
        [DataMember(Name = "idle_timeout", EmitDefaultValue = false)]
        public string IdleTimeout { get; set; }

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
        /// Gets or Sets QuotaCycle
        /// </summary>
        [DataMember(Name = "quota_cycle", EmitDefaultValue = false)]
        public string QuotaCycle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusUserGuestUserDetailDetail {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AccountExpires: ").Append(AccountExpires).Append("\n");
            sb.Append("  AccountLeftLifetime: ").Append(AccountLeftLifetime).Append("\n");
            sb.Append("  SessionExpires: ").Append(SessionExpires).Append("\n");
            sb.Append("  SessionLifetime: ").Append(SessionLifetime).Append("\n");
            sb.Append("  IdleTimeout: ").Append(IdleTimeout).Append("\n");
            sb.Append("  ReceiveLimit: ").Append(ReceiveLimit).Append("\n");
            sb.Append("  TransmitLimit: ").Append(TransmitLimit).Append("\n");
            sb.Append("  QuotaCycle: ").Append(QuotaCycle).Append("\n");
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
            return this.Equals(input as ShowStatusUserGuestUserDetailDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusUserGuestUserDetailDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusUserGuestUserDetailDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusUserGuestUserDetailDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.AccountExpires == input.AccountExpires ||
                    (this.AccountExpires != null &&
                    this.AccountExpires.Equals(input.AccountExpires))
                ) && 
                (
                    this.AccountLeftLifetime == input.AccountLeftLifetime ||
                    (this.AccountLeftLifetime != null &&
                    this.AccountLeftLifetime.Equals(input.AccountLeftLifetime))
                ) && 
                (
                    this.SessionExpires == input.SessionExpires ||
                    (this.SessionExpires != null &&
                    this.SessionExpires.Equals(input.SessionExpires))
                ) && 
                (
                    this.SessionLifetime == input.SessionLifetime ||
                    (this.SessionLifetime != null &&
                    this.SessionLifetime.Equals(input.SessionLifetime))
                ) && 
                (
                    this.IdleTimeout == input.IdleTimeout ||
                    (this.IdleTimeout != null &&
                    this.IdleTimeout.Equals(input.IdleTimeout))
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
                ) && 
                (
                    this.QuotaCycle == input.QuotaCycle ||
                    (this.QuotaCycle != null &&
                    this.QuotaCycle.Equals(input.QuotaCycle))
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
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.AccountExpires != null)
                {
                    hashCode = (hashCode * 59) + this.AccountExpires.GetHashCode();
                }
                if (this.AccountLeftLifetime != null)
                {
                    hashCode = (hashCode * 59) + this.AccountLeftLifetime.GetHashCode();
                }
                if (this.SessionExpires != null)
                {
                    hashCode = (hashCode * 59) + this.SessionExpires.GetHashCode();
                }
                if (this.SessionLifetime != null)
                {
                    hashCode = (hashCode * 59) + this.SessionLifetime.GetHashCode();
                }
                if (this.IdleTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.IdleTimeout.GetHashCode();
                }
                if (this.ReceiveLimit != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiveLimit.GetHashCode();
                }
                if (this.TransmitLimit != null)
                {
                    hashCode = (hashCode * 59) + this.TransmitLimit.GetHashCode();
                }
                if (this.QuotaCycle != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaCycle.GetHashCode();
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
