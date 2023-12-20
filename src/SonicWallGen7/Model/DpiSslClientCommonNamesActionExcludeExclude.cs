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
    /// Set action as exclude.
    /// </summary>
    [JsonConverter(typeof(DpiSslClientCommonNamesActionExcludeExcludeJsonConverter))]
    [DataContract(Name = "dpi_ssl_client_common_names_action_exclude_exclude")]
    public partial class DpiSslClientCommonNamesActionExcludeExclude : AbstractOpenAPISchema, IEquatable<DpiSslClientCommonNamesActionExcludeExclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientCommonNamesActionExcludeExclude" /> class
        /// with the <see cref="DpiSslClientCommonNamesActionExcludeAuthenticateServer" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientCommonNamesActionExcludeAuthenticateServer.</param>
        public DpiSslClientCommonNamesActionExcludeExclude(DpiSslClientCommonNamesActionExcludeAuthenticateServer actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientCommonNamesActionExcludeExclude" /> class
        /// with the <see cref="DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer.</param>
        public DpiSslClientCommonNamesActionExcludeExclude(DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer actualInstance)
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
                if (value.GetType() == typeof(DpiSslClientCommonNamesActionExcludeAuthenticateServer))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DpiSslClientCommonNamesActionExcludeAuthenticateServer, DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientCommonNamesActionExcludeAuthenticateServer`. If the actual instance is not `DpiSslClientCommonNamesActionExcludeAuthenticateServer`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientCommonNamesActionExcludeAuthenticateServer</returns>
        public DpiSslClientCommonNamesActionExcludeAuthenticateServer GetDpiSslClientCommonNamesActionExcludeAuthenticateServer()
        {
            return (DpiSslClientCommonNamesActionExcludeAuthenticateServer)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer`. If the actual instance is not `DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer</returns>
        public DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer GetDpiSslClientCommonNamesActionExcludeDisableAuthenticateServer()
        {
            return (DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DpiSslClientCommonNamesActionExcludeExclude {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DpiSslClientCommonNamesActionExcludeExclude.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DpiSslClientCommonNamesActionExcludeExclude
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DpiSslClientCommonNamesActionExcludeExclude</returns>
        public static DpiSslClientCommonNamesActionExcludeExclude FromJson(string jsonString)
        {
            DpiSslClientCommonNamesActionExcludeExclude newDpiSslClientCommonNamesActionExcludeExclude = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDpiSslClientCommonNamesActionExcludeExclude;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientCommonNamesActionExcludeAuthenticateServer).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientCommonNamesActionExcludeExclude = new DpiSslClientCommonNamesActionExcludeExclude(JsonConvert.DeserializeObject<DpiSslClientCommonNamesActionExcludeAuthenticateServer>(jsonString, DpiSslClientCommonNamesActionExcludeExclude.SerializerSettings));
                }
                else
                {
                    newDpiSslClientCommonNamesActionExcludeExclude = new DpiSslClientCommonNamesActionExcludeExclude(JsonConvert.DeserializeObject<DpiSslClientCommonNamesActionExcludeAuthenticateServer>(jsonString, DpiSslClientCommonNamesActionExcludeExclude.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientCommonNamesActionExcludeAuthenticateServer");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientCommonNamesActionExcludeAuthenticateServer: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientCommonNamesActionExcludeExclude = new DpiSslClientCommonNamesActionExcludeExclude(JsonConvert.DeserializeObject<DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer>(jsonString, DpiSslClientCommonNamesActionExcludeExclude.SerializerSettings));
                }
                else
                {
                    newDpiSslClientCommonNamesActionExcludeExclude = new DpiSslClientCommonNamesActionExcludeExclude(JsonConvert.DeserializeObject<DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer>(jsonString, DpiSslClientCommonNamesActionExcludeExclude.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientCommonNamesActionExcludeDisableAuthenticateServer: {1}", jsonString, exception.ToString()));
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
            return newDpiSslClientCommonNamesActionExcludeExclude;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DpiSslClientCommonNamesActionExcludeExclude);
        }

        /// <summary>
        /// Returns true if DpiSslClientCommonNamesActionExcludeExclude instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSslClientCommonNamesActionExcludeExclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSslClientCommonNamesActionExcludeExclude input)
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
    /// Custom JSON converter for DpiSslClientCommonNamesActionExcludeExclude
    /// </summary>
    public class DpiSslClientCommonNamesActionExcludeExcludeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DpiSslClientCommonNamesActionExcludeExclude).GetMethod("ToJson").Invoke(value, null)));
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
                return DpiSslClientCommonNamesActionExcludeExclude.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
