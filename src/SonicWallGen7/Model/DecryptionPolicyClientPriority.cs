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
    /// Set decryption policy priority
    /// </summary>
    [JsonConverter(typeof(DecryptionPolicyClientPriorityJsonConverter))]
    [DataContract(Name = "decryption_policy_client_priority")]
    public partial class DecryptionPolicyClientPriority : AbstractOpenAPISchema, IEquatable<DecryptionPolicyClientPriority>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClientPriority" /> class
        /// with the <see cref="DecryptionPolicyClientPriorityBegin" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DecryptionPolicyClientPriorityBegin.</param>
        public DecryptionPolicyClientPriority(DecryptionPolicyClientPriorityBegin actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClientPriority" /> class
        /// with the <see cref="DecryptionPolicyClientPriorityEnd" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DecryptionPolicyClientPriorityEnd.</param>
        public DecryptionPolicyClientPriority(DecryptionPolicyClientPriorityEnd actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClientPriority" /> class
        /// with the <see cref="DecryptionPolicyClientPriorityManual" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DecryptionPolicyClientPriorityManual.</param>
        public DecryptionPolicyClientPriority(DecryptionPolicyClientPriorityManual actualInstance)
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
                if (value.GetType() == typeof(DecryptionPolicyClientPriorityBegin))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DecryptionPolicyClientPriorityEnd))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DecryptionPolicyClientPriorityManual))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DecryptionPolicyClientPriorityBegin, DecryptionPolicyClientPriorityEnd, DecryptionPolicyClientPriorityManual");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DecryptionPolicyClientPriorityBegin`. If the actual instance is not `DecryptionPolicyClientPriorityBegin`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DecryptionPolicyClientPriorityBegin</returns>
        public DecryptionPolicyClientPriorityBegin GetDecryptionPolicyClientPriorityBegin()
        {
            return (DecryptionPolicyClientPriorityBegin)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DecryptionPolicyClientPriorityEnd`. If the actual instance is not `DecryptionPolicyClientPriorityEnd`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DecryptionPolicyClientPriorityEnd</returns>
        public DecryptionPolicyClientPriorityEnd GetDecryptionPolicyClientPriorityEnd()
        {
            return (DecryptionPolicyClientPriorityEnd)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DecryptionPolicyClientPriorityManual`. If the actual instance is not `DecryptionPolicyClientPriorityManual`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DecryptionPolicyClientPriorityManual</returns>
        public DecryptionPolicyClientPriorityManual GetDecryptionPolicyClientPriorityManual()
        {
            return (DecryptionPolicyClientPriorityManual)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptionPolicyClientPriority {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DecryptionPolicyClientPriority.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DecryptionPolicyClientPriority
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DecryptionPolicyClientPriority</returns>
        public static DecryptionPolicyClientPriority FromJson(string jsonString)
        {
            DecryptionPolicyClientPriority newDecryptionPolicyClientPriority = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDecryptionPolicyClientPriority;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DecryptionPolicyClientPriorityBegin).GetProperty("AdditionalProperties") == null)
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityBegin>(jsonString, DecryptionPolicyClientPriority.SerializerSettings));
                }
                else
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityBegin>(jsonString, DecryptionPolicyClientPriority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DecryptionPolicyClientPriorityBegin");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DecryptionPolicyClientPriorityBegin: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DecryptionPolicyClientPriorityEnd).GetProperty("AdditionalProperties") == null)
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityEnd>(jsonString, DecryptionPolicyClientPriority.SerializerSettings));
                }
                else
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityEnd>(jsonString, DecryptionPolicyClientPriority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DecryptionPolicyClientPriorityEnd");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DecryptionPolicyClientPriorityEnd: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DecryptionPolicyClientPriorityManual).GetProperty("AdditionalProperties") == null)
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityManual>(jsonString, DecryptionPolicyClientPriority.SerializerSettings));
                }
                else
                {
                    newDecryptionPolicyClientPriority = new DecryptionPolicyClientPriority(JsonConvert.DeserializeObject<DecryptionPolicyClientPriorityManual>(jsonString, DecryptionPolicyClientPriority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DecryptionPolicyClientPriorityManual");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DecryptionPolicyClientPriorityManual: {1}", jsonString, exception.ToString()));
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
            return newDecryptionPolicyClientPriority;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptionPolicyClientPriority);
        }

        /// <summary>
        /// Returns true if DecryptionPolicyClientPriority instances are equal
        /// </summary>
        /// <param name="input">Instance of DecryptionPolicyClientPriority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecryptionPolicyClientPriority input)
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
    /// Custom JSON converter for DecryptionPolicyClientPriority
    /// </summary>
    public class DecryptionPolicyClientPriorityJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DecryptionPolicyClientPriority).GetMethod("ToJson").Invoke(value, null)));
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
                return DecryptionPolicyClientPriority.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
