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
    /// TestDataItem
    /// </summary>
    [DataContract(Name = "TestDataItem")]
    public partial class TestDataItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDataItem" /> class.
        /// </summary>
        /// <param name="testData">testData.</param>
        /// <param name="stepType">stepType.</param>
        public TestDataItem(List<TestData> testData = default(List<TestData>), string stepType = default(string))
        {
            this.TestData = testData;
            this.StepType = stepType;
        }

        /// <summary>
        /// Gets or Sets TestData
        /// </summary>
        [DataMember(Name = "testData", EmitDefaultValue = false)]
        public List<TestData> TestData { get; set; }

        /// <summary>
        /// Gets or Sets StepType
        /// </summary>
        [DataMember(Name = "stepType", EmitDefaultValue = false)]
        public string StepType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestDataItem {\n");
            sb.Append("  TestData: ").Append(TestData).Append("\n");
            sb.Append("  StepType: ").Append(StepType).Append("\n");
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
