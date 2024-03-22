/*
 * Journey Orchestration API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 4.30.49
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
using OpenAPIDateConverter = Alterian.JO.Client.OpenAPIDateConverter;

namespace Alterian.JO.Model
{
    /// <summary>
    /// SnoozeReport
    /// </summary>
    [DataContract(Name = "SnoozeReport")]
    public partial class SnoozeReport : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public TargetEnum? Target { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeReport" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="target">target.</param>
        /// <param name="varClient">varClient.</param>
        /// <param name="url">url.</param>
        /// <param name="daysBeforeSnooze">daysBeforeSnooze.</param>
        /// <param name="reason">reason.</param>
        public SnoozeReport(string name = default(string), TargetEnum? target = default(TargetEnum?), string varClient = default(string), string url = default(string), decimal daysBeforeSnooze = default(decimal), List<string> reason = default(List<string>))
        {
            this.Name = name;
            this.Target = target;
            this.VarClient = varClient;
            this.Url = url;
            this.DaysBeforeSnooze = daysBeforeSnooze;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public string VarClient { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets DaysBeforeSnooze
        /// </summary>
        [DataMember(Name = "daysBeforeSnooze", EmitDefaultValue = false)]
        public decimal DaysBeforeSnooze { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public List<string> Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SnoozeReport {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  DaysBeforeSnooze: ").Append(DaysBeforeSnooze).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
