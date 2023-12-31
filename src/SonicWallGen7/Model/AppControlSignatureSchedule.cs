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
    /// Set app control signature schedule.
    /// </summary>
    [JsonConverter(typeof(AppControlSignatureScheduleJsonConverter))]
    [DataContract(Name = "app_control_signature_schedule")]
    public partial class AppControlSignatureSchedule : AbstractOpenAPISchema, IEquatable<AppControlSignatureSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureSchedule" /> class
        /// with the <see cref="AppControlSignatureScheduleApp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureScheduleApp.</param>
        public AppControlSignatureSchedule(AppControlSignatureScheduleApp actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureSchedule" /> class
        /// with the <see cref="AppControlSignatureScheduleAlwaysOn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureScheduleAlwaysOn.</param>
        public AppControlSignatureSchedule(AppControlSignatureScheduleAlwaysOn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureSchedule" /> class
        /// with the <see cref="AppControlSignatureScheduleName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureScheduleName.</param>
        public AppControlSignatureSchedule(AppControlSignatureScheduleName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppControlSignatureSchedule" /> class
        /// with the <see cref="AppControlSignatureScheduleDays" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppControlSignatureScheduleDays.</param>
        public AppControlSignatureSchedule(AppControlSignatureScheduleDays actualInstance)
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
                if (value.GetType() == typeof(AppControlSignatureScheduleAlwaysOn))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureScheduleApp))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureScheduleDays))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppControlSignatureScheduleName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppControlSignatureScheduleAlwaysOn, AppControlSignatureScheduleApp, AppControlSignatureScheduleDays, AppControlSignatureScheduleName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureScheduleApp`. If the actual instance is not `AppControlSignatureScheduleApp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureScheduleApp</returns>
        public AppControlSignatureScheduleApp GetAppControlSignatureScheduleApp()
        {
            return (AppControlSignatureScheduleApp)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureScheduleAlwaysOn`. If the actual instance is not `AppControlSignatureScheduleAlwaysOn`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureScheduleAlwaysOn</returns>
        public AppControlSignatureScheduleAlwaysOn GetAppControlSignatureScheduleAlwaysOn()
        {
            return (AppControlSignatureScheduleAlwaysOn)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureScheduleName`. If the actual instance is not `AppControlSignatureScheduleName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureScheduleName</returns>
        public AppControlSignatureScheduleName GetAppControlSignatureScheduleName()
        {
            return (AppControlSignatureScheduleName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppControlSignatureScheduleDays`. If the actual instance is not `AppControlSignatureScheduleDays`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppControlSignatureScheduleDays</returns>
        public AppControlSignatureScheduleDays GetAppControlSignatureScheduleDays()
        {
            return (AppControlSignatureScheduleDays)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppControlSignatureSchedule {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppControlSignatureSchedule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppControlSignatureSchedule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppControlSignatureSchedule</returns>
        public static AppControlSignatureSchedule FromJson(string jsonString)
        {
            AppControlSignatureSchedule newAppControlSignatureSchedule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppControlSignatureSchedule;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureScheduleAlwaysOn).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleAlwaysOn>(jsonString, AppControlSignatureSchedule.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleAlwaysOn>(jsonString, AppControlSignatureSchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureScheduleAlwaysOn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureScheduleAlwaysOn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureScheduleApp).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleApp>(jsonString, AppControlSignatureSchedule.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleApp>(jsonString, AppControlSignatureSchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureScheduleApp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureScheduleApp: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureScheduleDays).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleDays>(jsonString, AppControlSignatureSchedule.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleDays>(jsonString, AppControlSignatureSchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureScheduleDays");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureScheduleDays: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppControlSignatureScheduleName).GetProperty("AdditionalProperties") == null)
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleName>(jsonString, AppControlSignatureSchedule.SerializerSettings));
                }
                else
                {
                    newAppControlSignatureSchedule = new AppControlSignatureSchedule(JsonConvert.DeserializeObject<AppControlSignatureScheduleName>(jsonString, AppControlSignatureSchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppControlSignatureScheduleName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppControlSignatureScheduleName: {1}", jsonString, exception.ToString()));
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
            return newAppControlSignatureSchedule;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppControlSignatureSchedule);
        }

        /// <summary>
        /// Returns true if AppControlSignatureSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of AppControlSignatureSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppControlSignatureSchedule input)
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
    /// Custom JSON converter for AppControlSignatureSchedule
    /// </summary>
    public class AppControlSignatureScheduleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppControlSignatureSchedule).GetMethod("ToJson").Invoke(value, null)));
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
                return AppControlSignatureSchedule.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
