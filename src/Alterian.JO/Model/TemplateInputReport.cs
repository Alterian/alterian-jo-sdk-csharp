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
    /// TemplateInputReport
    /// </summary>
    [DataContract(Name = "TemplateInputReport")]
    public partial class TemplateInputReport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateInputReport" /> class.
        /// </summary>
        /// <param name="templateUrl">templateUrl.</param>
        /// <param name="inputFields">inputFields.</param>
        public TemplateInputReport(string templateUrl = default(string), List<string> inputFields = default(List<string>))
        {
            this.TemplateUrl = templateUrl;
            this.InputFields = inputFields;
        }

        /// <summary>
        /// Gets or Sets TemplateUrl
        /// </summary>
        [DataMember(Name = "templateUrl", EmitDefaultValue = false)]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Gets or Sets InputFields
        /// </summary>
        [DataMember(Name = "inputFields", EmitDefaultValue = false)]
        public List<string> InputFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateInputReport {\n");
            sb.Append("  TemplateUrl: ").Append(TemplateUrl).Append("\n");
            sb.Append("  InputFields: ").Append(InputFields).Append("\n");
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