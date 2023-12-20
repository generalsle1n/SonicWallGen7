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
    /// Specify IP helper policy source.
    /// </summary>
    [JsonConverter(typeof(IphPolicySourceJsonConverter))]
    [DataContract(Name = "iph_policy_source")]
    public partial class IphPolicySource : AbstractOpenAPISchema, IEquatable<IphPolicySource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IphPolicySource" /> class
        /// with the <see cref="IphPolicySourceInterface" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IphPolicySourceInterface.</param>
        public IphPolicySource(IphPolicySourceInterface actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IphPolicySource" /> class
        /// with the <see cref="IphPolicySourceZone" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IphPolicySourceZone.</param>
        public IphPolicySource(IphPolicySourceZone actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IphPolicySource" /> class
        /// with the <see cref="IphPolicySourceNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IphPolicySourceNetwork.</param>
        public IphPolicySource(IphPolicySourceNetwork actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IphPolicySource" /> class
        /// with the <see cref="IphPolicySourceName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IphPolicySourceName.</param>
        public IphPolicySource(IphPolicySourceName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IphPolicySource" /> class
        /// with the <see cref="IphPolicySourceGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IphPolicySourceGroup.</param>
        public IphPolicySource(IphPolicySourceGroup actualInstance)
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
                if (value.GetType() == typeof(IphPolicySourceGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IphPolicySourceInterface))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IphPolicySourceName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IphPolicySourceNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IphPolicySourceZone))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: IphPolicySourceGroup, IphPolicySourceInterface, IphPolicySourceName, IphPolicySourceNetwork, IphPolicySourceZone");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `IphPolicySourceInterface`. If the actual instance is not `IphPolicySourceInterface`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IphPolicySourceInterface</returns>
        public IphPolicySourceInterface GetIphPolicySourceInterface()
        {
            return (IphPolicySourceInterface)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IphPolicySourceZone`. If the actual instance is not `IphPolicySourceZone`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IphPolicySourceZone</returns>
        public IphPolicySourceZone GetIphPolicySourceZone()
        {
            return (IphPolicySourceZone)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IphPolicySourceNetwork`. If the actual instance is not `IphPolicySourceNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IphPolicySourceNetwork</returns>
        public IphPolicySourceNetwork GetIphPolicySourceNetwork()
        {
            return (IphPolicySourceNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IphPolicySourceName`. If the actual instance is not `IphPolicySourceName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IphPolicySourceName</returns>
        public IphPolicySourceName GetIphPolicySourceName()
        {
            return (IphPolicySourceName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IphPolicySourceGroup`. If the actual instance is not `IphPolicySourceGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IphPolicySourceGroup</returns>
        public IphPolicySourceGroup GetIphPolicySourceGroup()
        {
            return (IphPolicySourceGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IphPolicySource {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, IphPolicySource.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of IphPolicySource
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of IphPolicySource</returns>
        public static IphPolicySource FromJson(string jsonString)
        {
            IphPolicySource newIphPolicySource = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newIphPolicySource;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IphPolicySourceGroup).GetProperty("AdditionalProperties") == null)
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceGroup>(jsonString, IphPolicySource.SerializerSettings));
                }
                else
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceGroup>(jsonString, IphPolicySource.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IphPolicySourceGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IphPolicySourceGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IphPolicySourceInterface).GetProperty("AdditionalProperties") == null)
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceInterface>(jsonString, IphPolicySource.SerializerSettings));
                }
                else
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceInterface>(jsonString, IphPolicySource.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IphPolicySourceInterface");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IphPolicySourceInterface: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IphPolicySourceName).GetProperty("AdditionalProperties") == null)
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceName>(jsonString, IphPolicySource.SerializerSettings));
                }
                else
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceName>(jsonString, IphPolicySource.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IphPolicySourceName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IphPolicySourceName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IphPolicySourceNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceNetwork>(jsonString, IphPolicySource.SerializerSettings));
                }
                else
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceNetwork>(jsonString, IphPolicySource.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IphPolicySourceNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IphPolicySourceNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IphPolicySourceZone).GetProperty("AdditionalProperties") == null)
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceZone>(jsonString, IphPolicySource.SerializerSettings));
                }
                else
                {
                    newIphPolicySource = new IphPolicySource(JsonConvert.DeserializeObject<IphPolicySourceZone>(jsonString, IphPolicySource.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IphPolicySourceZone");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IphPolicySourceZone: {1}", jsonString, exception.ToString()));
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
            return newIphPolicySource;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IphPolicySource);
        }

        /// <summary>
        /// Returns true if IphPolicySource instances are equal
        /// </summary>
        /// <param name="input">Instance of IphPolicySource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IphPolicySource input)
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
    /// Custom JSON converter for IphPolicySource
    /// </summary>
    public class IphPolicySourceJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(IphPolicySource).GetMethod("ToJson").Invoke(value, null)));
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
                return IphPolicySource.FromJson(JObject.Load(reader).ToString(Formatting.None));
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