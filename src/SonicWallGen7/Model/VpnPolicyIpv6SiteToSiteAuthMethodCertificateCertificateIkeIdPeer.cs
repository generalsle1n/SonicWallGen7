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
    /// IKE authentication peer identifier.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeerJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv6_site_to_site_auth_method_certificate_certificate_ike_id_peer")]
    public partial class VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName, VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName, VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId, VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName GetVpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId GetVpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName GetVpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp GetVpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer</returns>
        public static VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer FromJson(string jsonString)
        {
            VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDistinguishedName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerDomainName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerEmailId: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer = new VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodCertificateIkeIdPeerIp: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer input)
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
    /// Custom JSON converter for VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer
    /// </summary>
    public class VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv6SiteToSiteAuthMethodCertificateCertificateIkeIdPeer.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
