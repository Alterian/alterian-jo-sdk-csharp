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
    /// LastModified
    /// </summary>
    [DataContract(Name = "lastModified")]
    public partial class LastModified : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastModified" /> class.
        /// </summary>
        /// <param name="lastModifiedDate">When was this object last modified? Timestamp in ISO-8601 format.</param>
        /// <param name="lastModifiedUser">What is the name of the user who last modified this object?.</param>
        public LastModified(string lastModifiedDate = default(string), string lastModifiedUser = default(string))
        {
            this.LastModifiedDate = lastModifiedDate;
            this.LastModifiedUser = lastModifiedUser;
        }

        /// <summary>
        /// When was this object last modified? Timestamp in ISO-8601 format
        /// </summary>
        /// <value>When was this object last modified? Timestamp in ISO-8601 format</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// What is the name of the user who last modified this object?
        /// </summary>
        /// <value>What is the name of the user who last modified this object?</value>
        [DataMember(Name = "lastModifiedUser", EmitDefaultValue = false)]
        public string LastModifiedUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LastModified {\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  LastModifiedUser: ").Append(LastModifiedUser).Append("\n");
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
