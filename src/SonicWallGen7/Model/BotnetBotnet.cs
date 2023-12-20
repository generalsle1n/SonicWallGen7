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
    /// Enter botnet configuration mode.
    /// </summary>
    [DataContract(Name = "botnet_botnet")]
    public partial class BotnetBotnet : IEquatable<BotnetBotnet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotnetBotnet" /> class.
        /// </summary>
        /// <param name="block">block.</param>
        /// <param name="logging">Enable botnet filter logging..</param>
        /// <param name="exclude">exclude.</param>
        /// <param name="include">include.</param>
        /// <param name="alertText">Set the botnet alert text..</param>
        /// <param name="logoIcon">logoIcon.</param>
        /// <param name="dynamicList">dynamicList.</param>
        /// <param name="customList">customList.</param>
        public BotnetBotnet(BotnetBotnetBlock block = default(BotnetBotnetBlock), bool logging = default(bool), BotnetBotnetExclude exclude = default(BotnetBotnetExclude), BotnetBotnetInclude include = default(BotnetBotnetInclude), string alertText = default(string), BotnetBotnetLogoIcon logoIcon = default(BotnetBotnetLogoIcon), BotnetBotnetDynamicList dynamicList = default(BotnetBotnetDynamicList), BotnetBotnetCustomList customList = default(BotnetBotnetCustomList))
        {
            this.Block = block;
            this.Logging = logging;
            this.Exclude = exclude;
            this.Include = include;
            this.AlertText = alertText;
            this.LogoIcon = logoIcon;
            this.DynamicList = dynamicList;
            this.CustomList = customList;
        }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public BotnetBotnetBlock Block { get; set; }

        /// <summary>
        /// Enable botnet filter logging.
        /// </summary>
        /// <value>Enable botnet filter logging.</value>
        [DataMember(Name = "logging", EmitDefaultValue = true)]
        public bool Logging { get; set; }

        /// <summary>
        /// Gets or Sets Exclude
        /// </summary>
        [DataMember(Name = "exclude", EmitDefaultValue = false)]
        public BotnetBotnetExclude Exclude { get; set; }

        /// <summary>
        /// Gets or Sets Include
        /// </summary>
        [DataMember(Name = "include", EmitDefaultValue = false)]
        public BotnetBotnetInclude Include { get; set; }

        /// <summary>
        /// Set the botnet alert text.
        /// </summary>
        /// <value>Set the botnet alert text.</value>
        [DataMember(Name = "alert_text", EmitDefaultValue = false)]
        public string AlertText { get; set; }

        /// <summary>
        /// Gets or Sets LogoIcon
        /// </summary>
        [DataMember(Name = "logo_icon", EmitDefaultValue = false)]
        public BotnetBotnetLogoIcon LogoIcon { get; set; }

        /// <summary>
        /// Gets or Sets DynamicList
        /// </summary>
        [DataMember(Name = "dynamic_list", EmitDefaultValue = false)]
        public BotnetBotnetDynamicList DynamicList { get; set; }

        /// <summary>
        /// Gets or Sets CustomList
        /// </summary>
        [DataMember(Name = "custom_list", EmitDefaultValue = false)]
        public BotnetBotnetCustomList CustomList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BotnetBotnet {\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Logging: ").Append(Logging).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  AlertText: ").Append(AlertText).Append("\n");
            sb.Append("  LogoIcon: ").Append(LogoIcon).Append("\n");
            sb.Append("  DynamicList: ").Append(DynamicList).Append("\n");
            sb.Append("  CustomList: ").Append(CustomList).Append("\n");
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
            return this.Equals(input as BotnetBotnet);
        }

        /// <summary>
        /// Returns true if BotnetBotnet instances are equal
        /// </summary>
        /// <param name="input">Instance of BotnetBotnet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotnetBotnet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Logging == input.Logging ||
                    this.Logging.Equals(input.Logging)
                ) && 
                (
                    this.Exclude == input.Exclude ||
                    (this.Exclude != null &&
                    this.Exclude.Equals(input.Exclude))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
                ) && 
                (
                    this.AlertText == input.AlertText ||
                    (this.AlertText != null &&
                    this.AlertText.Equals(input.AlertText))
                ) && 
                (
                    this.LogoIcon == input.LogoIcon ||
                    (this.LogoIcon != null &&
                    this.LogoIcon.Equals(input.LogoIcon))
                ) && 
                (
                    this.DynamicList == input.DynamicList ||
                    (this.DynamicList != null &&
                    this.DynamicList.Equals(input.DynamicList))
                ) && 
                (
                    this.CustomList == input.CustomList ||
                    (this.CustomList != null &&
                    this.CustomList.Equals(input.CustomList))
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
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Logging.GetHashCode();
                if (this.Exclude != null)
                {
                    hashCode = (hashCode * 59) + this.Exclude.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
                }
                if (this.AlertText != null)
                {
                    hashCode = (hashCode * 59) + this.AlertText.GetHashCode();
                }
                if (this.LogoIcon != null)
                {
                    hashCode = (hashCode * 59) + this.LogoIcon.GetHashCode();
                }
                if (this.DynamicList != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicList.GetHashCode();
                }
                if (this.CustomList != null)
                {
                    hashCode = (hashCode * 59) + this.CustomList.GetHashCode();
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
