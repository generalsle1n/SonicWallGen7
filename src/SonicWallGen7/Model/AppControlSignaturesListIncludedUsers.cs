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
    [JsonConverter(typeof(AppControlSignaturesListIncludedUsersJsonConverter))]
    [DataContract(Name = "app_control_signatures_list_included_users")]
    public partial class AppControlSignaturesListIncludedUsers : AbstractOpenAPISchema, IEquatable<AppControlSignaturesListIncludedUsers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersApp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersApp.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersApp actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersAll.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersGuests.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersAdministrator.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersName.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignaturesListIncludedUsers" /> class
        /// with the <see cref="AppControlSignaturesListIncludedUsersGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignaturesListIncludedUsersGroup.</param>
        public AppControlSignaturesListIncludedUsers(AppControlSignaturesListIncludedUsersGroup actualInstance)
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
                if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersApp))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignaturesListIncludedUsersName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppControlSignaturesListIncludedUsersAdministrator, AppControlSignaturesListIncludedUsersAll, AppControlSignaturesListIncludedUsersApp, AppControlSignaturesListIncludedUsersGroup, AppControlSignaturesListIncludedUsersGuests, AppControlSignaturesListIncludedUsersName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersApp`. If the actual instance is not `AppControlSignaturesListIncludedUsersApp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersApp</returns>
        public AppControlSignaturesListIncludedUsersApp GetAppControlSignaturesListIncludedUsersApp()
        {
            return (AppControlSignaturesListIncludedUsersApp)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersAll`. If the actual instance is not `AppControlSignaturesListIncludedUsersAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersAll</returns>
        public AppControlSignaturesListIncludedUsersAll GetAppControlSignaturesListIncludedUsersAll()
        {
            return (AppControlSignaturesListIncludedUsersAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersGuests`. If the actual instance is not `AppControlSignaturesListIncludedUsersGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersGuests</returns>
        public AppControlSignaturesListIncludedUsersGuests GetAppControlSignaturesListIncludedUsersGuests()
        {
            return (AppControlSignaturesListIncludedUsersGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersAdministrator`. If the actual instance is not `AppControlSignaturesListIncludedUsersAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersAdministrator</returns>
        public AppControlSignaturesListIncludedUsersAdministrator GetAppControlSignaturesListIncludedUsersAdministrator()
        {
            return (AppControlSignaturesListIncludedUsersAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersName`. If the actual instance is not `AppControlSignaturesListIncludedUsersName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersName</returns>
        public AppControlSignaturesListIncludedUsersName GetAppControlSignaturesListIncludedUsersName()
        {
            return (AppControlSignaturesListIncludedUsersName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignaturesListIncludedUsersGroup`. If the actual instance is not `AppControlSignaturesListIncludedUsersGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignaturesListIncludedUsersGroup</returns>
        public AppControlSignaturesListIncludedUsersGroup GetAppControlSignaturesListIncludedUsersGroup()
        {
            return (AppControlSignaturesListIncludedUsersGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppControlSignaturesListIncludedUsers {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppControlSignaturesListIncludedUsers.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppControlSignaturesListIncludedUsers
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppControlSignaturesListIncludedUsers</returns>
        public static AppControlSignaturesListIncludedUsers FromJson(string jsonString)
        {
            AppControlSignaturesListIncludedUsers newAppControlSignaturesListIncludedUsers = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppControlSignaturesListIncludedUsers;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersAdministrator>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersAdministrator>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersAll).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersAll>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersAll>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersApp).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersApp>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersApp>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersApp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersApp: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersGroup>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersGroup>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersGuests).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersGuests>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersGuests>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignaturesListIncludedUsersName).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersName>(jsonString, AppControlSignaturesListIncludedUsers.SerializerSettings));
                }
                else
                {
                    newAppControlSignaturesListIncludedUsers = new AppControlSignaturesListIncludedUsers(JsonConvert.DeserializeObject<AppControlSignaturesListIncludedUsersName>(jsonString, AppControlSignaturesListIncludedUsers.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignaturesListIncludedUsersName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignaturesListIncludedUsersName: {1}", jsonString, exception.ToString()));
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
            return newAppControlSignaturesListIncludedUsers;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppControlSignaturesListIncludedUsers);
        }

        /// <summary>
        /// Returns true if AppControlSignaturesListIncludedUsers instances are equal
        /// </summary>
        /// <param name="input">Instance of AppControlSignaturesListIncludedUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppControlSignaturesListIncludedUsers input)
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
    /// Custom JSON converter for AppControlSignaturesListIncludedUsers
    /// </summary>
    public class AppControlSignaturesListIncludedUsersJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppControlSignaturesListIncludedUsers).GetMethod("ToJson").Invoke(value, null)));
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
                return AppControlSignaturesListIncludedUsers.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
