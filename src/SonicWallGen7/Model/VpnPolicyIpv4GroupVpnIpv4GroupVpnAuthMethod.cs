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
    /// Authentication method.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_group_vpn_ipv4_group_vpn_auth_method")]
    public partial class VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret GetVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate GetVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod</returns>
        public static VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod FromJson(string jsonString)
        {
            VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod = new VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod = new VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodCertificate: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod = new VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod = new VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodSharedSecret: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod input)
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
    /// Custom JSON converter for VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod
    /// </summary>
    public class VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethodJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
