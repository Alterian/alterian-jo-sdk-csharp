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
    /// TemplateList
    /// </summary>
    [DataContract(Name = "templateList")]
    public partial class TemplateList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateList" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="debug">debug.</param>
        /// <param name="exceptionType">exceptionType.</param>
        /// <param name="message">message.</param>
        /// <param name="status">status.</param>
        /// <param name="data">data.</param>
        public TemplateList(SuccessCursor cursor = default(SuccessCursor), string debug = default(string), string exceptionType = default(string), string message = default(string), string status = default(string), List<TemplateData> data = default(List<TemplateData>))
        {
            this.Cursor = cursor;
            this.Debug = debug;
            this.ExceptionType = exceptionType;
            this.Message = message;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public SuccessCursor Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name = "debug", EmitDefaultValue = false)]
        public string Debug { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionType
        /// </summary>
        [DataMember(Name = "exceptionType", EmitDefaultValue = false)]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<TemplateData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateList {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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