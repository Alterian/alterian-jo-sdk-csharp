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
    /// JsonDecoderDetails
    /// </summary>
    [DataContract(Name = "jsonDecoderDetails")]
    public partial class JsonDecoderDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonDecoderDetails" /> class.
        /// </summary>
        /// <param name="expandSizeOneArrays">expandSizeOneArrays.</param>
        /// <param name="fieldToDecode">fieldToDecode.</param>
        /// <param name="stepName">stepName.</param>
        /// <param name="delimiter">delimiter.</param>
        /// <param name="flattenMultipleRows">flattenMultipleRows.</param>
        /// <param name="fields">fields.</param>
        /// <param name="parseAsNameValue">parseAsNameValue.</param>
        public JsonDecoderDetails(bool expandSizeOneArrays = default(bool), string fieldToDecode = default(string), string stepName = default(string), string delimiter = default(string), bool flattenMultipleRows = default(bool), List<JsonDecoderField> fields = default(List<JsonDecoderField>), bool parseAsNameValue = default(bool))
        {
            this.ExpandSizeOneArrays = expandSizeOneArrays;
            this.FieldToDecode = fieldToDecode;
            this.StepName = stepName;
            this.Delimiter = delimiter;
            this.FlattenMultipleRows = flattenMultipleRows;
            this.Fields = fields;
            this.ParseAsNameValue = parseAsNameValue;
        }

        /// <summary>
        /// Gets or Sets ExpandSizeOneArrays
        /// </summary>
        [DataMember(Name = "expandSizeOneArrays", EmitDefaultValue = true)]
        public bool ExpandSizeOneArrays { get; set; }

        /// <summary>
        /// Gets or Sets FieldToDecode
        /// </summary>
        [DataMember(Name = "fieldToDecode", EmitDefaultValue = false)]
        public string FieldToDecode { get; set; }

        /// <summary>
        /// Gets or Sets StepName
        /// </summary>
        [DataMember(Name = "stepName", EmitDefaultValue = false)]
        public string StepName { get; set; }

        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name = "delimiter", EmitDefaultValue = false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or Sets FlattenMultipleRows
        /// </summary>
        [DataMember(Name = "flattenMultipleRows", EmitDefaultValue = true)]
        public bool FlattenMultipleRows { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<JsonDecoderField> Fields { get; set; }

        /// <summary>
        /// Gets or Sets ParseAsNameValue
        /// </summary>
        [DataMember(Name = "parseAsNameValue", EmitDefaultValue = true)]
        public bool ParseAsNameValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JsonDecoderDetails {\n");
            sb.Append("  ExpandSizeOneArrays: ").Append(ExpandSizeOneArrays).Append("\n");
            sb.Append("  FieldToDecode: ").Append(FieldToDecode).Append("\n");
            sb.Append("  StepName: ").Append(StepName).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  FlattenMultipleRows: ").Append(FlattenMultipleRows).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  ParseAsNameValue: ").Append(ParseAsNameValue).Append("\n");
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
