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
    /// Authentication setting.
    /// </summary>
    [JsonConverter(typeof(SnmpUserAuthenticationJsonConverter))]
    [DataContract(Name = "snmp_user_authentication")]
    public partial class SnmpUserAuthentication : AbstractOpenAPISchema, IEquatable<SnmpUserAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpUserAuthentication" /> class
        /// with the <see cref="SnmpUserAuthenticationMd5" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SnmpUserAuthenticationMd5.</param>
        public SnmpUserAuthentication(SnmpUserAuthenticationMd5 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpUserAuthentication" /> class
        /// with the <see cref="SnmpUserAuthenticationSha1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SnmpUserAuthenticationSha1.</param>
        public SnmpUserAuthentication(SnmpUserAuthenticationSha1 actualInstance)
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
                if (value.GetType() == typeof(SnmpUserAuthenticationMd5))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SnmpUserAuthenticationSha1))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: SnmpUserAuthenticationMd5, SnmpUserAuthenticationSha1");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `SnmpUserAuthenticationMd5`. If the actual instance is not `SnmpUserAuthenticationMd5`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SnmpUserAuthenticationMd5</returns>
        public SnmpUserAuthenticationMd5 GetSnmpUserAuthenticationMd5()
        {
            return (SnmpUserAuthenticationMd5)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SnmpUserAuthenticationSha1`. If the actual instance is not `SnmpUserAuthenticationSha1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SnmpUserAuthenticationSha1</returns>
        public SnmpUserAuthenticationSha1 GetSnmpUserAuthenticationSha1()
        {
            return (SnmpUserAuthenticationSha1)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnmpUserAuthentication {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SnmpUserAuthentication.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SnmpUserAuthentication
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SnmpUserAuthentication</returns>
        public static SnmpUserAuthentication FromJson(string jsonString)
        {
            SnmpUserAuthentication newSnmpUserAuthentication = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSnmpUserAuthentication;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SnmpUserAuthenticationMd5).GetProperty("AdditionalProperties") == null)
                {
                    newSnmpUserAuthentication = new SnmpUserAuthentication(JsonConvert.DeserializeObject<SnmpUserAuthenticationMd5>(jsonString, SnmpUserAuthentication.SerializerSettings));
                }
                else
                {
                    newSnmpUserAuthentication = new SnmpUserAuthentication(JsonConvert.DeserializeObject<SnmpUserAuthenticationMd5>(jsonString, SnmpUserAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SnmpUserAuthenticationMd5");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SnmpUserAuthenticationMd5: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SnmpUserAuthenticationSha1).GetProperty("AdditionalProperties") == null)
                {
                    newSnmpUserAuthentication = new SnmpUserAuthentication(JsonConvert.DeserializeObject<SnmpUserAuthenticationSha1>(jsonString, SnmpUserAuthentication.SerializerSettings));
                }
                else
                {
                    newSnmpUserAuthentication = new SnmpUserAuthentication(JsonConvert.DeserializeObject<SnmpUserAuthenticationSha1>(jsonString, SnmpUserAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SnmpUserAuthenticationSha1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SnmpUserAuthenticationSha1: {1}", jsonString, exception.ToString()));
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
            return newSnmpUserAuthentication;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SnmpUserAuthentication);
        }

        /// <summary>
        /// Returns true if SnmpUserAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of SnmpUserAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnmpUserAuthentication input)
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
    /// Custom JSON converter for SnmpUserAuthentication
    /// </summary>
    public class SnmpUserAuthenticationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SnmpUserAuthentication).GetMethod("ToJson").Invoke(value, null)));
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
                return SnmpUserAuthentication.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
