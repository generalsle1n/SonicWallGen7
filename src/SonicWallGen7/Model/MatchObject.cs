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
    /// Match object configuration.
    /// </summary>
    [DataContract(Name = "match_object")]
    public partial class MatchObject : IEquatable<MatchObject>, IValidatableObject
    {
        /// <summary>
        /// Match object type.
        /// </summary>
        /// <value>Match object type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ActivexClassId for value: activex-class-id
            /// </summary>
            [EnumMember(Value = "activex-class-id")]
            ActivexClassId = 1,

            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 2,

            /// <summary>
            /// Enum EmailBody for value: email-body
            /// </summary>
            [EnumMember(Value = "email-body")]
            EmailBody = 3,

            /// <summary>
            /// Enum EmailCc for value: email-cc
            /// </summary>
            [EnumMember(Value = "email-cc")]
            EmailCc = 4,

            /// <summary>
            /// Enum EmailFrom for value: email-from
            /// </summary>
            [EnumMember(Value = "email-from")]
            EmailFrom = 5,

            /// <summary>
            /// Enum EmailSize for value: email-size
            /// </summary>
            [EnumMember(Value = "email-size")]
            EmailSize = 6,

            /// <summary>
            /// Enum EmailSubject for value: email-subject
            /// </summary>
            [EnumMember(Value = "email-subject")]
            EmailSubject = 7,

            /// <summary>
            /// Enum EmailTo for value: email-to
            /// </summary>
            [EnumMember(Value = "email-to")]
            EmailTo = 8,

            /// <summary>
            /// Enum FileContent for value: file-content
            /// </summary>
            [EnumMember(Value = "file-content")]
            FileContent = 9,

            /// <summary>
            /// Enum FileExtension for value: file-extension
            /// </summary>
            [EnumMember(Value = "file-extension")]
            FileExtension = 10,

            /// <summary>
            /// Enum FileName for value: file-name
            /// </summary>
            [EnumMember(Value = "file-name")]
            FileName = 11,

            /// <summary>
            /// Enum FtpCommand for value: ftp-command
            /// </summary>
            [EnumMember(Value = "ftp-command")]
            FtpCommand = 12,

            /// <summary>
            /// Enum FtpCommandValue for value: ftp-command-value
            /// </summary>
            [EnumMember(Value = "ftp-command-value")]
            FtpCommandValue = 13,

            /// <summary>
            /// Enum HttpCookie for value: http-cookie
            /// </summary>
            [EnumMember(Value = "http-cookie")]
            HttpCookie = 14,

            /// <summary>
            /// Enum MimeCustomHeader for value: mime-custom-header
            /// </summary>
            [EnumMember(Value = "mime-custom-header")]
            MimeCustomHeader = 15,

            /// <summary>
            /// Enum HttpHost for value: http-host
            /// </summary>
            [EnumMember(Value = "http-host")]
            HttpHost = 16,

            /// <summary>
            /// Enum HttpReferer for value: http-referer
            /// </summary>
            [EnumMember(Value = "http-referer")]
            HttpReferer = 17,

            /// <summary>
            /// Enum HttpRequestCustomHeader for value: http-request-custom-header
            /// </summary>
            [EnumMember(Value = "http-request-custom-header")]
            HttpRequestCustomHeader = 18,

            /// <summary>
            /// Enum HttpResponseCustomHeader for value: http-response-custom-header
            /// </summary>
            [EnumMember(Value = "http-response-custom-header")]
            HttpResponseCustomHeader = 19,

            /// <summary>
            /// Enum HttpSetCookie for value: http-set-cookie
            /// </summary>
            [EnumMember(Value = "http-set-cookie")]
            HttpSetCookie = 20,

            /// <summary>
            /// Enum HttpUriContent for value: http-uri-content
            /// </summary>
            [EnumMember(Value = "http-uri-content")]
            HttpUriContent = 21,

            /// <summary>
            /// Enum HttpUrl for value: http-url
            /// </summary>
            [EnumMember(Value = "http-url")]
            HttpUrl = 22,

            /// <summary>
            /// Enum HttpUserAgent for value: http-user-agent
            /// </summary>
            [EnumMember(Value = "http-user-agent")]
            HttpUserAgent = 23,

            /// <summary>
            /// Enum WebBrowser for value: web-browser
            /// </summary>
            [EnumMember(Value = "web-browser")]
            WebBrowser = 24,

            /// <summary>
            /// Enum IpsSignatureCategoryList for value: ips-signature-category-list
            /// </summary>
            [EnumMember(Value = "ips-signature-category-list")]
            IpsSignatureCategoryList = 25,

            /// <summary>
            /// Enum IpsSignatureList for value: ips-signature-list
            /// </summary>
            [EnumMember(Value = "ips-signature-list")]
            IpsSignatureList = 26,

            /// <summary>
            /// Enum ApplicationCategoryList for value: application-category-list
            /// </summary>
            [EnumMember(Value = "application-category-list")]
            ApplicationCategoryList = 27,

            /// <summary>
            /// Enum ApplicationList for value: application-list
            /// </summary>
            [EnumMember(Value = "application-list")]
            ApplicationList = 28,

            /// <summary>
            /// Enum ApplicationSignatureList for value: application-signature-list
            /// </summary>
            [EnumMember(Value = "application-signature-list")]
            ApplicationSignatureList = 29,

            /// <summary>
            /// Enum LogEmailUser for value: log-email-user
            /// </summary>
            [EnumMember(Value = "log-email-user")]
            LogEmailUser = 30
        }


        /// <summary>
        /// Match object type.
        /// </summary>
        /// <value>Match object type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Set match object match type.
        /// </summary>
        /// <value>Set match object match type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchTypeEnum
        {
            /// <summary>
            /// Enum Exact for value: exact
            /// </summary>
            [EnumMember(Value = "exact")]
            Exact = 1,

            /// <summary>
            /// Enum Partial for value: partial
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial = 2,

            /// <summary>
            /// Enum Prefix for value: prefix
            /// </summary>
            [EnumMember(Value = "prefix")]
            Prefix = 3,

            /// <summary>
            /// Enum Regex for value: regex
            /// </summary>
            [EnumMember(Value = "regex")]
            Regex = 4,

            /// <summary>
            /// Enum Suffix for value: suffix
            /// </summary>
            [EnumMember(Value = "suffix")]
            Suffix = 5
        }


        /// <summary>
        /// Set match object match type.
        /// </summary>
        /// <value>Set match object match type.</value>
        [DataMember(Name = "match_type", EmitDefaultValue = false)]
        public MatchTypeEnum? MatchType { get; set; }
        /// <summary>
        /// Set match object input representation.
        /// </summary>
        /// <value>Set match object input representation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InputRepresentationEnum
        {
            /// <summary>
            /// Enum Alphanumeric for value: alphanumeric
            /// </summary>
            [EnumMember(Value = "alphanumeric")]
            Alphanumeric = 1,

            /// <summary>
            /// Enum Hexadecimal for value: hexadecimal
            /// </summary>
            [EnumMember(Value = "hexadecimal")]
            Hexadecimal = 2
        }


        /// <summary>
        /// Set match object input representation.
        /// </summary>
        /// <value>Set match object input representation.</value>
        [DataMember(Name = "input_representation", EmitDefaultValue = false)]
        public InputRepresentationEnum? InputRepresentation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchObject" /> class.
        /// </summary>
        /// <param name="name">Set match object name. (required).</param>
        /// <param name="type">Match object type..</param>
        /// <param name="matchType">Set match object match type..</param>
        /// <param name="enable">Enable custom settings..</param>
        /// <param name="offset">Set offset..</param>
        /// <param name="depth">Set depth..</param>
        /// <param name="minSize">Set min size..</param>
        /// <param name="maxSize">Set max size..</param>
        /// <param name="negativeMatching">Enable negative matching..</param>
        /// <param name="customHeader">Set custom header name..</param>
        /// <param name="emailSize">emailSize.</param>
        /// <param name="inputRepresentation">Set match object input representation..</param>
        /// <param name="preDefinedRegex">preDefinedRegex.</param>
        /// <param name="contentEntry">Add match object content..</param>
        /// <param name="browser">Add match object FTP browser..</param>
        /// <param name="ftpCommand">Add match object FTP command..</param>
        /// <param name="argument">Add FTP command argument..</param>
        /// <param name="ips">ips.</param>
        /// <param name="category">Add an application category..</param>
        /// <param name="application">Add an application..</param>
        /// <param name="signature">Add a signature..</param>
        public MatchObject(string name = default(string), TypeEnum? type = default(TypeEnum?), MatchTypeEnum? matchType = default(MatchTypeEnum?), bool enable = default(bool), decimal offset = default(decimal), decimal depth = default(decimal), decimal minSize = default(decimal), decimal maxSize = default(decimal), bool negativeMatching = default(bool), string customHeader = default(string), MatchObjectEmailSize emailSize = default(MatchObjectEmailSize), InputRepresentationEnum? inputRepresentation = default(InputRepresentationEnum?), MatchObjectPreDefinedRegex preDefinedRegex = default(MatchObjectPreDefinedRegex), List<EmailObjectContentEntryInner> contentEntry = default(List<EmailObjectContentEntryInner>), List<MatchObjectBrowserInner> browser = default(List<MatchObjectBrowserInner>), List<MatchObjectFtpCommandInner> ftpCommand = default(List<MatchObjectFtpCommandInner>), List<MatchObjectArgumentInner> argument = default(List<MatchObjectArgumentInner>), MatchObjectIps ips = default(MatchObjectIps), List<MatchObjectCategoryInner> category = default(List<MatchObjectCategoryInner>), List<MatchObjectApplicationInner> application = default(List<MatchObjectApplicationInner>), List<MatchObjectSignatureInner> signature = default(List<MatchObjectSignatureInner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MatchObject and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.MatchType = matchType;
            this.Enable = enable;
            this.Offset = offset;
            this.Depth = depth;
            this.MinSize = minSize;
            this.MaxSize = maxSize;
            this.NegativeMatching = negativeMatching;
            this.CustomHeader = customHeader;
            this.EmailSize = emailSize;
            this.InputRepresentation = inputRepresentation;
            this.PreDefinedRegex = preDefinedRegex;
            this.ContentEntry = contentEntry;
            this.Browser = browser;
            this.FtpCommand = ftpCommand;
            this.Argument = argument;
            this.Ips = ips;
            this.Category = category;
            this.Application = application;
            this.Signature = signature;
        }

        /// <summary>
        /// Set match object name.
        /// </summary>
        /// <value>Set match object name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Enable custom settings.
        /// </summary>
        /// <value>Enable custom settings.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set offset.
        /// </summary>
        /// <value>Set offset.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public decimal Offset { get; set; }

        /// <summary>
        /// Set depth.
        /// </summary>
        /// <value>Set depth.</value>
        [DataMember(Name = "depth", EmitDefaultValue = false)]
        public decimal Depth { get; set; }

        /// <summary>
        /// Set min size.
        /// </summary>
        /// <value>Set min size.</value>
        [DataMember(Name = "min_size", EmitDefaultValue = false)]
        public decimal MinSize { get; set; }

        /// <summary>
        /// Set max size.
        /// </summary>
        /// <value>Set max size.</value>
        [DataMember(Name = "max_size", EmitDefaultValue = false)]
        public decimal MaxSize { get; set; }

        /// <summary>
        /// Enable negative matching.
        /// </summary>
        /// <value>Enable negative matching.</value>
        [DataMember(Name = "negative_matching", EmitDefaultValue = true)]
        public bool NegativeMatching { get; set; }

        /// <summary>
        /// Set custom header name.
        /// </summary>
        /// <value>Set custom header name.</value>
        [DataMember(Name = "custom_header", EmitDefaultValue = false)]
        public string CustomHeader { get; set; }

        /// <summary>
        /// Gets or Sets EmailSize
        /// </summary>
        [DataMember(Name = "email_size", EmitDefaultValue = true)]
        public MatchObjectEmailSize EmailSize { get; set; }

        /// <summary>
        /// Gets or Sets PreDefinedRegex
        /// </summary>
        [DataMember(Name = "pre_defined_regex", EmitDefaultValue = false)]
        public MatchObjectPreDefinedRegex PreDefinedRegex { get; set; }

        /// <summary>
        /// Add match object content.
        /// </summary>
        /// <value>Add match object content.</value>
        [DataMember(Name = "content_entry", EmitDefaultValue = false)]
        public List<EmailObjectContentEntryInner> ContentEntry { get; set; }

        /// <summary>
        /// Add match object FTP browser.
        /// </summary>
        /// <value>Add match object FTP browser.</value>
        [DataMember(Name = "browser", EmitDefaultValue = false)]
        public List<MatchObjectBrowserInner> Browser { get; set; }

        /// <summary>
        /// Add match object FTP command.
        /// </summary>
        /// <value>Add match object FTP command.</value>
        [DataMember(Name = "ftp_command", EmitDefaultValue = false)]
        public List<MatchObjectFtpCommandInner> FtpCommand { get; set; }

        /// <summary>
        /// Add FTP command argument.
        /// </summary>
        /// <value>Add FTP command argument.</value>
        [DataMember(Name = "argument", EmitDefaultValue = false)]
        public List<MatchObjectArgumentInner> Argument { get; set; }

        /// <summary>
        /// Gets or Sets Ips
        /// </summary>
        [DataMember(Name = "ips", EmitDefaultValue = false)]
        public MatchObjectIps Ips { get; set; }

        /// <summary>
        /// Add an application category.
        /// </summary>
        /// <value>Add an application category.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public List<MatchObjectCategoryInner> Category { get; set; }

        /// <summary>
        /// Add an application.
        /// </summary>
        /// <value>Add an application.</value>
        [DataMember(Name = "application", EmitDefaultValue = false)]
        public List<MatchObjectApplicationInner> Application { get; set; }

        /// <summary>
        /// Add a signature.
        /// </summary>
        /// <value>Add a signature.</value>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public List<MatchObjectSignatureInner> Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  MinSize: ").Append(MinSize).Append("\n");
            sb.Append("  MaxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  NegativeMatching: ").Append(NegativeMatching).Append("\n");
            sb.Append("  CustomHeader: ").Append(CustomHeader).Append("\n");
            sb.Append("  EmailSize: ").Append(EmailSize).Append("\n");
            sb.Append("  InputRepresentation: ").Append(InputRepresentation).Append("\n");
            sb.Append("  PreDefinedRegex: ").Append(PreDefinedRegex).Append("\n");
            sb.Append("  ContentEntry: ").Append(ContentEntry).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  FtpCommand: ").Append(FtpCommand).Append("\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as MatchObject);
        }

        /// <summary>
        /// Returns true if MatchObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchObject input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Depth == input.Depth ||
                    this.Depth.Equals(input.Depth)
                ) && 
                (
                    this.MinSize == input.MinSize ||
                    this.MinSize.Equals(input.MinSize)
                ) && 
                (
                    this.MaxSize == input.MaxSize ||
                    this.MaxSize.Equals(input.MaxSize)
                ) && 
                (
                    this.NegativeMatching == input.NegativeMatching ||
                    this.NegativeMatching.Equals(input.NegativeMatching)
                ) && 
                (
                    this.CustomHeader == input.CustomHeader ||
                    (this.CustomHeader != null &&
                    this.CustomHeader.Equals(input.CustomHeader))
                ) && 
                (
                    this.EmailSize == input.EmailSize ||
                    (this.EmailSize != null &&
                    this.EmailSize.Equals(input.EmailSize))
                ) && 
                (
                    this.InputRepresentation == input.InputRepresentation ||
                    this.InputRepresentation.Equals(input.InputRepresentation)
                ) && 
                (
                    this.PreDefinedRegex == input.PreDefinedRegex ||
                    (this.PreDefinedRegex != null &&
                    this.PreDefinedRegex.Equals(input.PreDefinedRegex))
                ) && 
                (
                    this.ContentEntry == input.ContentEntry ||
                    this.ContentEntry != null &&
                    input.ContentEntry != null &&
                    this.ContentEntry.SequenceEqual(input.ContentEntry)
                ) && 
                (
                    this.Browser == input.Browser ||
                    this.Browser != null &&
                    input.Browser != null &&
                    this.Browser.SequenceEqual(input.Browser)
                ) && 
                (
                    this.FtpCommand == input.FtpCommand ||
                    this.FtpCommand != null &&
                    input.FtpCommand != null &&
                    this.FtpCommand.SequenceEqual(input.FtpCommand)
                ) && 
                (
                    this.Argument == input.Argument ||
                    this.Argument != null &&
                    input.Argument != null &&
                    this.Argument.SequenceEqual(input.Argument)
                ) && 
                (
                    this.Ips == input.Ips ||
                    (this.Ips != null &&
                    this.Ips.Equals(input.Ips))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
                ) && 
                (
                    this.Application == input.Application ||
                    this.Application != null &&
                    input.Application != null &&
                    this.Application.SequenceEqual(input.Application)
                ) && 
                (
                    this.Signature == input.Signature ||
                    this.Signature != null &&
                    input.Signature != null &&
                    this.Signature.SequenceEqual(input.Signature)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.Offset.GetHashCode();
                hashCode = (hashCode * 59) + this.Depth.GetHashCode();
                hashCode = (hashCode * 59) + this.MinSize.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxSize.GetHashCode();
                hashCode = (hashCode * 59) + this.NegativeMatching.GetHashCode();
                if (this.CustomHeader != null)
                {
                    hashCode = (hashCode * 59) + this.CustomHeader.GetHashCode();
                }
                if (this.EmailSize != null)
                {
                    hashCode = (hashCode * 59) + this.EmailSize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InputRepresentation.GetHashCode();
                if (this.PreDefinedRegex != null)
                {
                    hashCode = (hashCode * 59) + this.PreDefinedRegex.GetHashCode();
                }
                if (this.ContentEntry != null)
                {
                    hashCode = (hashCode * 59) + this.ContentEntry.GetHashCode();
                }
                if (this.Browser != null)
                {
                    hashCode = (hashCode * 59) + this.Browser.GetHashCode();
                }
                if (this.FtpCommand != null)
                {
                    hashCode = (hashCode * 59) + this.FtpCommand.GetHashCode();
                }
                if (this.Argument != null)
                {
                    hashCode = (hashCode * 59) + this.Argument.GetHashCode();
                }
                if (this.Ips != null)
                {
                    hashCode = (hashCode * 59) + this.Ips.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Application != null)
                {
                    hashCode = (hashCode * 59) + this.Application.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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