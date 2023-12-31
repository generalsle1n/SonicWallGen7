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
    /// Specify the original source for the NAT policy.
    /// </summary>
    [JsonConverter(typeof(NatPolicyIpv4Ipv4SourceJsonConverter))]
    [DataContract(Name = "nat_policy_ipv4_ipv4_source")]
    public partial class NatPolicyIpv4Ipv4Source : AbstractOpenAPISchema, IEquatable<NatPolicyIpv4Ipv4Source>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv4Ipv4Source" /> class
        /// with the <see cref="NatPolicyIpv4SourceAny" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv4SourceAny.</param>
        public NatPolicyIpv4Ipv4Source(NatPolicyIpv4SourceAny actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv4Ipv4Source" /> class
        /// with the <see cref="NatPolicyIpv4SourceName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv4SourceName.</param>
        public NatPolicyIpv4Ipv4Source(NatPolicyIpv4SourceName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv4Ipv4Source" /> class
        /// with the <see cref="NatPolicyIpv4SourceGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv4SourceGroup.</param>
        public NatPolicyIpv4Ipv4Source(NatPolicyIpv4SourceGroup actualInstance)
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
                if (value.GetType() == typeof(NatPolicyIpv4SourceAny))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NatPolicyIpv4SourceGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NatPolicyIpv4SourceName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: NatPolicyIpv4SourceAny, NatPolicyIpv4SourceGroup, NatPolicyIpv4SourceName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv4SourceAny`. If the actual instance is not `NatPolicyIpv4SourceAny`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv4SourceAny</returns>
        public NatPolicyIpv4SourceAny GetNatPolicyIpv4SourceAny()
        {
            return (NatPolicyIpv4SourceAny)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv4SourceName`. If the actual instance is not `NatPolicyIpv4SourceName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv4SourceName</returns>
        public NatPolicyIpv4SourceName GetNatPolicyIpv4SourceName()
        {
            return (NatPolicyIpv4SourceName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv4SourceGroup`. If the actual instance is not `NatPolicyIpv4SourceGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv4SourceGroup</returns>
        public NatPolicyIpv4SourceGroup GetNatPolicyIpv4SourceGroup()
        {
            return (NatPolicyIpv4SourceGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NatPolicyIpv4Ipv4Source {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NatPolicyIpv4Ipv4Source.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NatPolicyIpv4Ipv4Source
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NatPolicyIpv4Ipv4Source</returns>
        public static NatPolicyIpv4Ipv4Source FromJson(string jsonString)
        {
            NatPolicyIpv4Ipv4Source newNatPolicyIpv4Ipv4Source = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNatPolicyIpv4Ipv4Source;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv4SourceAny).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceAny>(jsonString, NatPolicyIpv4Ipv4Source.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceAny>(jsonString, NatPolicyIpv4Ipv4Source.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv4SourceAny");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv4SourceAny: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv4SourceGroup).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceGroup>(jsonString, NatPolicyIpv4Ipv4Source.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceGroup>(jsonString, NatPolicyIpv4Ipv4Source.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv4SourceGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv4SourceGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv4SourceName).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceName>(jsonString, NatPolicyIpv4Ipv4Source.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv4Ipv4Source = new NatPolicyIpv4Ipv4Source(JsonConvert.DeserializeObject<NatPolicyIpv4SourceName>(jsonString, NatPolicyIpv4Ipv4Source.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv4SourceName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv4SourceName: {1}", jsonString, exception.ToString()));
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
            return newNatPolicyIpv4Ipv4Source;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NatPolicyIpv4Ipv4Source);
        }

        /// <summary>
        /// Returns true if NatPolicyIpv4Ipv4Source instances are equal
        /// </summary>
        /// <param name="input">Instance of NatPolicyIpv4Ipv4Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NatPolicyIpv4Ipv4Source input)
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
    /// Custom JSON converter for NatPolicyIpv4Ipv4Source
    /// </summary>
    public class NatPolicyIpv4Ipv4SourceJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NatPolicyIpv4Ipv4Source).GetMethod("ToJson").Invoke(value, null)));
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
                return NatPolicyIpv4Ipv4Source.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
