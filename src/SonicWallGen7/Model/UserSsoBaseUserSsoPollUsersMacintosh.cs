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
    /// Set polling method for macintosh users.
    /// </summary>
    [JsonConverter(typeof(UserSsoBaseUserSsoPollUsersMacintoshJsonConverter))]
    [DataContract(Name = "user_sso_base_user_sso_poll_users_macintosh")]
    public partial class UserSsoBaseUserSsoPollUsersMacintosh : AbstractOpenAPISchema, IEquatable<UserSsoBaseUserSsoPollUsersMacintosh>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersMacintosh" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersMacintoshAgent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersMacintoshAgent.</param>
        public UserSsoBaseUserSsoPollUsersMacintosh(UserSsoBaseSsoPollUsersMacintoshAgent actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersMacintosh" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm.</param>
        public UserSsoBaseUserSsoPollUsersMacintosh(UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoPollUsersMacintosh" /> class
        /// with the <see cref="UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication.</param>
        public UserSsoBaseUserSsoPollUsersMacintosh(UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication actualInstance)
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
                if (value.GetType() == typeof(UserSsoBaseSsoPollUsersMacintoshAgent))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserSsoBaseSsoPollUsersMacintoshAgent, UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication, UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersMacintoshAgent`. If the actual instance is not `UserSsoBaseSsoPollUsersMacintoshAgent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersMacintoshAgent</returns>
        public UserSsoBaseSsoPollUsersMacintoshAgent GetUserSsoBaseSsoPollUsersMacintoshAgent()
        {
            return (UserSsoBaseSsoPollUsersMacintoshAgent)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm`. If the actual instance is not `UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm</returns>
        public UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm GetUserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm()
        {
            return (UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication`. If the actual instance is not `UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication</returns>
        public UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication GetUserSsoBaseSsoPollUsersMacintoshBypassReAuthentication()
        {
            return (UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSsoBaseUserSsoPollUsersMacintosh {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UserSsoBaseUserSsoPollUsersMacintosh.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserSsoBaseUserSsoPollUsersMacintosh
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserSsoBaseUserSsoPollUsersMacintosh</returns>
        public static UserSsoBaseUserSsoPollUsersMacintosh FromJson(string jsonString)
        {
            UserSsoBaseUserSsoPollUsersMacintosh newUserSsoBaseUserSsoPollUsersMacintosh = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserSsoBaseUserSsoPollUsersMacintosh;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersMacintoshAgent).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshAgent>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshAgent>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersMacintoshAgent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersMacintoshAgent: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersMacintoshBypassReAuthentication: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm).GetProperty("AdditionalProperties") == null)
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.SerializerSettings));
                }
                else
                {
                    newUserSsoBaseUserSsoPollUsersMacintosh = new UserSsoBaseUserSsoPollUsersMacintosh(JsonConvert.DeserializeObject<UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm>(jsonString, UserSsoBaseUserSsoPollUsersMacintosh.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserSsoBaseSsoPollUsersMacintoshReAuthenticationNtlm: {1}", jsonString, exception.ToString()));
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
            return newUserSsoBaseUserSsoPollUsersMacintosh;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserSsoBaseUserSsoPollUsersMacintosh);
        }

        /// <summary>
        /// Returns true if UserSsoBaseUserSsoPollUsersMacintosh instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoBaseUserSsoPollUsersMacintosh to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoBaseUserSsoPollUsersMacintosh input)
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
    /// Custom JSON converter for UserSsoBaseUserSsoPollUsersMacintosh
    /// </summary>
    public class UserSsoBaseUserSsoPollUsersMacintoshJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserSsoBaseUserSsoPollUsersMacintosh).GetMethod("ToJson").Invoke(value, null)));
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
                return UserSsoBaseUserSsoPollUsersMacintosh.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
