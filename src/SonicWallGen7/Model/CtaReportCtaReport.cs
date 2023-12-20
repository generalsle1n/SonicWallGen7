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

namespace SonicWallGen7.Model
{
    /// <summary>
    /// Exporting cta-report.
    /// </summary>
    [DataContract(Name = "cta_report_cta_report")]
    public partial class CtaReportCtaReport : IEquatable<CtaReportCtaReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CtaReportCtaReport" /> class.
        /// </summary>
        /// <param name="locale">locale.</param>
        /// <param name="style">style.</param>
        /// <param name="snce"> * Set to null to represent an unconfigured state..</param>
        /// <param name="report">Report title * Set to null to represent an unconfigured state..</param>
        /// <param name="txt">About text * Set to null to represent an unconfigured state..</param>
        /// <param name="compName">Company name * Set to null to represent an unconfigured state..</param>
        /// <param name="prprName">Preparer name * Set to null to represent an unconfigured state..</param>
        /// <param name="phn">phone contact * Set to null to represent an unconfigured state..</param>
        /// <param name="mail">Email contact * Set to null to represent an unconfigured state..</param>
        /// <param name="execOnly">Executive summary only * Set to null to represent an unconfigured state..</param>
        /// <param name="appHlts">Application highlights * Set to null to represent an unconfigured state..</param>
        /// <param name="thrts">Glimpse of the threats * Set to null to represent an unconfigured state..</param>
        /// <param name="btnt">Botnet analysis * Set to null to represent an unconfigured state..</param>
        /// <param name="usrSesn">Top users by sessions * Set to null to represent an unconfigured state..</param>
        /// <param name="rskApp">Risk Applications * Set to null to represent an unconfigured state..</param>
        /// <param name="mlwr">Malware analysis * Set to null to represent an unconfigured state..</param>
        /// <param name="cntrTrfc">Top countries by traffic * Set to null to represent an unconfigured state..</param>
        /// <param name="usrTrfc">Top users by traffic * Set to null to represent an unconfigured state..</param>
        /// <param name="wbAct">Web activity * Set to null to represent an unconfigured state..</param>
        /// <param name="explts">Exploits Used * Set to null to represent an unconfigured state..</param>
        /// <param name="ipSesn">Top IPs by sessions * Set to null to represent an unconfigured state..</param>
        /// <param name="rprtCnf">Report configuration * Set to null to represent an unconfigured state..</param>
        /// <param name="fleTrnsfr">File transfer investigation * Set to null to represent an unconfigured state..</param>
        /// <param name="knUnkMlwr">Known and unknown malware * Set to null to represent an unconfigured state..</param>
        /// <param name="ipTrafc">Top IPs by traffic * Set to null to represent an unconfigured state..</param>
        /// <param name="logo">Top IPs by traffic * Set to null to represent an unconfigured state..</param>
        public CtaReportCtaReport(string locale = default(string), string style = default(string), decimal? snce = default(decimal?), string report = default(string), string txt = default(string), string compName = default(string), string prprName = default(string), string phn = default(string), string mail = default(string), decimal? execOnly = default(decimal?), decimal? appHlts = default(decimal?), decimal? thrts = default(decimal?), decimal? btnt = default(decimal?), decimal? usrSesn = default(decimal?), decimal? rskApp = default(decimal?), decimal? mlwr = default(decimal?), decimal? cntrTrfc = default(decimal?), decimal? usrTrfc = default(decimal?), decimal? wbAct = default(decimal?), decimal? explts = default(decimal?), decimal? ipSesn = default(decimal?), decimal? rprtCnf = default(decimal?), decimal? fleTrnsfr = default(decimal?), decimal? knUnkMlwr = default(decimal?), decimal? ipTrafc = default(decimal?), string logo = default(string))
        {
            this.Locale = locale;
            this.Style = style;
            this.Snce = snce;
            this.Report = report;
            this.Txt = txt;
            this.CompName = compName;
            this.PrprName = prprName;
            this.Phn = phn;
            this.Mail = mail;
            this.ExecOnly = execOnly;
            this.AppHlts = appHlts;
            this.Thrts = thrts;
            this.Btnt = btnt;
            this.UsrSesn = usrSesn;
            this.RskApp = rskApp;
            this.Mlwr = mlwr;
            this.CntrTrfc = cntrTrfc;
            this.UsrTrfc = usrTrfc;
            this.WbAct = wbAct;
            this.Explts = explts;
            this.IpSesn = ipSesn;
            this.RprtCnf = rprtCnf;
            this.FleTrnsfr = fleTrnsfr;
            this.KnUnkMlwr = knUnkMlwr;
            this.IpTrafc = ipTrafc;
            this.Logo = logo;
        }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Style
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false)]
        public string Style { get; set; }

        /// <summary>
        ///  * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value> * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "snce", EmitDefaultValue = true)]
        public decimal? Snce { get; set; }

        /// <summary>
        /// Report title * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Report title * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "report", EmitDefaultValue = true)]
        public string Report { get; set; }

        /// <summary>
        /// About text * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>About text * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "txt", EmitDefaultValue = true)]
        public string Txt { get; set; }

        /// <summary>
        /// Company name * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Company name * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "comp_name", EmitDefaultValue = true)]
        public string CompName { get; set; }

        /// <summary>
        /// Preparer name * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Preparer name * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "prpr_name", EmitDefaultValue = true)]
        public string PrprName { get; set; }

        /// <summary>
        /// phone contact * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>phone contact * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "phn", EmitDefaultValue = true)]
        public string Phn { get; set; }

        /// <summary>
        /// Email contact * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Email contact * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "mail", EmitDefaultValue = true)]
        public string Mail { get; set; }

        /// <summary>
        /// Executive summary only * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Executive summary only * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "exec_only", EmitDefaultValue = true)]
        public decimal? ExecOnly { get; set; }

        /// <summary>
        /// Application highlights * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Application highlights * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "app_hlts", EmitDefaultValue = true)]
        public decimal? AppHlts { get; set; }

        /// <summary>
        /// Glimpse of the threats * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Glimpse of the threats * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "thrts", EmitDefaultValue = true)]
        public decimal? Thrts { get; set; }

        /// <summary>
        /// Botnet analysis * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Botnet analysis * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "btnt", EmitDefaultValue = true)]
        public decimal? Btnt { get; set; }

        /// <summary>
        /// Top users by sessions * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top users by sessions * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "usr_sesn", EmitDefaultValue = true)]
        public decimal? UsrSesn { get; set; }

        /// <summary>
        /// Risk Applications * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Risk Applications * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "rsk_app", EmitDefaultValue = true)]
        public decimal? RskApp { get; set; }

        /// <summary>
        /// Malware analysis * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Malware analysis * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "mlwr", EmitDefaultValue = true)]
        public decimal? Mlwr { get; set; }

        /// <summary>
        /// Top countries by traffic * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top countries by traffic * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "cntr_trfc", EmitDefaultValue = true)]
        public decimal? CntrTrfc { get; set; }

        /// <summary>
        /// Top users by traffic * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top users by traffic * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "usr_trfc", EmitDefaultValue = true)]
        public decimal? UsrTrfc { get; set; }

        /// <summary>
        /// Web activity * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Web activity * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "wb_act", EmitDefaultValue = true)]
        public decimal? WbAct { get; set; }

        /// <summary>
        /// Exploits Used * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Exploits Used * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "explts", EmitDefaultValue = true)]
        public decimal? Explts { get; set; }

        /// <summary>
        /// Top IPs by sessions * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top IPs by sessions * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "ip_sesn", EmitDefaultValue = true)]
        public decimal? IpSesn { get; set; }

        /// <summary>
        /// Report configuration * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Report configuration * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "rprt_cnf", EmitDefaultValue = true)]
        public decimal? RprtCnf { get; set; }

        /// <summary>
        /// File transfer investigation * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>File transfer investigation * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "fle_trnsfr", EmitDefaultValue = true)]
        public decimal? FleTrnsfr { get; set; }

        /// <summary>
        /// Known and unknown malware * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Known and unknown malware * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "kn_unk_mlwr", EmitDefaultValue = true)]
        public decimal? KnUnkMlwr { get; set; }

        /// <summary>
        /// Top IPs by traffic * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top IPs by traffic * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "ip_trafc", EmitDefaultValue = true)]
        public decimal? IpTrafc { get; set; }

        /// <summary>
        /// Top IPs by traffic * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Top IPs by traffic * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CtaReportCtaReport {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  Snce: ").Append(Snce).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Txt: ").Append(Txt).Append("\n");
            sb.Append("  CompName: ").Append(CompName).Append("\n");
            sb.Append("  PrprName: ").Append(PrprName).Append("\n");
            sb.Append("  Phn: ").Append(Phn).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  ExecOnly: ").Append(ExecOnly).Append("\n");
            sb.Append("  AppHlts: ").Append(AppHlts).Append("\n");
            sb.Append("  Thrts: ").Append(Thrts).Append("\n");
            sb.Append("  Btnt: ").Append(Btnt).Append("\n");
            sb.Append("  UsrSesn: ").Append(UsrSesn).Append("\n");
            sb.Append("  RskApp: ").Append(RskApp).Append("\n");
            sb.Append("  Mlwr: ").Append(Mlwr).Append("\n");
            sb.Append("  CntrTrfc: ").Append(CntrTrfc).Append("\n");
            sb.Append("  UsrTrfc: ").Append(UsrTrfc).Append("\n");
            sb.Append("  WbAct: ").Append(WbAct).Append("\n");
            sb.Append("  Explts: ").Append(Explts).Append("\n");
            sb.Append("  IpSesn: ").Append(IpSesn).Append("\n");
            sb.Append("  RprtCnf: ").Append(RprtCnf).Append("\n");
            sb.Append("  FleTrnsfr: ").Append(FleTrnsfr).Append("\n");
            sb.Append("  KnUnkMlwr: ").Append(KnUnkMlwr).Append("\n");
            sb.Append("  IpTrafc: ").Append(IpTrafc).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CtaReportCtaReport);
        }

        /// <summary>
        /// Returns true if CtaReportCtaReport instances are equal
        /// </summary>
        /// <param name="input">Instance of CtaReportCtaReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CtaReportCtaReport input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
                ) && 
                (
                    this.Snce == input.Snce ||
                    (this.Snce != null &&
                    this.Snce.Equals(input.Snce))
                ) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && 
                (
                    this.Txt == input.Txt ||
                    (this.Txt != null &&
                    this.Txt.Equals(input.Txt))
                ) && 
                (
                    this.CompName == input.CompName ||
                    (this.CompName != null &&
                    this.CompName.Equals(input.CompName))
                ) && 
                (
                    this.PrprName == input.PrprName ||
                    (this.PrprName != null &&
                    this.PrprName.Equals(input.PrprName))
                ) && 
                (
                    this.Phn == input.Phn ||
                    (this.Phn != null &&
                    this.Phn.Equals(input.Phn))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.ExecOnly == input.ExecOnly ||
                    (this.ExecOnly != null &&
                    this.ExecOnly.Equals(input.ExecOnly))
                ) && 
                (
                    this.AppHlts == input.AppHlts ||
                    (this.AppHlts != null &&
                    this.AppHlts.Equals(input.AppHlts))
                ) && 
                (
                    this.Thrts == input.Thrts ||
                    (this.Thrts != null &&
                    this.Thrts.Equals(input.Thrts))
                ) && 
                (
                    this.Btnt == input.Btnt ||
                    (this.Btnt != null &&
                    this.Btnt.Equals(input.Btnt))
                ) && 
                (
                    this.UsrSesn == input.UsrSesn ||
                    (this.UsrSesn != null &&
                    this.UsrSesn.Equals(input.UsrSesn))
                ) && 
                (
                    this.RskApp == input.RskApp ||
                    (this.RskApp != null &&
                    this.RskApp.Equals(input.RskApp))
                ) && 
                (
                    this.Mlwr == input.Mlwr ||
                    (this.Mlwr != null &&
                    this.Mlwr.Equals(input.Mlwr))
                ) && 
                (
                    this.CntrTrfc == input.CntrTrfc ||
                    (this.CntrTrfc != null &&
                    this.CntrTrfc.Equals(input.CntrTrfc))
                ) && 
                (
                    this.UsrTrfc == input.UsrTrfc ||
                    (this.UsrTrfc != null &&
                    this.UsrTrfc.Equals(input.UsrTrfc))
                ) && 
                (
                    this.WbAct == input.WbAct ||
                    (this.WbAct != null &&
                    this.WbAct.Equals(input.WbAct))
                ) && 
                (
                    this.Explts == input.Explts ||
                    (this.Explts != null &&
                    this.Explts.Equals(input.Explts))
                ) && 
                (
                    this.IpSesn == input.IpSesn ||
                    (this.IpSesn != null &&
                    this.IpSesn.Equals(input.IpSesn))
                ) && 
                (
                    this.RprtCnf == input.RprtCnf ||
                    (this.RprtCnf != null &&
                    this.RprtCnf.Equals(input.RprtCnf))
                ) && 
                (
                    this.FleTrnsfr == input.FleTrnsfr ||
                    (this.FleTrnsfr != null &&
                    this.FleTrnsfr.Equals(input.FleTrnsfr))
                ) && 
                (
                    this.KnUnkMlwr == input.KnUnkMlwr ||
                    (this.KnUnkMlwr != null &&
                    this.KnUnkMlwr.Equals(input.KnUnkMlwr))
                ) && 
                (
                    this.IpTrafc == input.IpTrafc ||
                    (this.IpTrafc != null &&
                    this.IpTrafc.Equals(input.IpTrafc))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                );
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
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                if (this.Style != null)
                {
                    hashCode = (hashCode * 59) + this.Style.GetHashCode();
                }
                if (this.Snce != null)
                {
                    hashCode = (hashCode * 59) + this.Snce.GetHashCode();
                }
                if (this.Report != null)
                {
                    hashCode = (hashCode * 59) + this.Report.GetHashCode();
                }
                if (this.Txt != null)
                {
                    hashCode = (hashCode * 59) + this.Txt.GetHashCode();
                }
                if (this.CompName != null)
                {
                    hashCode = (hashCode * 59) + this.CompName.GetHashCode();
                }
                if (this.PrprName != null)
                {
                    hashCode = (hashCode * 59) + this.PrprName.GetHashCode();
                }
                if (this.Phn != null)
                {
                    hashCode = (hashCode * 59) + this.Phn.GetHashCode();
                }
                if (this.Mail != null)
                {
                    hashCode = (hashCode * 59) + this.Mail.GetHashCode();
                }
                if (this.ExecOnly != null)
                {
                    hashCode = (hashCode * 59) + this.ExecOnly.GetHashCode();
                }
                if (this.AppHlts != null)
                {
                    hashCode = (hashCode * 59) + this.AppHlts.GetHashCode();
                }
                if (this.Thrts != null)
                {
                    hashCode = (hashCode * 59) + this.Thrts.GetHashCode();
                }
                if (this.Btnt != null)
                {
                    hashCode = (hashCode * 59) + this.Btnt.GetHashCode();
                }
                if (this.UsrSesn != null)
                {
                    hashCode = (hashCode * 59) + this.UsrSesn.GetHashCode();
                }
                if (this.RskApp != null)
                {
                    hashCode = (hashCode * 59) + this.RskApp.GetHashCode();
                }
                if (this.Mlwr != null)
                {
                    hashCode = (hashCode * 59) + this.Mlwr.GetHashCode();
                }
                if (this.CntrTrfc != null)
                {
                    hashCode = (hashCode * 59) + this.CntrTrfc.GetHashCode();
                }
                if (this.UsrTrfc != null)
                {
                    hashCode = (hashCode * 59) + this.UsrTrfc.GetHashCode();
                }
                if (this.WbAct != null)
                {
                    hashCode = (hashCode * 59) + this.WbAct.GetHashCode();
                }
                if (this.Explts != null)
                {
                    hashCode = (hashCode * 59) + this.Explts.GetHashCode();
                }
                if (this.IpSesn != null)
                {
                    hashCode = (hashCode * 59) + this.IpSesn.GetHashCode();
                }
                if (this.RprtCnf != null)
                {
                    hashCode = (hashCode * 59) + this.RprtCnf.GetHashCode();
                }
                if (this.FleTrnsfr != null)
                {
                    hashCode = (hashCode * 59) + this.FleTrnsfr.GetHashCode();
                }
                if (this.KnUnkMlwr != null)
                {
                    hashCode = (hashCode * 59) + this.KnUnkMlwr.GetHashCode();
                }
                if (this.IpTrafc != null)
                {
                    hashCode = (hashCode * 59) + this.IpTrafc.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
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

}