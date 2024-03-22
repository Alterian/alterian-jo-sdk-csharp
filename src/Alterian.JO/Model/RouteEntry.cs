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
    /// RouteEntry
    /// </summary>
    [DataContract(Name = "RouteEntry")]
    public partial class RouteEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteEntry" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="pattern">pattern.</param>
        /// <param name="targetNodes">targetNodes.</param>
        public RouteEntry(string action = default(string), string pattern = default(string), List<string> targetNodes = default(List<string>))
        {
            this.Action = action;
            this.Pattern = pattern;
            this.TargetNodes = targetNodes;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name = "pattern", EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or Sets TargetNodes
        /// </summary>
        [DataMember(Name = "targetNodes", EmitDefaultValue = false)]
        public List<string> TargetNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RouteEntry {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  TargetNodes: ").Append(TargetNodes).Append("\n");
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
