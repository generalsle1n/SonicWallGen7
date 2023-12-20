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
    /// Set probe type.
    /// </summary>
    [JsonConverter(typeof(SdwanSlaProbeIpv4Ipv4ProbeTypeJsonConverter))]
    [DataContract(Name = "sdwan_sla_probe_ipv4_ipv4_probe_type")]
    public partial class SdwanSlaProbeIpv4Ipv4ProbeType : AbstractOpenAPISchema, IEquatable<SdwanSlaProbeIpv4Ipv4ProbeType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanSlaProbeIpv4Ipv4ProbeType" /> class
        /// with the <see cref="SdwanSlaProbeIpv4ProbeTypePing" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SdwanSlaProbeIpv4ProbeTypePing.</param>
        public SdwanSlaProbeIpv4Ipv4ProbeType(SdwanSlaProbeIpv4ProbeTypePing actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanSlaProbeIpv4Ipv4ProbeType" /> class
        /// with the <see cref="SdwanSlaProbeIpv4ProbeTypeTcp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SdwanSlaProbeIpv4ProbeTypeTcp.</param>
        public SdwanSlaProbeIpv4Ipv4ProbeType(SdwanSlaProbeIpv4ProbeTypeTcp actualInstance)
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
                if (value.GetType() == typeof(SdwanSlaProbeIpv4ProbeTypePing))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SdwanSlaProbeIpv4ProbeTypeTcp))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: SdwanSlaProbeIpv4ProbeTypePing, SdwanSlaProbeIpv4ProbeTypeTcp");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `SdwanSlaProbeIpv4ProbeTypePing`. If the actual instance is not `SdwanSlaProbeIpv4ProbeTypePing`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SdwanSlaProbeIpv4ProbeTypePing</returns>
        public SdwanSlaProbeIpv4ProbeTypePing GetSdwanSlaProbeIpv4ProbeTypePing()
        {
            return (SdwanSlaProbeIpv4ProbeTypePing)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SdwanSlaProbeIpv4ProbeTypeTcp`. If the actual instance is not `SdwanSlaProbeIpv4ProbeTypeTcp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SdwanSlaProbeIpv4ProbeTypeTcp</returns>
        public SdwanSlaProbeIpv4ProbeTypeTcp GetSdwanSlaProbeIpv4ProbeTypeTcp()
        {
            return (SdwanSlaProbeIpv4ProbeTypeTcp)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SdwanSlaProbeIpv4Ipv4ProbeType {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SdwanSlaProbeIpv4Ipv4ProbeType.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SdwanSlaProbeIpv4Ipv4ProbeType
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SdwanSlaProbeIpv4Ipv4ProbeType</returns>
        public static SdwanSlaProbeIpv4Ipv4ProbeType FromJson(string jsonString)
        {
            SdwanSlaProbeIpv4Ipv4ProbeType newSdwanSlaProbeIpv4Ipv4ProbeType = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSdwanSlaProbeIpv4Ipv4ProbeType;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SdwanSlaProbeIpv4ProbeTypePing).GetProperty("AdditionalProperties") == null)
                {
                    newSdwanSlaProbeIpv4Ipv4ProbeType = new SdwanSlaProbeIpv4Ipv4ProbeType(JsonConvert.DeserializeObject<SdwanSlaProbeIpv4ProbeTypePing>(jsonString, SdwanSlaProbeIpv4Ipv4ProbeType.SerializerSettings));
                }
                else
                {
                    newSdwanSlaProbeIpv4Ipv4ProbeType = new SdwanSlaProbeIpv4Ipv4ProbeType(JsonConvert.DeserializeObject<SdwanSlaProbeIpv4ProbeTypePing>(jsonString, SdwanSlaProbeIpv4Ipv4ProbeType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SdwanSlaProbeIpv4ProbeTypePing");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SdwanSlaProbeIpv4ProbeTypePing: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SdwanSlaProbeIpv4ProbeTypeTcp).GetProperty("AdditionalProperties") == null)
                {
                    newSdwanSlaProbeIpv4Ipv4ProbeType = new SdwanSlaProbeIpv4Ipv4ProbeType(JsonConvert.DeserializeObject<SdwanSlaProbeIpv4ProbeTypeTcp>(jsonString, SdwanSlaProbeIpv4Ipv4ProbeType.SerializerSettings));
                }
                else
                {
                    newSdwanSlaProbeIpv4Ipv4ProbeType = new SdwanSlaProbeIpv4Ipv4ProbeType(JsonConvert.DeserializeObject<SdwanSlaProbeIpv4ProbeTypeTcp>(jsonString, SdwanSlaProbeIpv4Ipv4ProbeType.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SdwanSlaProbeIpv4ProbeTypeTcp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SdwanSlaProbeIpv4ProbeTypeTcp: {1}", jsonString, exception.ToString()));
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
            return newSdwanSlaProbeIpv4Ipv4ProbeType;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SdwanSlaProbeIpv4Ipv4ProbeType);
        }

        /// <summary>
        /// Returns true if SdwanSlaProbeIpv4Ipv4ProbeType instances are equal
        /// </summary>
        /// <param name="input">Instance of SdwanSlaProbeIpv4Ipv4ProbeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SdwanSlaProbeIpv4Ipv4ProbeType input)
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
    /// Custom JSON converter for SdwanSlaProbeIpv4Ipv4ProbeType
    /// </summary>
    public class SdwanSlaProbeIpv4Ipv4ProbeTypeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SdwanSlaProbeIpv4Ipv4ProbeType).GetMethod("ToJson").Invoke(value, null)));
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
                return SdwanSlaProbeIpv4Ipv4ProbeType.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
