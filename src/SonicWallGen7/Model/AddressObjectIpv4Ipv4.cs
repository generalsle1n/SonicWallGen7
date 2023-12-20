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
    /// IPV4 adddress object.
    /// </summary>
    [JsonConverter(typeof(AddressObjectIpv4Ipv4JsonConverter))]
    [DataContract(Name = "address_object_ipv4_ipv4")]
    public partial class AddressObjectIpv4Ipv4 : AbstractOpenAPISchema, IEquatable<AddressObjectIpv4Ipv4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressObjectIpv4Ipv4" /> class
        /// with the <see cref="AddressObjectIpv4Host" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressObjectIpv4Host.</param>
        public AddressObjectIpv4Ipv4(AddressObjectIpv4Host actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressObjectIpv4Ipv4" /> class
        /// with the <see cref="AddressObjectIpv4Range" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressObjectIpv4Range.</param>
        public AddressObjectIpv4Ipv4(AddressObjectIpv4Range actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressObjectIpv4Ipv4" /> class
        /// with the <see cref="AddressObjectIpv4Network" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressObjectIpv4Network.</param>
        public AddressObjectIpv4Ipv4(AddressObjectIpv4Network actualInstance)
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
                if (value.GetType() == typeof(AddressObjectIpv4Host))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressObjectIpv4Network))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressObjectIpv4Range))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddressObjectIpv4Host, AddressObjectIpv4Network, AddressObjectIpv4Range");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AddressObjectIpv4Host`. If the actual instance is not `AddressObjectIpv4Host`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressObjectIpv4Host</returns>
        public AddressObjectIpv4Host GetAddressObjectIpv4Host()
        {
            return (AddressObjectIpv4Host)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressObjectIpv4Range`. If the actual instance is not `AddressObjectIpv4Range`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressObjectIpv4Range</returns>
        public AddressObjectIpv4Range GetAddressObjectIpv4Range()
        {
            return (AddressObjectIpv4Range)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressObjectIpv4Network`. If the actual instance is not `AddressObjectIpv4Network`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressObjectIpv4Network</returns>
        public AddressObjectIpv4Network GetAddressObjectIpv4Network()
        {
            return (AddressObjectIpv4Network)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressObjectIpv4Ipv4 {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AddressObjectIpv4Ipv4.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AddressObjectIpv4Ipv4
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AddressObjectIpv4Ipv4</returns>
        public static AddressObjectIpv4Ipv4 FromJson(string jsonString)
        {
            AddressObjectIpv4Ipv4 newAddressObjectIpv4Ipv4 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAddressObjectIpv4Ipv4;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressObjectIpv4Host).GetProperty("AdditionalProperties") == null)
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Host>(jsonString, AddressObjectIpv4Ipv4.SerializerSettings));
                }
                else
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Host>(jsonString, AddressObjectIpv4Ipv4.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressObjectIpv4Host");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressObjectIpv4Host: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressObjectIpv4Network).GetProperty("AdditionalProperties") == null)
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Network>(jsonString, AddressObjectIpv4Ipv4.SerializerSettings));
                }
                else
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Network>(jsonString, AddressObjectIpv4Ipv4.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressObjectIpv4Network");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressObjectIpv4Network: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressObjectIpv4Range).GetProperty("AdditionalProperties") == null)
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Range>(jsonString, AddressObjectIpv4Ipv4.SerializerSettings));
                }
                else
                {
                    newAddressObjectIpv4Ipv4 = new AddressObjectIpv4Ipv4(JsonConvert.DeserializeObject<AddressObjectIpv4Range>(jsonString, AddressObjectIpv4Ipv4.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressObjectIpv4Range");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressObjectIpv4Range: {1}", jsonString, exception.ToString()));
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
            return newAddressObjectIpv4Ipv4;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressObjectIpv4Ipv4);
        }

        /// <summary>
        /// Returns true if AddressObjectIpv4Ipv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressObjectIpv4Ipv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressObjectIpv4Ipv4 input)
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
    /// Custom JSON converter for AddressObjectIpv4Ipv4
    /// </summary>
    public class AddressObjectIpv4Ipv4JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AddressObjectIpv4Ipv4).GetMethod("ToJson").Invoke(value, null)));
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
                return AddressObjectIpv4Ipv4.FromJson(JObject.Load(reader).ToString(Formatting.None));
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