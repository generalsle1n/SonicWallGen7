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
    /// Set the tunnel interface type.
    /// </summary>
    [JsonConverter(typeof(TunnelInterfaceIpv6Ipv6TypeJsonConverter))]
    [DataContract(Name = "tunnel_interface_ipv6_ipv6_type")]
    public partial class TunnelInterfaceIpv6Ipv6Type : AbstractOpenAPISchema, IEquatable<TunnelInterfaceIpv6Ipv6Type>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6Ipv6Type" /> class
        /// with the <see cref="TunnelInterfaceIpv6TypeManual" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TunnelInterfaceIpv6TypeManual.</param>
        public TunnelInterfaceIpv6Ipv6Type(TunnelInterfaceIpv6TypeManual actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6Ipv6Type" /> class
        /// with the <see cref="TunnelInterfaceIpv6TypeGre" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TunnelInterfaceIpv6TypeGre.</param>
        public TunnelInterfaceIpv6Ipv6Type(TunnelInterfaceIpv6TypeGre actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6Ipv6Type" /> class
        /// with the <see cref="TunnelInterfaceIpv6Type6to4" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TunnelInterfaceIpv6Type6to4.</param>
        public TunnelInterfaceIpv6Ipv6Type(TunnelInterfaceIpv6Type6to4 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6Ipv6Type" /> class
        /// with the <see cref="TunnelInterfaceIpv6TypeIsatap" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TunnelInterfaceIpv6TypeIsatap.</param>
        public TunnelInterfaceIpv6Ipv6Type(TunnelInterfaceIpv6TypeIsatap actualInstance)
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
                if (value.GetType() == typeof(TunnelInterfaceIpv6Type6to4))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TunnelInterfaceIpv6TypeGre))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TunnelInterfaceIpv6TypeIsatap))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TunnelInterfaceIpv6TypeManual))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: TunnelInterfaceIpv6Type6to4, TunnelInterfaceIpv6TypeGre, TunnelInterfaceIpv6TypeIsatap, TunnelInterfaceIpv6TypeManual");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `TunnelInterfaceIpv6TypeManual`. If the actual instance is not `TunnelInterfaceIpv6TypeManual`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TunnelInterfaceIpv6TypeManual</returns>
        public TunnelInterfaceIpv6TypeManual GetTunnelInterfaceIpv6TypeManual()
        {
            return (TunnelInterfaceIpv6TypeManual)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TunnelInterfaceIpv6TypeGre`. If the actual instance is not `TunnelInterfaceIpv6TypeGre`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TunnelInterfaceIpv6TypeGre</returns>
        public TunnelInterfaceIpv6TypeGre GetTunnelInterfaceIpv6TypeGre()
        {
            return (TunnelInterfaceIpv6TypeGre)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TunnelInterfaceIpv6Type6to4`. If the actual instance is not `TunnelInterfaceIpv6Type6to4`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TunnelInterfaceIpv6Type6to4</returns>
        public TunnelInterfaceIpv6Type6to4 GetTunnelInterfaceIpv6Type6to4()
        {
            return (TunnelInterfaceIpv6Type6to4)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TunnelInterfaceIpv6TypeIsatap`. If the actual instance is not `TunnelInterfaceIpv6TypeIsatap`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TunnelInterfaceIpv6TypeIsatap</returns>
        public TunnelInterfaceIpv6TypeIsatap GetTunnelInterfaceIpv6TypeIsatap()
        {
            return (TunnelInterfaceIpv6TypeIsatap)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TunnelInterfaceIpv6Ipv6Type {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, TunnelInterfaceIpv6Ipv6Type.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of TunnelInterfaceIpv6Ipv6Type
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of TunnelInterfaceIpv6Ipv6Type</returns>
        public static TunnelInterfaceIpv6Ipv6Type FromJson(string jsonString)
        {
            TunnelInterfaceIpv6Ipv6Type newTunnelInterfaceIpv6Ipv6Type = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newTunnelInterfaceIpv6Ipv6Type;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TunnelInterfaceIpv6Type6to4).GetProperty("AdditionalProperties") == null)
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6Type6to4>(jsonString, TunnelInterfaceIpv6Ipv6Type.SerializerSettings));
                }
                else
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6Type6to4>(jsonString, TunnelInterfaceIpv6Ipv6Type.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TunnelInterfaceIpv6Type6to4");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TunnelInterfaceIpv6Type6to4: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TunnelInterfaceIpv6TypeGre).GetProperty("AdditionalProperties") == null)
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeGre>(jsonString, TunnelInterfaceIpv6Ipv6Type.SerializerSettings));
                }
                else
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeGre>(jsonString, TunnelInterfaceIpv6Ipv6Type.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TunnelInterfaceIpv6TypeGre");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TunnelInterfaceIpv6TypeGre: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TunnelInterfaceIpv6TypeIsatap).GetProperty("AdditionalProperties") == null)
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeIsatap>(jsonString, TunnelInterfaceIpv6Ipv6Type.SerializerSettings));
                }
                else
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeIsatap>(jsonString, TunnelInterfaceIpv6Ipv6Type.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TunnelInterfaceIpv6TypeIsatap");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TunnelInterfaceIpv6TypeIsatap: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TunnelInterfaceIpv6TypeManual).GetProperty("AdditionalProperties") == null)
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeManual>(jsonString, TunnelInterfaceIpv6Ipv6Type.SerializerSettings));
                }
                else
                {
                    newTunnelInterfaceIpv6Ipv6Type = new TunnelInterfaceIpv6Ipv6Type(JsonConvert.DeserializeObject<TunnelInterfaceIpv6TypeManual>(jsonString, TunnelInterfaceIpv6Ipv6Type.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TunnelInterfaceIpv6TypeManual");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TunnelInterfaceIpv6TypeManual: {1}", jsonString, exception.ToString()));
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
            return newTunnelInterfaceIpv6Ipv6Type;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TunnelInterfaceIpv6Ipv6Type);
        }

        /// <summary>
        /// Returns true if TunnelInterfaceIpv6Ipv6Type instances are equal
        /// </summary>
        /// <param name="input">Instance of TunnelInterfaceIpv6Ipv6Type to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TunnelInterfaceIpv6Ipv6Type input)
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
    /// Custom JSON converter for TunnelInterfaceIpv6Ipv6Type
    /// </summary>
    public class TunnelInterfaceIpv6Ipv6TypeJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(TunnelInterfaceIpv6Ipv6Type).GetMethod("ToJson").Invoke(value, null)));
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
                return TunnelInterfaceIpv6Ipv6Type.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
