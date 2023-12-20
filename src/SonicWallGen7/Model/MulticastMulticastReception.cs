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
    /// Enable reception for the specified multicast addresses.
    /// </summary>
    [JsonConverter(typeof(MulticastMulticastReceptionJsonConverter))]
    [DataContract(Name = "multicast_multicast_reception")]
    public partial class MulticastMulticastReception : AbstractOpenAPISchema, IEquatable<MulticastMulticastReception>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionAll.</param>
        public MulticastMulticastReception(MulticastReceptionAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionName.</param>
        public MulticastMulticastReception(MulticastReceptionName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionGroup.</param>
        public MulticastMulticastReception(MulticastReceptionGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionHost.</param>
        public MulticastMulticastReception(MulticastReceptionHost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionRange" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionRange.</param>
        public MulticastMulticastReception(MulticastReceptionRange actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticastMulticastReception" /> class
        /// with the <see cref="MulticastReceptionNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MulticastReceptionNetwork.</param>
        public MulticastMulticastReception(MulticastReceptionNetwork actualInstance)
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
                if (value.GetType() == typeof(MulticastReceptionAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MulticastReceptionGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MulticastReceptionHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MulticastReceptionName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MulticastReceptionNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MulticastReceptionRange))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: MulticastReceptionAll, MulticastReceptionGroup, MulticastReceptionHost, MulticastReceptionName, MulticastReceptionNetwork, MulticastReceptionRange");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionAll`. If the actual instance is not `MulticastReceptionAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionAll</returns>
        public MulticastReceptionAll GetMulticastReceptionAll()
        {
            return (MulticastReceptionAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionName`. If the actual instance is not `MulticastReceptionName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionName</returns>
        public MulticastReceptionName GetMulticastReceptionName()
        {
            return (MulticastReceptionName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionGroup`. If the actual instance is not `MulticastReceptionGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionGroup</returns>
        public MulticastReceptionGroup GetMulticastReceptionGroup()
        {
            return (MulticastReceptionGroup)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionHost`. If the actual instance is not `MulticastReceptionHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionHost</returns>
        public MulticastReceptionHost GetMulticastReceptionHost()
        {
            return (MulticastReceptionHost)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionRange`. If the actual instance is not `MulticastReceptionRange`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionRange</returns>
        public MulticastReceptionRange GetMulticastReceptionRange()
        {
            return (MulticastReceptionRange)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MulticastReceptionNetwork`. If the actual instance is not `MulticastReceptionNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MulticastReceptionNetwork</returns>
        public MulticastReceptionNetwork GetMulticastReceptionNetwork()
        {
            return (MulticastReceptionNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MulticastMulticastReception {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, MulticastMulticastReception.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of MulticastMulticastReception
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of MulticastMulticastReception</returns>
        public static MulticastMulticastReception FromJson(string jsonString)
        {
            MulticastMulticastReception newMulticastMulticastReception = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newMulticastMulticastReception;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionAll).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionAll>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionAll>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionGroup).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionGroup>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionGroup>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionHost).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionHost>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionHost>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionName).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionName>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionName>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionNetwork>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionNetwork>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MulticastReceptionRange).GetProperty("AdditionalProperties") == null)
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionRange>(jsonString, MulticastMulticastReception.SerializerSettings));
                }
                else
                {
                    newMulticastMulticastReception = new MulticastMulticastReception(JsonConvert.DeserializeObject<MulticastReceptionRange>(jsonString, MulticastMulticastReception.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MulticastReceptionRange");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MulticastReceptionRange: {1}", jsonString, exception.ToString()));
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
            return newMulticastMulticastReception;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MulticastMulticastReception);
        }

        /// <summary>
        /// Returns true if MulticastMulticastReception instances are equal
        /// </summary>
        /// <param name="input">Instance of MulticastMulticastReception to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MulticastMulticastReception input)
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
    /// Custom JSON converter for MulticastMulticastReception
    /// </summary>
    public class MulticastMulticastReceptionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(MulticastMulticastReception).GetMethod("ToJson").Invoke(value, null)));
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
                return MulticastMulticastReception.FromJson(JObject.Load(reader).ToString(Formatting.None));
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