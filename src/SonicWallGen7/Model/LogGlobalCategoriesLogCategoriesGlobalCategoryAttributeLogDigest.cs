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
    /// Include events in Log Digest.
    /// </summary>
    [JsonConverter(typeof(LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigestJsonConverter))]
    [DataContract(Name = "log_global_categories_log_categories_global_category_attribute_log_digest")]
    public partial class LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest : AbstractOpenAPISchema, IEquatable<LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest" /> class
        /// with the <see cref="LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled.</param>
        public LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest" /> class
        /// with the <see cref="LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed.</param>
        public LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed actualInstance)
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
                if (value.GetType() == typeof(LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled, LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled`. If the actual instance is not `LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled</returns>
        public LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled GetLogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled()
        {
            return (LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed`. If the actual instance is not `LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed</returns>
        public LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed GetLogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed()
        {
            return (LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest</returns>
        public static LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest FromJson(string jsonString)
        {
            LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled).GetProperty("AdditionalProperties") == null)
                {
                    newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest = new LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(JsonConvert.DeserializeObject<LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled>(jsonString, LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.SerializerSettings));
                }
                else
                {
                    newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest = new LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(JsonConvert.DeserializeObject<LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled>(jsonString, LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogGlobalCategoriesGlobalCategoryAttributeLogDigestEnabled: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed).GetProperty("AdditionalProperties") == null)
                {
                    newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest = new LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(JsonConvert.DeserializeObject<LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed>(jsonString, LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.SerializerSettings));
                }
                else
                {
                    newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest = new LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest(JsonConvert.DeserializeObject<LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed>(jsonString, LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogGlobalCategoriesGlobalCategoryAttributeLogDigestMixed: {1}", jsonString, exception.ToString()));
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
            return newLogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest);
        }

        /// <summary>
        /// Returns true if LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest input)
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
    /// Custom JSON converter for LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest
    /// </summary>
    public class LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest).GetMethod("ToJson").Invoke(value, null)));
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
                return LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeLogDigest.FromJson(JObject.Load(reader).ToString(Formatting.None));
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