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
    /// Configure user authentication related settings.
    /// </summary>
    [DataContract(Name = "user_auth_base_user_auth")]
    public partial class UserAuthBaseUserAuth : IEquatable<UserAuthBaseUserAuth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthBaseUserAuth" /> class.
        /// </summary>
        /// <param name="caseSensitiveNames">Enable treating user names as case-sensitive..</param>
        /// <param name="loginUniqueness">Enable enforcing a single login per user name..</param>
        /// <param name="reloginAfterPasswordChange">Enable enforcing relogin after password change..</param>
        /// <param name="displayLoginInfo">Display user login info since last login..</param>
        /// <param name="oneTimePasswordConstraints">Enable One Time Password constraints..</param>
        /// <param name="oneTimePassword">oneTimePassword.</param>
        /// <param name="authPageTimeout">Set the timeout for showing the web login page. * Set to null to represent an unconfigured state..</param>
        /// <param name="browserRedirectVia">browserRedirectVia.</param>
        /// <param name="redirectToLoginPage">redirectToLoginPage.</param>
        /// <param name="httpRedirectAfterLogin">Enable redirect from HTTPS to HTTP after login..</param>
        /// <param name="redirectExternalPage">Set the redirect to external login page on redirecting unauthenticated users..</param>
        /// <param name="combinedLogin">combinedLogin.</param>
        /// <param name="policyBannerBeforeLogin">Enable start with policy banner before login page..</param>
        /// <param name="policyBanner">policyBanner.</param>
        /// <param name="inactivityTimeout">Set the user inactivity timeout(minutes)..</param>
        /// <param name="preventInactivityLogout">preventInactivityLogout.</param>
        /// <param name="logUserName">logUserName.</param>
        /// <param name="userConnectionsLogout">userConnectionsLogout.</param>
        /// <param name="inactiveUser">inactiveUser.</param>
        /// <param name="ageOut">Set age out inactive users time (minutes)..</param>
        /// <param name="webLoginSessionLimit">Set the maximum login session time for web users. * Set to null to represent an unconfigured state..</param>
        /// <param name="showUserStatusWindow">Enable showing the status window after web login..</param>
        /// <param name="statusWindowHeartbeat">statusWindowHeartbeat.</param>
        /// <param name="disconnectedUserDetect">Enable detecting disconnected web users..</param>
        /// <param name="openInSameWindow">Enable open user&#39;s login status window in the same window rather than in a popup..</param>
        /// <param name="radiusChapHttpLogin">Enable HTTP login with RADIUS CHAP mode when avail..</param>
        /// <param name="acceptableUsePolicy">acceptableUsePolicy.</param>
        /// <param name="customizeLoginPage">customizeLoginPage.</param>
        public UserAuthBaseUserAuth(bool caseSensitiveNames = default(bool), bool loginUniqueness = default(bool), bool reloginAfterPasswordChange = default(bool), bool displayLoginInfo = default(bool), bool oneTimePasswordConstraints = default(bool), UserAuthBaseUserAuthOneTimePassword oneTimePassword = default(UserAuthBaseUserAuthOneTimePassword), decimal? authPageTimeout = default(decimal?), UserAuthBaseUserAuthBrowserRedirectVia browserRedirectVia = default(UserAuthBaseUserAuthBrowserRedirectVia), UserAuthBaseUserAuthRedirectToLoginPage redirectToLoginPage = default(UserAuthBaseUserAuthRedirectToLoginPage), bool httpRedirectAfterLogin = default(bool), string redirectExternalPage = default(string), UserAuthBaseUserAuthCombinedLogin combinedLogin = default(UserAuthBaseUserAuthCombinedLogin), bool policyBannerBeforeLogin = default(bool), UserAuthBaseUserAuthPolicyBanner policyBanner = default(UserAuthBaseUserAuthPolicyBanner), decimal inactivityTimeout = default(decimal), UserAuthBaseUserAuthPreventInactivityLogout preventInactivityLogout = default(UserAuthBaseUserAuthPreventInactivityLogout), UserAuthBaseUserAuthLogUserName logUserName = default(UserAuthBaseUserAuthLogUserName), UserAuthBaseUserAuthUserConnectionsLogout userConnectionsLogout = default(UserAuthBaseUserAuthUserConnectionsLogout), UserAuthBaseUserAuthInactiveUser inactiveUser = default(UserAuthBaseUserAuthInactiveUser), decimal ageOut = default(decimal), decimal? webLoginSessionLimit = default(decimal?), bool showUserStatusWindow = default(bool), UserAuthBaseUserAuthStatusWindowHeartbeat statusWindowHeartbeat = default(UserAuthBaseUserAuthStatusWindowHeartbeat), bool disconnectedUserDetect = default(bool), bool openInSameWindow = default(bool), bool radiusChapHttpLogin = default(bool), UserAuthBaseUserAuthAcceptableUsePolicy acceptableUsePolicy = default(UserAuthBaseUserAuthAcceptableUsePolicy), UserAuthBaseUserAuthCustomizeLoginPage customizeLoginPage = default(UserAuthBaseUserAuthCustomizeLoginPage))
        {
            this.CaseSensitiveNames = caseSensitiveNames;
            this.LoginUniqueness = loginUniqueness;
            this.ReloginAfterPasswordChange = reloginAfterPasswordChange;
            this.DisplayLoginInfo = displayLoginInfo;
            this.OneTimePasswordConstraints = oneTimePasswordConstraints;
            this.OneTimePassword = oneTimePassword;
            this.AuthPageTimeout = authPageTimeout;
            this.BrowserRedirectVia = browserRedirectVia;
            this.RedirectToLoginPage = redirectToLoginPage;
            this.HttpRedirectAfterLogin = httpRedirectAfterLogin;
            this.RedirectExternalPage = redirectExternalPage;
            this.CombinedLogin = combinedLogin;
            this.PolicyBannerBeforeLogin = policyBannerBeforeLogin;
            this.PolicyBanner = policyBanner;
            this.InactivityTimeout = inactivityTimeout;
            this.PreventInactivityLogout = preventInactivityLogout;
            this.LogUserName = logUserName;
            this.UserConnectionsLogout = userConnectionsLogout;
            this.InactiveUser = inactiveUser;
            this.AgeOut = ageOut;
            this.WebLoginSessionLimit = webLoginSessionLimit;
            this.ShowUserStatusWindow = showUserStatusWindow;
            this.StatusWindowHeartbeat = statusWindowHeartbeat;
            this.DisconnectedUserDetect = disconnectedUserDetect;
            this.OpenInSameWindow = openInSameWindow;
            this.RadiusChapHttpLogin = radiusChapHttpLogin;
            this.AcceptableUsePolicy = acceptableUsePolicy;
            this.CustomizeLoginPage = customizeLoginPage;
        }

        /// <summary>
        /// Enable treating user names as case-sensitive.
        /// </summary>
        /// <value>Enable treating user names as case-sensitive.</value>
        [DataMember(Name = "case_sensitive_names", EmitDefaultValue = true)]
        public bool CaseSensitiveNames { get; set; }

        /// <summary>
        /// Enable enforcing a single login per user name.
        /// </summary>
        /// <value>Enable enforcing a single login per user name.</value>
        [DataMember(Name = "login_uniqueness", EmitDefaultValue = true)]
        public bool LoginUniqueness { get; set; }

        /// <summary>
        /// Enable enforcing relogin after password change.
        /// </summary>
        /// <value>Enable enforcing relogin after password change.</value>
        [DataMember(Name = "relogin_after_password_change", EmitDefaultValue = true)]
        public bool ReloginAfterPasswordChange { get; set; }

        /// <summary>
        /// Display user login info since last login.
        /// </summary>
        /// <value>Display user login info since last login.</value>
        [DataMember(Name = "display_login_info", EmitDefaultValue = true)]
        public bool DisplayLoginInfo { get; set; }

        /// <summary>
        /// Enable One Time Password constraints.
        /// </summary>
        /// <value>Enable One Time Password constraints.</value>
        [DataMember(Name = "one_time_password_constraints", EmitDefaultValue = true)]
        public bool OneTimePasswordConstraints { get; set; }

        /// <summary>
        /// Gets or Sets OneTimePassword
        /// </summary>
        [DataMember(Name = "one_time_password", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthOneTimePassword OneTimePassword { get; set; }

        /// <summary>
        /// Set the timeout for showing the web login page. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set the timeout for showing the web login page. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "auth_page_timeout", EmitDefaultValue = true)]
        public decimal? AuthPageTimeout { get; set; }

        /// <summary>
        /// Gets or Sets BrowserRedirectVia
        /// </summary>
        [DataMember(Name = "browser_redirect_via", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthBrowserRedirectVia BrowserRedirectVia { get; set; }

        /// <summary>
        /// Gets or Sets RedirectToLoginPage
        /// </summary>
        [DataMember(Name = "redirect_to_login_page", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthRedirectToLoginPage RedirectToLoginPage { get; set; }

        /// <summary>
        /// Enable redirect from HTTPS to HTTP after login.
        /// </summary>
        /// <value>Enable redirect from HTTPS to HTTP after login.</value>
        [DataMember(Name = "http_redirect_after_login", EmitDefaultValue = true)]
        public bool HttpRedirectAfterLogin { get; set; }

        /// <summary>
        /// Set the redirect to external login page on redirecting unauthenticated users.
        /// </summary>
        /// <value>Set the redirect to external login page on redirecting unauthenticated users.</value>
        [DataMember(Name = "redirect_external_page", EmitDefaultValue = false)]
        public string RedirectExternalPage { get; set; }

        /// <summary>
        /// Gets or Sets CombinedLogin
        /// </summary>
        [DataMember(Name = "combined_login", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthCombinedLogin CombinedLogin { get; set; }

        /// <summary>
        /// Enable start with policy banner before login page.
        /// </summary>
        /// <value>Enable start with policy banner before login page.</value>
        [DataMember(Name = "policy_banner_before_login", EmitDefaultValue = true)]
        public bool PolicyBannerBeforeLogin { get; set; }

        /// <summary>
        /// Gets or Sets PolicyBanner
        /// </summary>
        [DataMember(Name = "policy_banner", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthPolicyBanner PolicyBanner { get; set; }

        /// <summary>
        /// Set the user inactivity timeout(minutes).
        /// </summary>
        /// <value>Set the user inactivity timeout(minutes).</value>
        [DataMember(Name = "inactivity_timeout", EmitDefaultValue = false)]
        public decimal InactivityTimeout { get; set; }

        /// <summary>
        /// Gets or Sets PreventInactivityLogout
        /// </summary>
        [DataMember(Name = "prevent_inactivity_logout", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthPreventInactivityLogout PreventInactivityLogout { get; set; }

        /// <summary>
        /// Gets or Sets LogUserName
        /// </summary>
        [DataMember(Name = "log_user_name", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthLogUserName LogUserName { get; set; }

        /// <summary>
        /// Gets or Sets UserConnectionsLogout
        /// </summary>
        [DataMember(Name = "user_connections_logout", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthUserConnectionsLogout UserConnectionsLogout { get; set; }

        /// <summary>
        /// Gets or Sets InactiveUser
        /// </summary>
        [DataMember(Name = "inactive_user", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthInactiveUser InactiveUser { get; set; }

        /// <summary>
        /// Set age out inactive users time (minutes).
        /// </summary>
        /// <value>Set age out inactive users time (minutes).</value>
        [DataMember(Name = "age_out", EmitDefaultValue = false)]
        public decimal AgeOut { get; set; }

        /// <summary>
        /// Set the maximum login session time for web users. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set the maximum login session time for web users. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "web_login_session_limit", EmitDefaultValue = true)]
        public decimal? WebLoginSessionLimit { get; set; }

        /// <summary>
        /// Enable showing the status window after web login.
        /// </summary>
        /// <value>Enable showing the status window after web login.</value>
        [DataMember(Name = "show_user_status_window", EmitDefaultValue = true)]
        public bool ShowUserStatusWindow { get; set; }

        /// <summary>
        /// Gets or Sets StatusWindowHeartbeat
        /// </summary>
        [DataMember(Name = "status_window_heartbeat", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthStatusWindowHeartbeat StatusWindowHeartbeat { get; set; }

        /// <summary>
        /// Enable detecting disconnected web users.
        /// </summary>
        /// <value>Enable detecting disconnected web users.</value>
        [DataMember(Name = "disconnected_user_detect", EmitDefaultValue = true)]
        public bool DisconnectedUserDetect { get; set; }

        /// <summary>
        /// Enable open user&#39;s login status window in the same window rather than in a popup.
        /// </summary>
        /// <value>Enable open user&#39;s login status window in the same window rather than in a popup.</value>
        [DataMember(Name = "open_in_same_window", EmitDefaultValue = true)]
        public bool OpenInSameWindow { get; set; }

        /// <summary>
        /// Enable HTTP login with RADIUS CHAP mode when avail.
        /// </summary>
        /// <value>Enable HTTP login with RADIUS CHAP mode when avail.</value>
        [DataMember(Name = "radius_chap_http_login", EmitDefaultValue = true)]
        public bool RadiusChapHttpLogin { get; set; }

        /// <summary>
        /// Gets or Sets AcceptableUsePolicy
        /// </summary>
        [DataMember(Name = "acceptable_use_policy", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthAcceptableUsePolicy AcceptableUsePolicy { get; set; }

        /// <summary>
        /// Gets or Sets CustomizeLoginPage
        /// </summary>
        [DataMember(Name = "customize_login_page", EmitDefaultValue = false)]
        public UserAuthBaseUserAuthCustomizeLoginPage CustomizeLoginPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAuthBaseUserAuth {\n");
            sb.Append("  CaseSensitiveNames: ").Append(CaseSensitiveNames).Append("\n");
            sb.Append("  LoginUniqueness: ").Append(LoginUniqueness).Append("\n");
            sb.Append("  ReloginAfterPasswordChange: ").Append(ReloginAfterPasswordChange).Append("\n");
            sb.Append("  DisplayLoginInfo: ").Append(DisplayLoginInfo).Append("\n");
            sb.Append("  OneTimePasswordConstraints: ").Append(OneTimePasswordConstraints).Append("\n");
            sb.Append("  OneTimePassword: ").Append(OneTimePassword).Append("\n");
            sb.Append("  AuthPageTimeout: ").Append(AuthPageTimeout).Append("\n");
            sb.Append("  BrowserRedirectVia: ").Append(BrowserRedirectVia).Append("\n");
            sb.Append("  RedirectToLoginPage: ").Append(RedirectToLoginPage).Append("\n");
            sb.Append("  HttpRedirectAfterLogin: ").Append(HttpRedirectAfterLogin).Append("\n");
            sb.Append("  RedirectExternalPage: ").Append(RedirectExternalPage).Append("\n");
            sb.Append("  CombinedLogin: ").Append(CombinedLogin).Append("\n");
            sb.Append("  PolicyBannerBeforeLogin: ").Append(PolicyBannerBeforeLogin).Append("\n");
            sb.Append("  PolicyBanner: ").Append(PolicyBanner).Append("\n");
            sb.Append("  InactivityTimeout: ").Append(InactivityTimeout).Append("\n");
            sb.Append("  PreventInactivityLogout: ").Append(PreventInactivityLogout).Append("\n");
            sb.Append("  LogUserName: ").Append(LogUserName).Append("\n");
            sb.Append("  UserConnectionsLogout: ").Append(UserConnectionsLogout).Append("\n");
            sb.Append("  InactiveUser: ").Append(InactiveUser).Append("\n");
            sb.Append("  AgeOut: ").Append(AgeOut).Append("\n");
            sb.Append("  WebLoginSessionLimit: ").Append(WebLoginSessionLimit).Append("\n");
            sb.Append("  ShowUserStatusWindow: ").Append(ShowUserStatusWindow).Append("\n");
            sb.Append("  StatusWindowHeartbeat: ").Append(StatusWindowHeartbeat).Append("\n");
            sb.Append("  DisconnectedUserDetect: ").Append(DisconnectedUserDetect).Append("\n");
            sb.Append("  OpenInSameWindow: ").Append(OpenInSameWindow).Append("\n");
            sb.Append("  RadiusChapHttpLogin: ").Append(RadiusChapHttpLogin).Append("\n");
            sb.Append("  AcceptableUsePolicy: ").Append(AcceptableUsePolicy).Append("\n");
            sb.Append("  CustomizeLoginPage: ").Append(CustomizeLoginPage).Append("\n");
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
            return this.Equals(input as UserAuthBaseUserAuth);
        }

        /// <summary>
        /// Returns true if UserAuthBaseUserAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuthBaseUserAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthBaseUserAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CaseSensitiveNames == input.CaseSensitiveNames ||
                    this.CaseSensitiveNames.Equals(input.CaseSensitiveNames)
                ) && 
                (
                    this.LoginUniqueness == input.LoginUniqueness ||
                    this.LoginUniqueness.Equals(input.LoginUniqueness)
                ) && 
                (
                    this.ReloginAfterPasswordChange == input.ReloginAfterPasswordChange ||
                    this.ReloginAfterPasswordChange.Equals(input.ReloginAfterPasswordChange)
                ) && 
                (
                    this.DisplayLoginInfo == input.DisplayLoginInfo ||
                    this.DisplayLoginInfo.Equals(input.DisplayLoginInfo)
                ) && 
                (
                    this.OneTimePasswordConstraints == input.OneTimePasswordConstraints ||
                    this.OneTimePasswordConstraints.Equals(input.OneTimePasswordConstraints)
                ) && 
                (
                    this.OneTimePassword == input.OneTimePassword ||
                    (this.OneTimePassword != null &&
                    this.OneTimePassword.Equals(input.OneTimePassword))
                ) && 
                (
                    this.AuthPageTimeout == input.AuthPageTimeout ||
                    (this.AuthPageTimeout != null &&
                    this.AuthPageTimeout.Equals(input.AuthPageTimeout))
                ) && 
                (
                    this.BrowserRedirectVia == input.BrowserRedirectVia ||
                    (this.BrowserRedirectVia != null &&
                    this.BrowserRedirectVia.Equals(input.BrowserRedirectVia))
                ) && 
                (
                    this.RedirectToLoginPage == input.RedirectToLoginPage ||
                    (this.RedirectToLoginPage != null &&
                    this.RedirectToLoginPage.Equals(input.RedirectToLoginPage))
                ) && 
                (
                    this.HttpRedirectAfterLogin == input.HttpRedirectAfterLogin ||
                    this.HttpRedirectAfterLogin.Equals(input.HttpRedirectAfterLogin)
                ) && 
                (
                    this.RedirectExternalPage == input.RedirectExternalPage ||
                    (this.RedirectExternalPage != null &&
                    this.RedirectExternalPage.Equals(input.RedirectExternalPage))
                ) && 
                (
                    this.CombinedLogin == input.CombinedLogin ||
                    (this.CombinedLogin != null &&
                    this.CombinedLogin.Equals(input.CombinedLogin))
                ) && 
                (
                    this.PolicyBannerBeforeLogin == input.PolicyBannerBeforeLogin ||
                    this.PolicyBannerBeforeLogin.Equals(input.PolicyBannerBeforeLogin)
                ) && 
                (
                    this.PolicyBanner == input.PolicyBanner ||
                    (this.PolicyBanner != null &&
                    this.PolicyBanner.Equals(input.PolicyBanner))
                ) && 
                (
                    this.InactivityTimeout == input.InactivityTimeout ||
                    this.InactivityTimeout.Equals(input.InactivityTimeout)
                ) && 
                (
                    this.PreventInactivityLogout == input.PreventInactivityLogout ||
                    (this.PreventInactivityLogout != null &&
                    this.PreventInactivityLogout.Equals(input.PreventInactivityLogout))
                ) && 
                (
                    this.LogUserName == input.LogUserName ||
                    (this.LogUserName != null &&
                    this.LogUserName.Equals(input.LogUserName))
                ) && 
                (
                    this.UserConnectionsLogout == input.UserConnectionsLogout ||
                    (this.UserConnectionsLogout != null &&
                    this.UserConnectionsLogout.Equals(input.UserConnectionsLogout))
                ) && 
                (
                    this.InactiveUser == input.InactiveUser ||
                    (this.InactiveUser != null &&
                    this.InactiveUser.Equals(input.InactiveUser))
                ) && 
                (
                    this.AgeOut == input.AgeOut ||
                    this.AgeOut.Equals(input.AgeOut)
                ) && 
                (
                    this.WebLoginSessionLimit == input.WebLoginSessionLimit ||
                    (this.WebLoginSessionLimit != null &&
                    this.WebLoginSessionLimit.Equals(input.WebLoginSessionLimit))
                ) && 
                (
                    this.ShowUserStatusWindow == input.ShowUserStatusWindow ||
                    this.ShowUserStatusWindow.Equals(input.ShowUserStatusWindow)
                ) && 
                (
                    this.StatusWindowHeartbeat == input.StatusWindowHeartbeat ||
                    (this.StatusWindowHeartbeat != null &&
                    this.StatusWindowHeartbeat.Equals(input.StatusWindowHeartbeat))
                ) && 
                (
                    this.DisconnectedUserDetect == input.DisconnectedUserDetect ||
                    this.DisconnectedUserDetect.Equals(input.DisconnectedUserDetect)
                ) && 
                (
                    this.OpenInSameWindow == input.OpenInSameWindow ||
                    this.OpenInSameWindow.Equals(input.OpenInSameWindow)
                ) && 
                (
                    this.RadiusChapHttpLogin == input.RadiusChapHttpLogin ||
                    this.RadiusChapHttpLogin.Equals(input.RadiusChapHttpLogin)
                ) && 
                (
                    this.AcceptableUsePolicy == input.AcceptableUsePolicy ||
                    (this.AcceptableUsePolicy != null &&
                    this.AcceptableUsePolicy.Equals(input.AcceptableUsePolicy))
                ) && 
                (
                    this.CustomizeLoginPage == input.CustomizeLoginPage ||
                    (this.CustomizeLoginPage != null &&
                    this.CustomizeLoginPage.Equals(input.CustomizeLoginPage))
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
                hashCode = (hashCode * 59) + this.CaseSensitiveNames.GetHashCode();
                hashCode = (hashCode * 59) + this.LoginUniqueness.GetHashCode();
                hashCode = (hashCode * 59) + this.ReloginAfterPasswordChange.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayLoginInfo.GetHashCode();
                hashCode = (hashCode * 59) + this.OneTimePasswordConstraints.GetHashCode();
                if (this.OneTimePassword != null)
                {
                    hashCode = (hashCode * 59) + this.OneTimePassword.GetHashCode();
                }
                if (this.AuthPageTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.AuthPageTimeout.GetHashCode();
                }
                if (this.BrowserRedirectVia != null)
                {
                    hashCode = (hashCode * 59) + this.BrowserRedirectVia.GetHashCode();
                }
                if (this.RedirectToLoginPage != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectToLoginPage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpRedirectAfterLogin.GetHashCode();
                if (this.RedirectExternalPage != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectExternalPage.GetHashCode();
                }
                if (this.CombinedLogin != null)
                {
                    hashCode = (hashCode * 59) + this.CombinedLogin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PolicyBannerBeforeLogin.GetHashCode();
                if (this.PolicyBanner != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyBanner.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InactivityTimeout.GetHashCode();
                if (this.PreventInactivityLogout != null)
                {
                    hashCode = (hashCode * 59) + this.PreventInactivityLogout.GetHashCode();
                }
                if (this.LogUserName != null)
                {
                    hashCode = (hashCode * 59) + this.LogUserName.GetHashCode();
                }
                if (this.UserConnectionsLogout != null)
                {
                    hashCode = (hashCode * 59) + this.UserConnectionsLogout.GetHashCode();
                }
                if (this.InactiveUser != null)
                {
                    hashCode = (hashCode * 59) + this.InactiveUser.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AgeOut.GetHashCode();
                if (this.WebLoginSessionLimit != null)
                {
                    hashCode = (hashCode * 59) + this.WebLoginSessionLimit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowUserStatusWindow.GetHashCode();
                if (this.StatusWindowHeartbeat != null)
                {
                    hashCode = (hashCode * 59) + this.StatusWindowHeartbeat.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisconnectedUserDetect.GetHashCode();
                hashCode = (hashCode * 59) + this.OpenInSameWindow.GetHashCode();
                hashCode = (hashCode * 59) + this.RadiusChapHttpLogin.GetHashCode();
                if (this.AcceptableUsePolicy != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptableUsePolicy.GetHashCode();
                }
                if (this.CustomizeLoginPage != null)
                {
                    hashCode = (hashCode * 59) + this.CustomizeLoginPage.GetHashCode();
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