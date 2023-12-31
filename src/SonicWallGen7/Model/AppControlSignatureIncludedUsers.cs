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
    /// Included users/groups.
    /// </summary>
    [JsonConverter(typeof(AppControlSignatureIncludedUsersJsonConverter))]
    [DataContract(Name = "app_control_signature_included_users")]
    public partial class AppControlSignatureIncludedUsers : AbstractOpenAPISchema, IEquatable<AppControlSignatureIncludedUsers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersApp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersApp.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersApp actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersAll.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersGuests.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersAdministrator.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersName.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureIncludedUsers" /> class
        /// with the <see cref="AppControlSignatureIncludedUsersGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureIncludedUsersGroup.</param>
        public AppControlSignatureIncludedUsers(AppControlSignatureIncludedUsersGroup actualInstance)
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
                if (value.GetType() == typeof(AppControlSignatureIncludedUsersAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureIncludedUsersAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureIncludedUsersApp))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureIncludedUsersGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureIncludedUsersGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureIncludedUsersName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppControlSignatureIncludedUsersAdministrator, AppControlSignatureIncludedUsersAll, AppControlSignatureIncludedUsersApp, AppControlSignatureIncludedUsersGroup, AppControlSignatureIncludedUsersGuests, AppControlSignatureIncludedUsersName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersApp`. If the actual instance is not `AppControlSignatureIncludedUsersApp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersApp</returns>
        public AppControlSignatureIncludedUsersApp GetAppControlSignatureIncludedUsersApp()
        {
            return (AppControlSignatureIncludedUsersApp)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersAll`. If the actual instance is not `AppControlSignatureIncludedUsersAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersAll</returns>
        public AppControlSignatureIncludedUsersAll GetAppControlSignatureIncludedUsersAll()
        {
            return (AppControlSignatureIncludedUsersAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersGuests`. If the actual instance is not `AppControlSignatureIncludedUsersGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersGuests</returns>
        public AppControlSignatureIncludedUsersGuests GetAppControlSignatureIncludedUsersGuests()
        {
            return (AppControlSignatureIncludedUsersGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersAdministrator`. If the actual instance is not `AppControlSignatureIncludedUsersAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersAdministrator</returns>
        public AppControlSignatureIncludedUsersAdministrator GetAppControlSignatureIncludedUsersAdministrator()
        {
            return (AppControlSignatureIncludedUsersAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersName`. If the actual instance is not `AppControlSignatureIncludedUsersName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersName</returns>
        public AppControlSignatureIncludedUsersName GetAppControlSignatureIncludedUsersName()
        {
            return (AppControlSignatureIncludedUsersName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureIncludedUsersGroup`. If the actual instance is not `AppControlSignatureIncludedUsersGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureIncludedUsersGroup</returns>
        public AppControlSignatureIncludedUsersGroup GetAppControlSignatureIncludedUsersGroup()
        {
            return (AppControlSignatureIncludedUsersGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppControlSignatureIncludedUsers {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppControlSignatureIncludedUsers.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppControlSignatureIncludedUsers
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppControlSignatureIncludedUsers</returns>
        public static AppControlSignatureIncludedUsers FromJson(string jsonString)
        {
            AppControlSignatureIncludedUsers newAppControlSignatureIncludedUsers = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppControlSignatureIncludedUsers;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersAdministrator>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersAdministrator>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersAll).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersAll>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersAll>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersApp).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersApp>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersApp>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersApp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersApp: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersGroup>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersGroup>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersGuests).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersGuests>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersGuests>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureIncludedUsersName).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersName>(jsonString, AppControlSignatureIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureIncludedUsers = new AppControlSignatureIncludedUsers(JsonConvert.DeserializeObject<AppControlSignatureIncludedUsersName>(jsonString, AppControlSignatureIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureIncludedUsersName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureIncludedUsersName: {1}", jsonString, exception.ToString()));
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
            return newAppControlSignatureIncludedUsers;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppControlSignatureIncludedUsers);
        }

        /// <summary>
        /// Returns true if AppControlSignatureIncludedUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of AppControlSignatureIncludedUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppControlSignatureIncludedUsers input)
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
    /// Custom JSON converter for AppControlSignatureIncludedUsers
    /// </summary>
    public class AppControlSignatureIncludedUsersJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppControlSignatureIncludedUsers).GetMethod("ToJson").Invoke(value, null)));
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
                return AppControlSignatureIncludedUsers.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
