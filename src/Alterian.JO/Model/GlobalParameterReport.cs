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
    /// GlobalParameterReport
    /// </summary>
    [DataContract(Name = "GlobalParameterReport")]
    public partial class GlobalParameterReport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalParameterReport" /> class.
        /// </summary>
        /// <param name="varClient">varClient.</param>
        /// <param name="paramName">paramName.</param>
        /// <param name="paramValue">paramValue.</param>
        /// <param name="rules">rules.</param>
        /// <param name="globalParam">globalParam.</param>
        public GlobalParameterReport(string varClient = default(string), string paramName = default(string), string paramValue = default(string), List<string> rules = default(List<string>), bool globalParam = default(bool))
        {
            this.VarClient = varClient;
            this.ParamName = paramName;
            this.ParamValue = paramValue;
            this.Rules = rules;
            this.GlobalParam = globalParam;
        }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "Client", EmitDefaultValue = false)]
        public string VarClient { get; set; }

        /// <summary>
        /// Gets or Sets ParamName
        /// </summary>
        [DataMember(Name = "ParamName", EmitDefaultValue = false)]
        public string ParamName { get; set; }

        /// <summary>
        /// Gets or Sets ParamValue
        /// </summary>
        [DataMember(Name = "ParamValue", EmitDefaultValue = false)]
        public string ParamValue { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "Rules", EmitDefaultValue = false)]
        public List<string> Rules { get; set; }

        /// <summary>
        /// Gets or Sets GlobalParam
        /// </summary>
        [DataMember(Name = "globalParam", EmitDefaultValue = true)]
        public bool GlobalParam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GlobalParameterReport {\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  ParamName: ").Append(ParamName).Append("\n");
            sb.Append("  ParamValue: ").Append(ParamValue).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  GlobalParam: ").Append(GlobalParam).Append("\n");
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