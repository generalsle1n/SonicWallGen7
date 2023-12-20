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
    /// local user configuration.
    /// </summary>
    [DataContract(Name = "user_local_user")]
    public partial class UserLocalUser : IEquatable<UserLocalUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserLocalUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalUser" /> class.
        /// </summary>
        /// <param name="name">Set the login name of the user account. (required).</param>
        /// <param name="domain">Set the user&#39;s domain. * Set to null to represent an unconfigured state..</param>
        /// <param name="displayName">Only used for show user display name..</param>
        /// <param name="password">Set the user password. * Set to null to represent an unconfigured state..</param>
        /// <param name="comment">Set a comment for the user account. * Set to null to represent an unconfigured state..</param>
        /// <param name="forcePasswordChange">Force the user to change their password at next login..</param>
        /// <param name="oneTimePassword">oneTimePassword.</param>
        /// <param name="accountLifetime">accountLifetime.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="pruneOnExpiry">Delete the user account when it expires if a limited lifetime is set..</param>
        /// <param name="quotaCycle">quotaCycle.</param>
        /// <param name="sessionLifetime">sessionLifetime.</param>
        /// <param name="limit">limit.</param>
        /// <param name="emailAddress">Set the user&#39;s e-mail address. * Set to null to represent an unconfigured state..</param>
        /// <param name="guestLoginUniqueness">Enable enforcing a unique login session with the account for guest services..</param>
        /// <param name="guestIdleTimeout">guestIdleTimeout.</param>
        /// <param name="memberOf">Add membership to a user group for this user..</param>
        /// <param name="vpnClientAccess">Add access to a network for the user with VPN client..</param>
        /// <param name="bookmark">Add/edit bookmark and enter configuration mode..</param>
        public UserLocalUser(string name = default(string), string domain = default(string), string displayName = default(string), string password = default(string), string comment = default(string), bool forcePasswordChange = default(bool), UserLocalUserOneTimePassword oneTimePassword = default(UserLocalUserOneTimePassword), UserLocalUserAccountLifetime accountLifetime = default(UserLocalUserAccountLifetime), UserLocalUserExpiration expiration = default(UserLocalUserExpiration), bool pruneOnExpiry = default(bool), UserLocalUserQuotaCycle quotaCycle = default(UserLocalUserQuotaCycle), UserLocalUserSessionLifetime sessionLifetime = default(UserLocalUserSessionLifetime), UserLocalUserLimit limit = default(UserLocalUserLimit), string emailAddress = default(string), bool guestLoginUniqueness = default(bool), UserLocalUserGuestIdleTimeout guestIdleTimeout = default(UserLocalUserGuestIdleTimeout), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> memberOf = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>), List<UserLocalUserVpnClientAccessInner> vpnClientAccess = default(List<UserLocalUserVpnClientAccessInner>), List<UserLocalUserBookmarkInner> bookmark = default(List<UserLocalUserBookmarkInner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UserLocalUser and cannot be null");
            }
            this.Name = name;
            this.Domain = domain;
            this.DisplayName = displayName;
            this.Password = password;
            this.Comment = comment;
            this.ForcePasswordChange = forcePasswordChange;
            this.OneTimePassword = oneTimePassword;
            this.AccountLifetime = accountLifetime;
            this.Expiration = expiration;
            this.PruneOnExpiry = pruneOnExpiry;
            this.QuotaCycle = quotaCycle;
            this.SessionLifetime = sessionLifetime;
            this.Limit = limit;
            this.EmailAddress = emailAddress;
            this.GuestLoginUniqueness = guestLoginUniqueness;
            this.GuestIdleTimeout = guestIdleTimeout;
            this.MemberOf = memberOf;
            this.VpnClientAccess = vpnClientAccess;
            this.Bookmark = bookmark;
        }

        /// <summary>
        /// Set the login name of the user account.
        /// </summary>
        /// <value>Set the login name of the user account.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set the user&#39;s domain. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set the user&#39;s domain. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "domain", EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// user object UUID.
        /// </summary>
        /// <value>user object UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Only used for show user display name.
        /// </summary>
        /// <value>Only used for show user display name.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Set the user password. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set the user password. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Set a comment for the user account. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set a comment for the user account. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Force the user to change their password at next login.
        /// </summary>
        /// <value>Force the user to change their password at next login.</value>
        [DataMember(Name = "force_password_change", EmitDefaultValue = true)]
        public bool ForcePasswordChange { get; set; }

        /// <summary>
        /// Gets or Sets OneTimePassword
        /// </summary>
        [DataMember(Name = "one_time_password", EmitDefaultValue = false)]
        public UserLocalUserOneTimePassword OneTimePassword { get; set; }

        /// <summary>
        /// Gets or Sets AccountLifetime
        /// </summary>
        [DataMember(Name = "account_lifetime", EmitDefaultValue = false)]
        public UserLocalUserAccountLifetime AccountLifetime { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public UserLocalUserExpiration Expiration { get; set; }

        /// <summary>
        /// Delete the user account when it expires if a limited lifetime is set.
        /// </summary>
        /// <value>Delete the user account when it expires if a limited lifetime is set.</value>
        [DataMember(Name = "prune_on_expiry", EmitDefaultValue = true)]
        public bool PruneOnExpiry { get; set; }

        /// <summary>
        /// Gets or Sets QuotaCycle
        /// </summary>
        [DataMember(Name = "quota_cycle", EmitDefaultValue = false)]
        public UserLocalUserQuotaCycle QuotaCycle { get; set; }

        /// <summary>
        /// Gets or Sets SessionLifetime
        /// </summary>
        [DataMember(Name = "session_lifetime", EmitDefaultValue = false)]
        public UserLocalUserSessionLifetime SessionLifetime { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public UserLocalUserLimit Limit { get; set; }

        /// <summary>
        /// Set the user&#39;s e-mail address. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set the user&#39;s e-mail address. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Enable enforcing a unique login session with the account for guest services.
        /// </summary>
        /// <value>Enable enforcing a unique login session with the account for guest services.</value>
        [DataMember(Name = "guest_login_uniqueness", EmitDefaultValue = true)]
        public bool GuestLoginUniqueness { get; set; }

        /// <summary>
        /// Gets or Sets GuestIdleTimeout
        /// </summary>
        [DataMember(Name = "guest_idle_timeout", EmitDefaultValue = false)]
        public UserLocalUserGuestIdleTimeout GuestIdleTimeout { get; set; }

        /// <summary>
        /// Add membership to a user group for this user.
        /// </summary>
        /// <value>Add membership to a user group for this user.</value>
        [DataMember(Name = "member_of", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> MemberOf { get; set; }

        /// <summary>
        /// Add access to a network for the user with VPN client.
        /// </summary>
        /// <value>Add access to a network for the user with VPN client.</value>
        [DataMember(Name = "vpn_client_access", EmitDefaultValue = false)]
        public List<UserLocalUserVpnClientAccessInner> VpnClientAccess { get; set; }

        /// <summary>
        /// Add/edit bookmark and enter configuration mode.
        /// </summary>
        /// <value>Add/edit bookmark and enter configuration mode.</value>
        [DataMember(Name = "bookmark", EmitDefaultValue = false)]
        public List<UserLocalUserBookmarkInner> Bookmark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLocalUser {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ForcePasswordChange: ").Append(ForcePasswordChange).Append("\n");
            sb.Append("  OneTimePassword: ").Append(OneTimePassword).Append("\n");
            sb.Append("  AccountLifetime: ").Append(AccountLifetime).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  PruneOnExpiry: ").Append(PruneOnExpiry).Append("\n");
            sb.Append("  QuotaCycle: ").Append(QuotaCycle).Append("\n");
            sb.Append("  SessionLifetime: ").Append(SessionLifetime).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  GuestLoginUniqueness: ").Append(GuestLoginUniqueness).Append("\n");
            sb.Append("  GuestIdleTimeout: ").Append(GuestIdleTimeout).Append("\n");
            sb.Append("  MemberOf: ").Append(MemberOf).Append("\n");
            sb.Append("  VpnClientAccess: ").Append(VpnClientAccess).Append("\n");
            sb.Append("  Bookmark: ").Append(Bookmark).Append("\n");
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
            return this.Equals(input as UserLocalUser);
        }

        /// <summary>
        /// Returns true if UserLocalUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLocalUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocalUser input)
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
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.ForcePasswordChange == input.ForcePasswordChange ||
                    this.ForcePasswordChange.Equals(input.ForcePasswordChange)
                ) && 
                (
                    this.OneTimePassword == input.OneTimePassword ||
                    (this.OneTimePassword != null &&
                    this.OneTimePassword.Equals(input.OneTimePassword))
                ) && 
                (
                    this.AccountLifetime == input.AccountLifetime ||
                    (this.AccountLifetime != null &&
                    this.AccountLifetime.Equals(input.AccountLifetime))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.PruneOnExpiry == input.PruneOnExpiry ||
                    this.PruneOnExpiry.Equals(input.PruneOnExpiry)
                ) && 
                (
                    this.QuotaCycle == input.QuotaCycle ||
                    (this.QuotaCycle != null &&
                    this.QuotaCycle.Equals(input.QuotaCycle))
                ) && 
                (
                    this.SessionLifetime == input.SessionLifetime ||
                    (this.SessionLifetime != null &&
                    this.SessionLifetime.Equals(input.SessionLifetime))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.GuestLoginUniqueness == input.GuestLoginUniqueness ||
                    this.GuestLoginUniqueness.Equals(input.GuestLoginUniqueness)
                ) && 
                (
                    this.GuestIdleTimeout == input.GuestIdleTimeout ||
                    (this.GuestIdleTimeout != null &&
                    this.GuestIdleTimeout.Equals(input.GuestIdleTimeout))
                ) && 
                (
                    this.MemberOf == input.MemberOf ||
                    this.MemberOf != null &&
                    input.MemberOf != null &&
                    this.MemberOf.SequenceEqual(input.MemberOf)
                ) && 
                (
                    this.VpnClientAccess == input.VpnClientAccess ||
                    this.VpnClientAccess != null &&
                    input.VpnClientAccess != null &&
                    this.VpnClientAccess.SequenceEqual(input.VpnClientAccess)
                ) && 
                (
                    this.Bookmark == input.Bookmark ||
                    this.Bookmark != null &&
                    input.Bookmark != null &&
                    this.Bookmark.SequenceEqual(input.Bookmark)
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForcePasswordChange.GetHashCode();
                if (this.OneTimePassword != null)
                {
                    hashCode = (hashCode * 59) + this.OneTimePassword.GetHashCode();
                }
                if (this.AccountLifetime != null)
                {
                    hashCode = (hashCode * 59) + this.AccountLifetime.GetHashCode();
                }
                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PruneOnExpiry.GetHashCode();
                if (this.QuotaCycle != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaCycle.GetHashCode();
                }
                if (this.SessionLifetime != null)
                {
                    hashCode = (hashCode * 59) + this.SessionLifetime.GetHashCode();
                }
                if (this.Limit != null)
                {
                    hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GuestLoginUniqueness.GetHashCode();
                if (this.GuestIdleTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.GuestIdleTimeout.GetHashCode();
                }
                if (this.MemberOf != null)
                {
                    hashCode = (hashCode * 59) + this.MemberOf.GetHashCode();
                }
                if (this.VpnClientAccess != null)
                {
                    hashCode = (hashCode * 59) + this.VpnClientAccess.GetHashCode();
                }
                if (this.Bookmark != null)
                {
                    hashCode = (hashCode * 59) + this.Bookmark.GetHashCode();
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