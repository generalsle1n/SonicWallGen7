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
    /// Set MAC address used for this interface.
    /// </summary>
    [JsonConverter(typeof(InterfaceVlanIpv4Ipv4MacJsonConverter))]
    [DataContract(Name = "interface_vlan_ipv4_ipv4_mac")]
    public partial class InterfaceVlanIpv4Ipv4Mac : AbstractOpenAPISchema, IEquatable<InterfaceVlanIpv4Ipv4Mac>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceVlanIpv4Ipv4Mac" /> class
        /// with the <see cref="InterfaceVlanIpv4MacDefault" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InterfaceVlanIpv4MacDefault.</param>
        public InterfaceVlanIpv4Ipv4Mac(InterfaceVlanIpv4MacDefault actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceVlanIpv4Ipv4Mac" /> class
        /// with the <see cref="InterfaceVlanIpv4MacOverride" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InterfaceVlanIpv4MacOverride.</param>
        public InterfaceVlanIpv4Ipv4Mac(InterfaceVlanIpv4MacOverride actualInstance)
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
                if (value.GetType() == typeof(InterfaceVlanIpv4MacDefault))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InterfaceVlanIpv4MacOverride))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InterfaceVlanIpv4MacDefault, InterfaceVlanIpv4MacOverride");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InterfaceVlanIpv4MacDefault`. If the actual instance is not `InterfaceVlanIpv4MacDefault`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InterfaceVlanIpv4MacDefault</returns>
        public InterfaceVlanIpv4MacDefault GetInterfaceVlanIpv4MacDefault()
        {
            return (InterfaceVlanIpv4MacDefault)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InterfaceVlanIpv4MacOverride`. If the actual instance is not `InterfaceVlanIpv4MacOverride`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InterfaceVlanIpv4MacOverride</returns>
        public InterfaceVlanIpv4MacOverride GetInterfaceVlanIpv4MacOverride()
        {
            return (InterfaceVlanIpv4MacOverride)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterfaceVlanIpv4Ipv4Mac {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, InterfaceVlanIpv4Ipv4Mac.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of InterfaceVlanIpv4Ipv4Mac
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of InterfaceVlanIpv4Ipv4Mac</returns>
        public static InterfaceVlanIpv4Ipv4Mac FromJson(string jsonString)
        {
            InterfaceVlanIpv4Ipv4Mac newInterfaceVlanIpv4Ipv4Mac = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newInterfaceVlanIpv4Ipv4Mac;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InterfaceVlanIpv4MacDefault).GetProperty("AdditionalProperties") == null)
                {
                    newInterfaceVlanIpv4Ipv4Mac = new InterfaceVlanIpv4Ipv4Mac(JsonConvert.DeserializeObject<InterfaceVlanIpv4MacDefault>(jsonString, InterfaceVlanIpv4Ipv4Mac.SerializerSettings));
                }
                else
                {
                    newInterfaceVlanIpv4Ipv4Mac = new InterfaceVlanIpv4Ipv4Mac(JsonConvert.DeserializeObject<InterfaceVlanIpv4MacDefault>(jsonString, InterfaceVlanIpv4Ipv4Mac.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InterfaceVlanIpv4MacDefault");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InterfaceVlanIpv4MacDefault: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InterfaceVlanIpv4MacOverride).GetProperty("AdditionalProperties") == null)
                {
                    newInterfaceVlanIpv4Ipv4Mac = new InterfaceVlanIpv4Ipv4Mac(JsonConvert.DeserializeObject<InterfaceVlanIpv4MacOverride>(jsonString, InterfaceVlanIpv4Ipv4Mac.SerializerSettings));
                }
                else
                {
                    newInterfaceVlanIpv4Ipv4Mac = new InterfaceVlanIpv4Ipv4Mac(JsonConvert.DeserializeObject<InterfaceVlanIpv4MacOverride>(jsonString, InterfaceVlanIpv4Ipv4Mac.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InterfaceVlanIpv4MacOverride");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InterfaceVlanIpv4MacOverride: {1}", jsonString, exception.ToString()));
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
            return newInterfaceVlanIpv4Ipv4Mac;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterfaceVlanIpv4Ipv4Mac);
        }

        /// <summary>
        /// Returns true if InterfaceVlanIpv4Ipv4Mac instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceVlanIpv4Ipv4Mac to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceVlanIpv4Ipv4Mac input)
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
    /// Custom JSON converter for InterfaceVlanIpv4Ipv4Mac
    /// </summary>
    public class InterfaceVlanIpv4Ipv4MacJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(InterfaceVlanIpv4Ipv4Mac).GetMethod("ToJson").Invoke(value, null)));
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
                return InterfaceVlanIpv4Ipv4Mac.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
