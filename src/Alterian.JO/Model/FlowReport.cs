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
    /// FlowReport
    /// </summary>
    [DataContract(Name = "FlowReport")]
    public partial class FlowReport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowReport" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="position">position.</param>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        /// <param name="sourcePosition">sourcePosition.</param>
        /// <param name="targetPosition">targetPosition.</param>
        /// <param name="markerEnd">markerEnd.</param>
        /// <param name="source">source.</param>
        /// <param name="type">type.</param>
        /// <param name="varClass">varClass.</param>
        /// <param name="target">target.</param>
        public FlowReport(string id = default(string), string label = default(string), Position position = default(Position), int height = default(int), int width = default(int), string sourcePosition = default(string), string targetPosition = default(string), string markerEnd = default(string), string source = default(string), string type = default(string), string varClass = default(string), string target = default(string))
        {
            this.Id = id;
            this.Label = label;
            this.Position = position;
            this.Height = height;
            this.Width = width;
            this.SourcePosition = sourcePosition;
            this.TargetPosition = targetPosition;
            this.MarkerEnd = markerEnd;
            this.Source = source;
            this.Type = type;
            this.VarClass = varClass;
            this.Target = target;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public Position Position { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets SourcePosition
        /// </summary>
        [DataMember(Name = "sourcePosition", EmitDefaultValue = false)]
        public string SourcePosition { get; set; }

        /// <summary>
        /// Gets or Sets TargetPosition
        /// </summary>
        [DataMember(Name = "targetPosition", EmitDefaultValue = false)]
        public string TargetPosition { get; set; }

        /// <summary>
        /// Gets or Sets MarkerEnd
        /// </summary>
        [DataMember(Name = "markerEnd", EmitDefaultValue = false)]
        public string MarkerEnd { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets VarClass
        /// </summary>
        [DataMember(Name = "class", EmitDefaultValue = false)]
        public string VarClass { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlowReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  SourcePosition: ").Append(SourcePosition).Append("\n");
            sb.Append("  TargetPosition: ").Append(TargetPosition).Append("\n");
            sb.Append("  MarkerEnd: ").Append(MarkerEnd).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarClass: ").Append(VarClass).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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