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
    /// RealtimeInputStepDetails
    /// </summary>
    [DataContract(Name = "RealtimeInputStepDetails")]
    public partial class RealtimeInputStepDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputStepDetails" /> class.
        /// </summary>
        /// <param name="headers">headers.</param>
        /// <param name="repeatTestData">repeatTestData.</param>
        /// <param name="timeoutHttpCode">timeoutHttpCode.</param>
        /// <param name="defaultResponseContentType">defaultResponseContentType.</param>
        /// <param name="overflowProtection">overflowProtection.</param>
        /// <param name="defaultHttpCode">defaultHttpCode.</param>
        /// <param name="stepName">stepName.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="useTestData">useTestData.</param>
        /// <param name="timeoutValue">timeoutValue.</param>
        /// <param name="timeoutMilliseconds">timeoutMilliseconds.</param>
        /// <param name="priority">priority.</param>
        /// <param name="requestContentType">requestContentType.</param>
        public RealtimeInputStepDetails(List<RealtimeInputStepHeader> headers = default(List<RealtimeInputStepHeader>), bool repeatTestData = default(bool), string timeoutHttpCode = default(string), string defaultResponseContentType = default(string), bool overflowProtection = default(bool), string defaultHttpCode = default(string), string stepName = default(string), string defaultValue = default(string), bool useTestData = default(bool), string timeoutValue = default(string), string timeoutMilliseconds = default(string), string priority = default(string), string requestContentType = default(string))
        {
            this.Headers = headers;
            this.RepeatTestData = repeatTestData;
            this.TimeoutHttpCode = timeoutHttpCode;
            this.DefaultResponseContentType = defaultResponseContentType;
            this.OverflowProtection = overflowProtection;
            this.DefaultHttpCode = defaultHttpCode;
            this.StepName = stepName;
            this.DefaultValue = defaultValue;
            this.UseTestData = useTestData;
            this.TimeoutValue = timeoutValue;
            this.TimeoutMilliseconds = timeoutMilliseconds;
            this.Priority = priority;
            this.RequestContentType = requestContentType;
        }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public List<RealtimeInputStepHeader> Headers { get; set; }

        /// <summary>
        /// Gets or Sets RepeatTestData
        /// </summary>
        [DataMember(Name = "repeatTestData", EmitDefaultValue = true)]
        public bool RepeatTestData { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutHttpCode
        /// </summary>
        [DataMember(Name = "timeoutHttpCode", EmitDefaultValue = false)]
        public string TimeoutHttpCode { get; set; }

        /// <summary>
        /// Gets or Sets DefaultResponseContentType
        /// </summary>
        [DataMember(Name = "defaultResponseContentType", EmitDefaultValue = false)]
        public string DefaultResponseContentType { get; set; }

        /// <summary>
        /// Gets or Sets OverflowProtection
        /// </summary>
        [DataMember(Name = "overflowProtection", EmitDefaultValue = true)]
        public bool OverflowProtection { get; set; }

        /// <summary>
        /// Gets or Sets DefaultHttpCode
        /// </summary>
        [DataMember(Name = "defaultHttpCode", EmitDefaultValue = false)]
        public string DefaultHttpCode { get; set; }

        /// <summary>
        /// Gets or Sets StepName
        /// </summary>
        [DataMember(Name = "stepName", EmitDefaultValue = false)]
        public string StepName { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets UseTestData
        /// </summary>
        [DataMember(Name = "useTestData", EmitDefaultValue = true)]
        public bool UseTestData { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutValue
        /// </summary>
        [DataMember(Name = "timeoutValue", EmitDefaultValue = false)]
        public string TimeoutValue { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutMilliseconds
        /// </summary>
        [DataMember(Name = "timeoutMilliseconds", EmitDefaultValue = false)]
        public string TimeoutMilliseconds { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets RequestContentType
        /// </summary>
        [DataMember(Name = "requestContentType", EmitDefaultValue = false)]
        public string RequestContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RealtimeInputStepDetails {\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  RepeatTestData: ").Append(RepeatTestData).Append("\n");
            sb.Append("  TimeoutHttpCode: ").Append(TimeoutHttpCode).Append("\n");
            sb.Append("  DefaultResponseContentType: ").Append(DefaultResponseContentType).Append("\n");
            sb.Append("  OverflowProtection: ").Append(OverflowProtection).Append("\n");
            sb.Append("  DefaultHttpCode: ").Append(DefaultHttpCode).Append("\n");
            sb.Append("  StepName: ").Append(StepName).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  UseTestData: ").Append(UseTestData).Append("\n");
            sb.Append("  TimeoutValue: ").Append(TimeoutValue).Append("\n");
            sb.Append("  TimeoutMilliseconds: ").Append(TimeoutMilliseconds).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  RequestContentType: ").Append(RequestContentType).Append("\n");
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
