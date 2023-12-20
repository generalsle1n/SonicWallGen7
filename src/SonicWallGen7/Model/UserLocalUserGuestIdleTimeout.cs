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
    /// Set the idle timeout for guest services.
    /// </summary>
    [JsonConverter(typeof(UserLocalUserGuestIdleTimeoutJsonConverter))]
    [DataContract(Name = "user_local_user_guest_idle_timeout")]
    public partial class UserLocalUserGuestIdleTimeout : AbstractOpenAPISchema, IEquatable<UserLocalUserGuestIdleTimeout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalUserGuestIdleTimeout" /> class
        /// with the <see cref="UserLocalUserGuestIdleTimeoutMinutes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalUserGuestIdleTimeoutMinutes.</param>
        public UserLocalUserGuestIdleTimeout(UserLocalUserGuestIdleTimeoutMinutes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalUserGuestIdleTimeout" /> class
        /// with the <see cref="UserLocalUserGuestIdleTimeoutHours" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalUserGuestIdleTimeoutHours.</param>
        public UserLocalUserGuestIdleTimeout(UserLocalUserGuestIdleTimeoutHours actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalUserGuestIdleTimeout" /> class
        /// with the <see cref="UserLocalUserGuestIdleTimeoutDays" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserLocalUserGuestIdleTimeoutDays.</param>
        public UserLocalUserGuestIdleTimeout(UserLocalUserGuestIdleTimeoutDays actualInstance)
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
                if (value.GetType() == typeof(UserLocalUserGuestIdleTimeoutDays))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserLocalUserGuestIdleTimeoutHours))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserLocalUserGuestIdleTimeoutMinutes))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserLocalUserGuestIdleTimeoutDays, UserLocalUserGuestIdleTimeoutHours, UserLocalUserGuestIdleTimeoutMinutes");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserLocalUserGuestIdleTimeoutMinutes`. If the actual instance is not `UserLocalUserGuestIdleTimeoutMinutes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalUserGuestIdleTimeoutMinutes</returns>
        public UserLocalUserGuestIdleTimeoutMinutes GetUserLocalUserGuestIdleTimeoutMinutes()
        {
            return (UserLocalUserGuestIdleTimeoutMinutes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserLocalUserGuestIdleTimeoutHours`. If the actual instance is not `UserLocalUserGuestIdleTimeoutHours`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalUserGuestIdleTimeoutHours</returns>
        public UserLocalUserGuestIdleTimeoutHours GetUserLocalUserGuestIdleTimeoutHours()
        {
            return (UserLocalUserGuestIdleTimeoutHours)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserLocalUserGuestIdleTimeoutDays`. If the actual instance is not `UserLocalUserGuestIdleTimeoutDays`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserLocalUserGuestIdleTimeoutDays</returns>
        public UserLocalUserGuestIdleTimeoutDays GetUserLocalUserGuestIdleTimeoutDays()
        {
            return (UserLocalUserGuestIdleTimeoutDays)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLocalUserGuestIdleTimeout {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UserLocalUserGuestIdleTimeout.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserLocalUserGuestIdleTimeout
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserLocalUserGuestIdleTimeout</returns>
        public static UserLocalUserGuestIdleTimeout FromJson(string jsonString)
        {
            UserLocalUserGuestIdleTimeout newUserLocalUserGuestIdleTimeout = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserLocalUserGuestIdleTimeout;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalUserGuestIdleTimeoutDays).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutDays>(jsonString, UserLocalUserGuestIdleTimeout.SerializerSettings));
                }
                else
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutDays>(jsonString, UserLocalUserGuestIdleTimeout.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalUserGuestIdleTimeoutDays");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalUserGuestIdleTimeoutDays: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalUserGuestIdleTimeoutHours).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutHours>(jsonString, UserLocalUserGuestIdleTimeout.SerializerSettings));
                }
                else
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutHours>(jsonString, UserLocalUserGuestIdleTimeout.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalUserGuestIdleTimeoutHours");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalUserGuestIdleTimeoutHours: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserLocalUserGuestIdleTimeoutMinutes).GetProperty("AdditionalProperties") == null)
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutMinutes>(jsonString, UserLocalUserGuestIdleTimeout.SerializerSettings));
                }
                else
                {
                    newUserLocalUserGuestIdleTimeout = new UserLocalUserGuestIdleTimeout(JsonConvert.DeserializeObject<UserLocalUserGuestIdleTimeoutMinutes>(jsonString, UserLocalUserGuestIdleTimeout.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserLocalUserGuestIdleTimeoutMinutes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserLocalUserGuestIdleTimeoutMinutes: {1}", jsonString, exception.ToString()));
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
            return newUserLocalUserGuestIdleTimeout;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserLocalUserGuestIdleTimeout);
        }

        /// <summary>
        /// Returns true if UserLocalUserGuestIdleTimeout instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLocalUserGuestIdleTimeout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocalUserGuestIdleTimeout input)
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
    /// Custom JSON converter for UserLocalUserGuestIdleTimeout
    /// </summary>
    public class UserLocalUserGuestIdleTimeoutJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserLocalUserGuestIdleTimeout).GetMethod("ToJson").Invoke(value, null)));
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
                return UserLocalUserGuestIdleTimeout.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
