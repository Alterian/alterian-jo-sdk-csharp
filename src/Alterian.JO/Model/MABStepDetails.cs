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
    /// MABStepDetails
    /// </summary>
    [DataContract(Name = "MABStepDetails")]
    public partial class MABStepDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MABStepDetails" /> class.
        /// </summary>
        /// <param name="field">field.</param>
        /// <param name="fieldKey">fieldKey.</param>
        /// <param name="parameterKey">parameterKey.</param>
        /// <param name="parameterExperimentationFrequency">parameterExperimentationFrequency.</param>
        /// <param name="parameterMabMode">parameterMabMode.</param>
        /// <param name="parameterStatisticalSignificance">parameterStatisticalSignificance.</param>
        /// <param name="parameterTable">parameterTable.</param>
        /// <param name="reportingFields">reportingFields.</param>
        /// <param name="seed">seed.</param>
        /// <param name="staticMabMode">staticMabMode.</param>
        /// <param name="staticExperimentationFrequency">staticExperimentationFrequency.</param>
        /// <param name="staticKey">staticKey.</param>
        /// <param name="staticStatisticalSignificance">staticStatisticalSignificance.</param>
        /// <param name="staticTable">staticTable.</param>
        /// <param name="stepName">stepName.</param>
        /// <param name="variants">variants.</param>
        public MABStepDetails(string field = default(string), string fieldKey = default(string), string parameterKey = default(string), string parameterExperimentationFrequency = default(string), string parameterMabMode = default(string), string parameterStatisticalSignificance = default(string), string parameterTable = default(string), bool reportingFields = default(bool), int seed = default(int), string staticMabMode = default(string), int staticExperimentationFrequency = default(int), string staticKey = default(string), string staticStatisticalSignificance = default(string), string staticTable = default(string), string stepName = default(string), List<MABVariant> variants = default(List<MABVariant>))
        {
            this.Field = field;
            this.FieldKey = fieldKey;
            this.ParameterKey = parameterKey;
            this.ParameterExperimentationFrequency = parameterExperimentationFrequency;
            this.ParameterMabMode = parameterMabMode;
            this.ParameterStatisticalSignificance = parameterStatisticalSignificance;
            this.ParameterTable = parameterTable;
            this.ReportingFields = reportingFields;
            this.Seed = seed;
            this.StaticMabMode = staticMabMode;
            this.StaticExperimentationFrequency = staticExperimentationFrequency;
            this.StaticKey = staticKey;
            this.StaticStatisticalSignificance = staticStatisticalSignificance;
            this.StaticTable = staticTable;
            this.StepName = stepName;
            this.Variants = variants;
        }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets FieldKey
        /// </summary>
        [DataMember(Name = "fieldKey", EmitDefaultValue = false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// Gets or Sets ParameterKey
        /// </summary>
        [DataMember(Name = "parameterKey", EmitDefaultValue = false)]
        public string ParameterKey { get; set; }

        /// <summary>
        /// Gets or Sets ParameterExperimentationFrequency
        /// </summary>
        [DataMember(Name = "parameterExperimentationFrequency", EmitDefaultValue = false)]
        public string ParameterExperimentationFrequency { get; set; }

        /// <summary>
        /// Gets or Sets ParameterMabMode
        /// </summary>
        [DataMember(Name = "parameterMabMode", EmitDefaultValue = false)]
        public string ParameterMabMode { get; set; }

        /// <summary>
        /// Gets or Sets ParameterStatisticalSignificance
        /// </summary>
        [DataMember(Name = "parameterStatisticalSignificance", EmitDefaultValue = false)]
        public string ParameterStatisticalSignificance { get; set; }

        /// <summary>
        /// Gets or Sets ParameterTable
        /// </summary>
        [DataMember(Name = "parameterTable", EmitDefaultValue = false)]
        public string ParameterTable { get; set; }

        /// <summary>
        /// Gets or Sets ReportingFields
        /// </summary>
        [DataMember(Name = "reportingFields", EmitDefaultValue = true)]
        public bool ReportingFields { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public int Seed { get; set; }

        /// <summary>
        /// Gets or Sets StaticMabMode
        /// </summary>
        [DataMember(Name = "staticMabMode", EmitDefaultValue = false)]
        public string StaticMabMode { get; set; }

        /// <summary>
        /// Gets or Sets StaticExperimentationFrequency
        /// </summary>
        [DataMember(Name = "staticExperimentationFrequency", EmitDefaultValue = false)]
        public int StaticExperimentationFrequency { get; set; }

        /// <summary>
        /// Gets or Sets StaticKey
        /// </summary>
        [DataMember(Name = "staticKey", EmitDefaultValue = false)]
        public string StaticKey { get; set; }

        /// <summary>
        /// Gets or Sets StaticStatisticalSignificance
        /// </summary>
        [DataMember(Name = "staticStatisticalSignificance", EmitDefaultValue = false)]
        public string StaticStatisticalSignificance { get; set; }

        /// <summary>
        /// Gets or Sets StaticTable
        /// </summary>
        [DataMember(Name = "staticTable", EmitDefaultValue = false)]
        public string StaticTable { get; set; }

        /// <summary>
        /// Gets or Sets StepName
        /// </summary>
        [DataMember(Name = "stepName", EmitDefaultValue = false)]
        public string StepName { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public List<MABVariant> Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MABStepDetails {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  FieldKey: ").Append(FieldKey).Append("\n");
            sb.Append("  ParameterKey: ").Append(ParameterKey).Append("\n");
            sb.Append("  ParameterExperimentationFrequency: ").Append(ParameterExperimentationFrequency).Append("\n");
            sb.Append("  ParameterMabMode: ").Append(ParameterMabMode).Append("\n");
            sb.Append("  ParameterStatisticalSignificance: ").Append(ParameterStatisticalSignificance).Append("\n");
            sb.Append("  ParameterTable: ").Append(ParameterTable).Append("\n");
            sb.Append("  ReportingFields: ").Append(ReportingFields).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  StaticMabMode: ").Append(StaticMabMode).Append("\n");
            sb.Append("  StaticExperimentationFrequency: ").Append(StaticExperimentationFrequency).Append("\n");
            sb.Append("  StaticKey: ").Append(StaticKey).Append("\n");
            sb.Append("  StaticStatisticalSignificance: ").Append(StaticStatisticalSignificance).Append("\n");
            sb.Append("  StaticTable: ").Append(StaticTable).Append("\n");
            sb.Append("  StepName: ").Append(StepName).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
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
