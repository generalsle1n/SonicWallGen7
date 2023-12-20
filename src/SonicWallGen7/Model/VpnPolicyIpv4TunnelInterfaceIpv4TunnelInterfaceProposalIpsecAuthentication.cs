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
    /// Authentication hashing encryption algorithm.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_tunnel_interface_ipv4_tunnel_interface_proposal_ipsec_authentication")]
    public partial class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc.</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5 GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1 GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256 GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384 GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512 GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc`. If the actual instance is not `VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc</returns>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc GetVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc()
        {
            return (VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication</returns>
        public static VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication FromJson(string jsonString)
        {
            VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationAesXcbc: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationMd5: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha256: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha384: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication = new VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512>(jsonString, VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationSha512: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication input)
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
    /// Custom JSON converter for VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication
    /// </summary>
    public class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthenticationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.FromJson(JObject.Load(reader).ToString(Formatting.None));
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