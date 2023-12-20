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
    /// Direction.
    /// </summary>
    [JsonConverter(typeof(CustomMatchDirectionJsonConverter))]
    [DataContract(Name = "custom_match_direction")]
    public partial class CustomMatchDirection : AbstractOpenAPISchema, IEquatable<CustomMatchDirection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMatchDirection" /> class
        /// with the <see cref="CustomMatchDirectionBasic" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CustomMatchDirectionBasic.</param>
        public CustomMatchDirection(CustomMatchDirectionBasic actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMatchDirection" /> class
        /// with the <see cref="CustomMatchDirectionAdvanced" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CustomMatchDirectionAdvanced.</param>
        public CustomMatchDirection(CustomMatchDirectionAdvanced actualInstance)
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
                if (value.GetType() == typeof(CustomMatchDirectionAdvanced))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CustomMatchDirectionBasic))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CustomMatchDirectionAdvanced, CustomMatchDirectionBasic");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CustomMatchDirectionBasic`. If the actual instance is not `CustomMatchDirectionBasic`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CustomMatchDirectionBasic</returns>
        public CustomMatchDirectionBasic GetCustomMatchDirectionBasic()
        {
            return (CustomMatchDirectionBasic)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CustomMatchDirectionAdvanced`. If the actual instance is not `CustomMatchDirectionAdvanced`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CustomMatchDirectionAdvanced</returns>
        public CustomMatchDirectionAdvanced GetCustomMatchDirectionAdvanced()
        {
            return (CustomMatchDirectionAdvanced)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomMatchDirection {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CustomMatchDirection.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CustomMatchDirection
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CustomMatchDirection</returns>
        public static CustomMatchDirection FromJson(string jsonString)
        {
            CustomMatchDirection newCustomMatchDirection = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCustomMatchDirection;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CustomMatchDirectionAdvanced).GetProperty("AdditionalProperties") == null)
                {
                    newCustomMatchDirection = new CustomMatchDirection(JsonConvert.DeserializeObject<CustomMatchDirectionAdvanced>(jsonString, CustomMatchDirection.SerializerSettings));
                }
                else
                {
                    newCustomMatchDirection = new CustomMatchDirection(JsonConvert.DeserializeObject<CustomMatchDirectionAdvanced>(jsonString, CustomMatchDirection.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CustomMatchDirectionAdvanced");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CustomMatchDirectionAdvanced: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CustomMatchDirectionBasic).GetProperty("AdditionalProperties") == null)
                {
                    newCustomMatchDirection = new CustomMatchDirection(JsonConvert.DeserializeObject<CustomMatchDirectionBasic>(jsonString, CustomMatchDirection.SerializerSettings));
                }
                else
                {
                    newCustomMatchDirection = new CustomMatchDirection(JsonConvert.DeserializeObject<CustomMatchDirectionBasic>(jsonString, CustomMatchDirection.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CustomMatchDirectionBasic");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CustomMatchDirectionBasic: {1}", jsonString, exception.ToString()));
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
            return newCustomMatchDirection;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomMatchDirection);
        }

        /// <summary>
        /// Returns true if CustomMatchDirection instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomMatchDirection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomMatchDirection input)
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
    /// Custom JSON converter for CustomMatchDirection
    /// </summary>
    public class CustomMatchDirectionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CustomMatchDirection).GetMethod("ToJson").Invoke(value, null)));
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
                return CustomMatchDirection.FromJson(JObject.Load(reader).ToString(Formatting.None));
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