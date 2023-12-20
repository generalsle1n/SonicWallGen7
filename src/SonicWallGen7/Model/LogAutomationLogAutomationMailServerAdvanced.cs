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
    /// Mail server advanced.
    /// </summary>
    [DataContract(Name = "log_automation_log_automation_mail_server_advanced")]
    public partial class LogAutomationLogAutomationMailServerAdvanced : IEquatable<LogAutomationLogAutomationMailServerAdvanced>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationLogAutomationMailServerAdvanced" /> class.
        /// </summary>
        /// <param name="smtpPort">Set E-mail server SMTP TCP port..</param>
        /// <param name="connectionSecurityMethod">connectionSecurityMethod.</param>
        /// <param name="smtpAuthentication">Enable SMTP authentication..</param>
        /// <param name="userName">Specify username for authentication..</param>
        /// <param name="password">Specify password for authentication..</param>
        public LogAutomationLogAutomationMailServerAdvanced(decimal smtpPort = default(decimal), LogAutomationLogAutomationMailServerAdvancedConnectionSecurityMethod connectionSecurityMethod = default(LogAutomationLogAutomationMailServerAdvancedConnectionSecurityMethod), bool smtpAuthentication = default(bool), string userName = default(string), string password = default(string))
        {
            this.SmtpPort = smtpPort;
            this.ConnectionSecurityMethod = connectionSecurityMethod;
            this.SmtpAuthentication = smtpAuthentication;
            this.UserName = userName;
            this.Password = password;
        }

        /// <summary>
        /// Set E-mail server SMTP TCP port.
        /// </summary>
        /// <value>Set E-mail server SMTP TCP port.</value>
        [DataMember(Name = "smtp_port", EmitDefaultValue = false)]
        public decimal SmtpPort { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionSecurityMethod
        /// </summary>
        [DataMember(Name = "connection_security_method", EmitDefaultValue = false)]
        public LogAutomationLogAutomationMailServerAdvancedConnectionSecurityMethod ConnectionSecurityMethod { get; set; }

        /// <summary>
        /// Enable SMTP authentication.
        /// </summary>
        /// <value>Enable SMTP authentication.</value>
        [DataMember(Name = "smtp_authentication", EmitDefaultValue = true)]
        public bool SmtpAuthentication { get; set; }

        /// <summary>
        /// Specify username for authentication.
        /// </summary>
        /// <value>Specify username for authentication.</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Specify password for authentication.
        /// </summary>
        /// <value>Specify password for authentication.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogAutomationLogAutomationMailServerAdvanced {\n");
            sb.Append("  SmtpPort: ").Append(SmtpPort).Append("\n");
            sb.Append("  ConnectionSecurityMethod: ").Append(ConnectionSecurityMethod).Append("\n");
            sb.Append("  SmtpAuthentication: ").Append(SmtpAuthentication).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as LogAutomationLogAutomationMailServerAdvanced);
        }

        /// <summary>
        /// Returns true if LogAutomationLogAutomationMailServerAdvanced instances are equal
        /// </summary>
        /// <param name="input">Instance of LogAutomationLogAutomationMailServerAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAutomationLogAutomationMailServerAdvanced input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SmtpPort == input.SmtpPort ||
                    this.SmtpPort.Equals(input.SmtpPort)
                ) && 
                (
                    this.ConnectionSecurityMethod == input.ConnectionSecurityMethod ||
                    (this.ConnectionSecurityMethod != null &&
                    this.ConnectionSecurityMethod.Equals(input.ConnectionSecurityMethod))
                ) && 
                (
                    this.SmtpAuthentication == input.SmtpAuthentication ||
                    this.SmtpAuthentication.Equals(input.SmtpAuthentication)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                hashCode = (hashCode * 59) + this.SmtpPort.GetHashCode();
                if (this.ConnectionSecurityMethod != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionSecurityMethod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SmtpAuthentication.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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