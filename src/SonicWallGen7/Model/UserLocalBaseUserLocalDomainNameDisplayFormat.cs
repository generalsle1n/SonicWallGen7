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
using System.Reflection;

namespace SonicWallGen7.Model
{
    /// <summary>
    /// Set display format for domain user/group names
    /// </summary>
    [JsonConverter(typeof(UserLocalBaseUserLocalDomainNameDisplayFormatJsonConverter))]
    [DataContract(Name = "user_local_base_user_local_domain_name_display_format")]
    public partial class UserLocalBaseUserLocalDomainNameDisplayFormat : AbstractOpenAPISchema, IEquatable<UserLocalBaseUserLocalDomainNameDisplayFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalBaseUserLocalDomainNameDisplayFormat" /> class
        /// with the <see cref="UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain.</param>
        public UserLocalBaseUserLocalDomainNameDisplayFormat(UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalBaseUserLocalDomainNameDisplayFormat" /> class
        /// with the <see cref="UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName.</param>
        public UserLocalBaseUserLocalDomainNameDisplayFormat(UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalBaseUserLocalDomainNameDisplayFormat" /> class
        /// with the <see cref="UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain.</param>
        public UserLocalBaseUserLocalDomainNameDisplayFormat(UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalBaseUserLocalDomainNameDisplayFormat" /> class
        /// with the <see cref="UserLocalBaseLocalDomainNameDisplayFormatAutomatic" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalBaseLocalDomainNameDisplayFormatAutomatic.</param>
        public UserLocalBaseUserLocalDomainNameDisplayFormat(UserLocalBaseLocalDomainNameDisplayFormatAutomatic actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(UserLocalBaseLocalDomainNameDisplayFormatAutomatic))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserLocalBaseLocalDomainNameDisplayFormatAutomatic, UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName, UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain, UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain`. If the actual instance is not `UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain</returns>
        public UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain GetUserLocalBaseLocalDomainNameDisplayFormatNameAtDomain()
        {
            return (UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName`. If the actual instance is not `UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName</returns>
        public UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName GetUserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName()
        {
            return (UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain`. If the actual instance is not `UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain</returns>
        public UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain GetUserLocalBaseLocalDomainNameDisplayFormatNameDotDomain()
        {
            return (UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserLocalBaseLocalDomainNameDisplayFormatAutomatic`. If the actual instance is not `UserLocalBaseLocalDomainNameDisplayFormatAutomatic`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalBaseLocalDomainNameDisplayFormatAutomatic</returns>
        public UserLocalBaseLocalDomainNameDisplayFormatAutomatic GetUserLocalBaseLocalDomainNameDisplayFormatAutomatic()
        {
            return (UserLocalBaseLocalDomainNameDisplayFormatAutomatic)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLocalBaseUserLocalDomainNameDisplayFormat {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, UserLocalBaseUserLocalDomainNameDisplayFormat.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserLocalBaseUserLocalDomainNameDisplayFormat
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserLocalBaseUserLocalDomainNameDisplayFormat</returns>
        public static UserLocalBaseUserLocalDomainNameDisplayFormat FromJson(string jsonString)
        {
            UserLocalBaseUserLocalDomainNameDisplayFormat newUserLocalBaseUserLocalDomainNameDisplayFormat = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserLocalBaseUserLocalDomainNameDisplayFormat;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalBaseLocalDomainNameDisplayFormatAutomatic).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatAutomatic>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.SerializerSettings));
                }
                else
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatAutomatic>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalBaseLocalDomainNameDisplayFormatAutomatic");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalBaseLocalDomainNameDisplayFormatAutomatic: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.SerializerSettings));
                }
                else
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalBaseLocalDomainNameDisplayFormatDomainBackslashName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.SerializerSettings));
                }
                else
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalBaseLocalDomainNameDisplayFormatNameAtDomain: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.SerializerSettings));
                }
                else
                {
                    newUserLocalBaseUserLocalDomainNameDisplayFormat = new UserLocalBaseUserLocalDomainNameDisplayFormat(JsonConvert.DeserializeObject<UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain>(jsonString, UserLocalBaseUserLocalDomainNameDisplayFormat.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalBaseLocalDomainNameDisplayFormatNameDotDomain: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newUserLocalBaseUserLocalDomainNameDisplayFormat;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserLocalBaseUserLocalDomainNameDisplayFormat);
        }

        /// <summary>
        /// Returns true if UserLocalBaseUserLocalDomainNameDisplayFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLocalBaseUserLocalDomainNameDisplayFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocalBaseUserLocalDomainNameDisplayFormat input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for UserLocalBaseUserLocalDomainNameDisplayFormat
    /// </summary>
    public class UserLocalBaseUserLocalDomainNameDisplayFormatJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserLocalBaseUserLocalDomainNameDisplayFormat).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return UserLocalBaseUserLocalDomainNameDisplayFormat.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}