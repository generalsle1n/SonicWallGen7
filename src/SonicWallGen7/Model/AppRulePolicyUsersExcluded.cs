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
    /// Set excluded users.
    /// </summary>
    [JsonConverter(typeof(AppRulePolicyUsersExcludedJsonConverter))]
    [DataContract(Name = "app_rule_policy_users_excluded")]
    public partial class AppRulePolicyUsersExcluded : AbstractOpenAPISchema, IEquatable<AppRulePolicyUsersExcluded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyUsersExcluded" /> class
        /// with the <see cref="AppRulePolicyUsersExcludedAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppRulePolicyUsersExcludedAll.</param>
        public AppRulePolicyUsersExcluded(AppRulePolicyUsersExcludedAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyUsersExcluded" /> class
        /// with the <see cref="AppRulePolicyUsersExcludedGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppRulePolicyUsersExcludedGuests.</param>
        public AppRulePolicyUsersExcluded(AppRulePolicyUsersExcludedGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyUsersExcluded" /> class
        /// with the <see cref="AppRulePolicyUsersExcludedAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppRulePolicyUsersExcludedAdministrator.</param>
        public AppRulePolicyUsersExcluded(AppRulePolicyUsersExcludedAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyUsersExcluded" /> class
        /// with the <see cref="AppRulePolicyUsersExcludedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppRulePolicyUsersExcludedName.</param>
        public AppRulePolicyUsersExcluded(AppRulePolicyUsersExcludedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyUsersExcluded" /> class
        /// with the <see cref="AppRulePolicyUsersExcludedGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppRulePolicyUsersExcludedGroup.</param>
        public AppRulePolicyUsersExcluded(AppRulePolicyUsersExcludedGroup actualInstance)
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
                if (value.GetType() == typeof(AppRulePolicyUsersExcludedAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppRulePolicyUsersExcludedAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppRulePolicyUsersExcludedGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppRulePolicyUsersExcludedGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppRulePolicyUsersExcludedName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppRulePolicyUsersExcludedAdministrator, AppRulePolicyUsersExcludedAll, AppRulePolicyUsersExcludedGroup, AppRulePolicyUsersExcludedGuests, AppRulePolicyUsersExcludedName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppRulePolicyUsersExcludedAll`. If the actual instance is not `AppRulePolicyUsersExcludedAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppRulePolicyUsersExcludedAll</returns>
        public AppRulePolicyUsersExcludedAll GetAppRulePolicyUsersExcludedAll()
        {
            return (AppRulePolicyUsersExcludedAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppRulePolicyUsersExcludedGuests`. If the actual instance is not `AppRulePolicyUsersExcludedGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppRulePolicyUsersExcludedGuests</returns>
        public AppRulePolicyUsersExcludedGuests GetAppRulePolicyUsersExcludedGuests()
        {
            return (AppRulePolicyUsersExcludedGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppRulePolicyUsersExcludedAdministrator`. If the actual instance is not `AppRulePolicyUsersExcludedAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppRulePolicyUsersExcludedAdministrator</returns>
        public AppRulePolicyUsersExcludedAdministrator GetAppRulePolicyUsersExcludedAdministrator()
        {
            return (AppRulePolicyUsersExcludedAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppRulePolicyUsersExcludedName`. If the actual instance is not `AppRulePolicyUsersExcludedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppRulePolicyUsersExcludedName</returns>
        public AppRulePolicyUsersExcludedName GetAppRulePolicyUsersExcludedName()
        {
            return (AppRulePolicyUsersExcludedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppRulePolicyUsersExcludedGroup`. If the actual instance is not `AppRulePolicyUsersExcludedGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppRulePolicyUsersExcludedGroup</returns>
        public AppRulePolicyUsersExcludedGroup GetAppRulePolicyUsersExcludedGroup()
        {
            return (AppRulePolicyUsersExcludedGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppRulePolicyUsersExcluded {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppRulePolicyUsersExcluded.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppRulePolicyUsersExcluded
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppRulePolicyUsersExcluded</returns>
        public static AppRulePolicyUsersExcluded FromJson(string jsonString)
        {
            AppRulePolicyUsersExcluded newAppRulePolicyUsersExcluded = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppRulePolicyUsersExcluded;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppRulePolicyUsersExcludedAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedAdministrator>(jsonString, AppRulePolicyUsersExcluded.SerializerSettings));
                }
                else
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedAdministrator>(jsonString, AppRulePolicyUsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppRulePolicyUsersExcludedAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppRulePolicyUsersExcludedAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppRulePolicyUsersExcludedAll).GetProperty("AdditionalProperties") == null)
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedAll>(jsonString, AppRulePolicyUsersExcluded.SerializerSettings));
                }
                else
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedAll>(jsonString, AppRulePolicyUsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppRulePolicyUsersExcludedAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppRulePolicyUsersExcludedAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppRulePolicyUsersExcludedGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedGroup>(jsonString, AppRulePolicyUsersExcluded.SerializerSettings));
                }
                else
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedGroup>(jsonString, AppRulePolicyUsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppRulePolicyUsersExcludedGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppRulePolicyUsersExcludedGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppRulePolicyUsersExcludedGuests).GetProperty("AdditionalProperties") == null)
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedGuests>(jsonString, AppRulePolicyUsersExcluded.SerializerSettings));
                }
                else
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedGuests>(jsonString, AppRulePolicyUsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppRulePolicyUsersExcludedGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppRulePolicyUsersExcludedGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppRulePolicyUsersExcludedName).GetProperty("AdditionalProperties") == null)
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedName>(jsonString, AppRulePolicyUsersExcluded.SerializerSettings));
                }
                else
                {
                    newAppRulePolicyUsersExcluded = new AppRulePolicyUsersExcluded(JsonConvert.DeserializeObject<AppRulePolicyUsersExcludedName>(jsonString, AppRulePolicyUsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppRulePolicyUsersExcludedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppRulePolicyUsersExcludedName: {1}", jsonString, exception.ToString()));
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
            return newAppRulePolicyUsersExcluded;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppRulePolicyUsersExcluded);
        }

        /// <summary>
        /// Returns true if AppRulePolicyUsersExcluded instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRulePolicyUsersExcluded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRulePolicyUsersExcluded input)
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
    /// Custom JSON converter for AppRulePolicyUsersExcluded
    /// </summary>
    public class AppRulePolicyUsersExcludedJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppRulePolicyUsersExcluded).GetMethod("ToJson").Invoke(value, null)));
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
                return AppRulePolicyUsersExcluded.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
