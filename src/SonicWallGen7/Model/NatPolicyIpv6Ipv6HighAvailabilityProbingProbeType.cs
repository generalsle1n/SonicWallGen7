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
    /// Set probe IP type.
    /// </summary>
    [JsonConverter(typeof(NatPolicyIpv6Ipv6HighAvailabilityProbingProbeTypeJsonConverter))]
    [DataContract(Name = "nat_policy_ipv6_ipv6_high_availability_probing_probe_type")]
    public partial class NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType : AbstractOpenAPISchema, IEquatable<NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType" /> class
        /// with the <see cref="NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing.</param>
        public NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType" /> class
        /// with the <see cref="NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp.</param>
        public NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp actualInstance)
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
                if (value.GetType() == typeof(NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing, NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing`. If the actual instance is not `NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing</returns>
        public NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing GetNatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing()
        {
            return (NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp`. If the actual instance is not `NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp</returns>
        public NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp GetNatPolicyIpv6HighAvailabilityProbingProbeTypeTcp()
        {
            return (NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType</returns>
        public static NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType FromJson(string jsonString)
        {
            NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType = new NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(JsonConvert.DeserializeObject<NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing>(jsonString, NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType = new NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(JsonConvert.DeserializeObject<NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing>(jsonString, NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv6HighAvailabilityProbingProbeTypeIcmpPing: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType = new NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(JsonConvert.DeserializeObject<NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp>(jsonString, NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType = new NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType(JsonConvert.DeserializeObject<NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp>(jsonString, NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv6HighAvailabilityProbingProbeTypeTcp: {1}", jsonString, exception.ToString()));
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
            return newNatPolicyIpv6Ipv6HighAvailabilityProbingProbeType;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType);
        }

        /// <summary>
        /// Returns true if NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType instances are equal
        /// </summary>
        /// <param name="input">Instance of NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType input)
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
    /// Custom JSON converter for NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType
    /// </summary>
    public class NatPolicyIpv6Ipv6HighAvailabilityProbingProbeTypeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType).GetMethod("ToJson").Invoke(value, null)));
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
                return NatPolicyIpv6Ipv6HighAvailabilityProbingProbeType.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
