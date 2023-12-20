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
    /// Set polling method for linux users.
    /// </summary>
    [JsonConverter(typeof(UserSsoBaseUserSsoPollUsersLinuxJsonConverter))]
    [DataContract(Name = "user_sso_base_user_sso_poll_users_linux")]
    public partial class UserSsoBaseUserSsoPollUsersLinux : AbstractOpenAPISchema, IEquatable<UserSsoBaseUserSsoPollUsersLinux>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersLinux" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersLinuxAgent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersLinuxAgent.</param>
        public UserSsoBaseUserSsoPollUsersLinux(UserSsoBaseSsoPollUsersLinuxAgent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersLinux" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm.</param>
        public UserSsoBaseUserSsoPollUsersLinux(UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersLinux" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersLinuxBypassReAuthentication" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersLinuxBypassReAuthentication.</param>
        public UserSsoBaseUserSsoPollUsersLinux(UserSsoBaseSsoPollUsersLinuxBypassReAuthentication actualInstance)
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
                if (value.GetType() == typeof(UserSsoBaseSsoPollUsersLinuxAgent))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserSsoBaseSsoPollUsersLinuxBypassReAuthentication))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserSsoBaseSsoPollUsersLinuxAgent, UserSsoBaseSsoPollUsersLinuxBypassReAuthentication, UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersLinuxAgent`. If the actual instance is not `UserSsoBaseSsoPollUsersLinuxAgent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersLinuxAgent</returns>
        public UserSsoBaseSsoPollUsersLinuxAgent GetUserSsoBaseSsoPollUsersLinuxAgent()
        {
            return (UserSsoBaseSsoPollUsersLinuxAgent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm`. If the actual instance is not `UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm</returns>
        public UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm GetUserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm()
        {
            return (UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersLinuxBypassReAuthentication`. If the actual instance is not `UserSsoBaseSsoPollUsersLinuxBypassReAuthentication`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersLinuxBypassReAuthentication</returns>
        public UserSsoBaseSsoPollUsersLinuxBypassReAuthentication GetUserSsoBaseSsoPollUsersLinuxBypassReAuthentication()
        {
            return (UserSsoBaseSsoPollUsersLinuxBypassReAuthentication)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSsoBaseUserSsoPollUsersLinux {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UserSsoBaseUserSsoPollUsersLinux.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserSsoBaseUserSsoPollUsersLinux
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserSsoBaseUserSsoPollUsersLinux</returns>
        public static UserSsoBaseUserSsoPollUsersLinux FromJson(string jsonString)
        {
            UserSsoBaseUserSsoPollUsersLinux newUserSsoBaseUserSsoPollUsersLinux = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserSsoBaseUserSsoPollUsersLinux;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersLinuxAgent).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxAgent>(jsonString, UserSsoBaseUserSsoPollUsersLinux.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxAgent>(jsonString, UserSsoBaseUserSsoPollUsersLinux.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersLinuxAgent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersLinuxAgent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersLinuxBypassReAuthentication).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxBypassReAuthentication>(jsonString, UserSsoBaseUserSsoPollUsersLinux.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxBypassReAuthentication>(jsonString, UserSsoBaseUserSsoPollUsersLinux.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersLinuxBypassReAuthentication");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersLinuxBypassReAuthentication: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm>(jsonString, UserSsoBaseUserSsoPollUsersLinux.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersLinux = new UserSsoBaseUserSsoPollUsersLinux(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm>(jsonString, UserSsoBaseUserSsoPollUsersLinux.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersLinuxReAuthenticationNtlm: {1}", jsonString, exception.ToString()));
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
            return newUserSsoBaseUserSsoPollUsersLinux;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserSsoBaseUserSsoPollUsersLinux);
        }

        /// <summary>
        /// Returns true if UserSsoBaseUserSsoPollUsersLinux instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoBaseUserSsoPollUsersLinux to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoBaseUserSsoPollUsersLinux input)
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
    /// Custom JSON converter for UserSsoBaseUserSsoPollUsersLinux
    /// </summary>
    public class UserSsoBaseUserSsoPollUsersLinuxJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserSsoBaseUserSsoPollUsersLinux).GetMethod("ToJson").Invoke(value, null)));
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
                return UserSsoBaseUserSsoPollUsersLinux.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
