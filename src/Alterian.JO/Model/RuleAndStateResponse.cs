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
    /// RuleAndStateResponse
    /// </summary>
    [DataContract(Name = "RuleAndStateResponse")]
    public partial class RuleAndStateResponse : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public RuleStateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAndStateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleAndStateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAndStateResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="state">state (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        public RuleAndStateResponse(string status = default(string), RuleStateEnum state = default(RuleStateEnum), string url = default(string), string varVersion = default(string), string modifiedDate = default(string))
        {
            this.State = state;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for RuleAndStateResponse and cannot be null");
            }
            this.Url = url;
            this.Status = status;
            this.VarVersion = varVersion;
            this.ModifiedDate = modifiedDate;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleAndStateResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
