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
    /// TestDataListing
    /// </summary>
    [DataContract(Name = "TestDataListing")]
    public partial class TestDataListing : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public TargetEnum? Target { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDataListing" /> class.
        /// </summary>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="varClient">varClient.</param>
        /// <param name="ruleName">ruleName.</param>
        /// <param name="target">target.</param>
        public TestDataListing(string lastModifiedDate = default(string), string varClient = default(string), string ruleName = default(string), TargetEnum? target = default(TargetEnum?))
        {
            this.LastModifiedDate = lastModifiedDate;
            this.VarClient = varClient;
            this.RuleName = ruleName;
            this.Target = target;
        }

        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public string VarClient { get; set; }

        /// <summary>
        /// Gets or Sets RuleName
        /// </summary>
        [DataMember(Name = "ruleName", EmitDefaultValue = false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestDataListing {\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
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
