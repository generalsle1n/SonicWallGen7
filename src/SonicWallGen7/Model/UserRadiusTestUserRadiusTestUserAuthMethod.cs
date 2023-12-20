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
    /// select a authentication method.
    /// </summary>
    [JsonConverter(typeof(UserRadiusTestUserRadiusTestUserAuthMethodJsonConverter))]
    [DataContract(Name = "user_radius_test_user_radius_test_user_auth_method")]
    public partial class UserRadiusTestUserRadiusTestUserAuthMethod : AbstractOpenAPISchema, IEquatable<UserRadiusTestUserRadiusTestUserAuthMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRadiusTestUserRadiusTestUserAuthMethod" /> class
        /// with the <see cref="UserRadiusTestRadiusTestUserAuthMethodChap" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserRadiusTestRadiusTestUserAuthMethodChap.</param>
        public UserRadiusTestUserRadiusTestUserAuthMethod(UserRadiusTestRadiusTestUserAuthMethodChap actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRadiusTestUserRadiusTestUserAuthMethod" /> class
        /// with the <see cref="UserRadiusTestRadiusTestUserAuthMethodMschap" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserRadiusTestRadiusTestUserAuthMethodMschap.</param>
        public UserRadiusTestUserRadiusTestUserAuthMethod(UserRadiusTestRadiusTestUserAuthMethodMschap actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRadiusTestUserRadiusTestUserAuthMethod" /> class
        /// with the <see cref="UserRadiusTestRadiusTestUserAuthMethodMschapv2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UserRadiusTestRadiusTestUserAuthMethodMschapv2.</param>
        public UserRadiusTestUserRadiusTestUserAuthMethod(UserRadiusTestRadiusTestUserAuthMethodMschapv2 actualInstance)
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
                if (value.GetType() == typeof(UserRadiusTestRadiusTestUserAuthMethodChap))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserRadiusTestRadiusTestUserAuthMethodMschap))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UserRadiusTestRadiusTestUserAuthMethodMschapv2))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: UserRadiusTestRadiusTestUserAuthMethodChap, UserRadiusTestRadiusTestUserAuthMethodMschap, UserRadiusTestRadiusTestUserAuthMethodMschapv2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UserRadiusTestRadiusTestUserAuthMethodChap`. If the actual instance is not `UserRadiusTestRadiusTestUserAuthMethodChap`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserRadiusTestRadiusTestUserAuthMethodChap</returns>
        public UserRadiusTestRadiusTestUserAuthMethodChap GetUserRadiusTestRadiusTestUserAuthMethodChap()
        {
            return (UserRadiusTestRadiusTestUserAuthMethodChap)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserRadiusTestRadiusTestUserAuthMethodMschap`. If the actual instance is not `UserRadiusTestRadiusTestUserAuthMethodMschap`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserRadiusTestRadiusTestUserAuthMethodMschap</returns>
        public UserRadiusTestRadiusTestUserAuthMethodMschap GetUserRadiusTestRadiusTestUserAuthMethodMschap()
        {
            return (UserRadiusTestRadiusTestUserAuthMethodMschap)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UserRadiusTestRadiusTestUserAuthMethodMschapv2`. If the actual instance is not `UserRadiusTestRadiusTestUserAuthMethodMschapv2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UserRadiusTestRadiusTestUserAuthMethodMschapv2</returns>
        public UserRadiusTestRadiusTestUserAuthMethodMschapv2 GetUserRadiusTestRadiusTestUserAuthMethodMschapv2()
        {
            return (UserRadiusTestRadiusTestUserAuthMethodMschapv2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRadiusTestUserRadiusTestUserAuthMethod {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, UserRadiusTestUserRadiusTestUserAuthMethod.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UserRadiusTestUserRadiusTestUserAuthMethod
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UserRadiusTestUserRadiusTestUserAuthMethod</returns>
        public static UserRadiusTestUserRadiusTestUserAuthMethod FromJson(string jsonString)
        {
            UserRadiusTestUserRadiusTestUserAuthMethod newUserRadiusTestUserRadiusTestUserAuthMethod = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUserRadiusTestUserRadiusTestUserAuthMethod;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserRadiusTestRadiusTestUserAuthMethodChap).GetProperty("AdditionalProperties") == null)
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodChap>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.SerializerSettings));
                }
                else
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodChap>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserRadiusTestRadiusTestUserAuthMethodChap");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserRadiusTestRadiusTestUserAuthMethodChap: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserRadiusTestRadiusTestUserAuthMethodMschap).GetProperty("AdditionalProperties") == null)
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodMschap>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.SerializerSettings));
                }
                else
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodMschap>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserRadiusTestRadiusTestUserAuthMethodMschap");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserRadiusTestRadiusTestUserAuthMethodMschap: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UserRadiusTestRadiusTestUserAuthMethodMschapv2).GetProperty("AdditionalProperties") == null)
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodMschapv2>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.SerializerSettings));
                }
                else
                {
                    newUserRadiusTestUserRadiusTestUserAuthMethod = new UserRadiusTestUserRadiusTestUserAuthMethod(JsonConvert.DeserializeObject<UserRadiusTestRadiusTestUserAuthMethodMschapv2>(jsonString, UserRadiusTestUserRadiusTestUserAuthMethod.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UserRadiusTestRadiusTestUserAuthMethodMschapv2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UserRadiusTestRadiusTestUserAuthMethodMschapv2: {1}", jsonString, exception.ToString()));
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
            return newUserRadiusTestUserRadiusTestUserAuthMethod;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserRadiusTestUserRadiusTestUserAuthMethod);
        }

        /// <summary>
        /// Returns true if UserRadiusTestUserRadiusTestUserAuthMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRadiusTestUserRadiusTestUserAuthMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRadiusTestUserRadiusTestUserAuthMethod input)
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
    /// Custom JSON converter for UserRadiusTestUserRadiusTestUserAuthMethod
    /// </summary>
    public class UserRadiusTestUserRadiusTestUserAuthMethodJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UserRadiusTestUserRadiusTestUserAuthMethod).GetMethod("ToJson").Invoke(value, null)));
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
                return UserRadiusTestUserRadiusTestUserAuthMethod.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
