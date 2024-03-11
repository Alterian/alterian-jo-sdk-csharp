/*
 * Journey Orchestration API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 4.29.139
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
    /// QuotaUsageHistory
    /// </summary>
    [DataContract(Name = "quotaUsageHistory")]
    public partial class QuotaUsageHistory : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaUsageHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaUsageHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaUsageHistory" /> class.
        /// </summary>
        /// <param name="quotaused">Quota used (required).</param>
        /// <param name="timestamp">Timestamp of quota usage (required).</param>
        public QuotaUsageHistory(decimal quotaused = default(decimal), DateTime timestamp = default(DateTime))
        {
            this.Quotaused = quotaused;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Quota used
        /// </summary>
        /// <value>Quota used</value>
        [DataMember(Name = "quotaused", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quotaused { get; set; }

        /// <summary>
        /// Timestamp of quota usage
        /// </summary>
        /// <value>Timestamp of quota usage</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotaUsageHistory {\n");
            sb.Append("  Quotaused: ").Append(Quotaused).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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