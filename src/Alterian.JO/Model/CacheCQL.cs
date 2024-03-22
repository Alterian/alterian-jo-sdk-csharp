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
    /// CacheCQL
    /// </summary>
    [DataContract(Name = "CacheCQL")]
    public partial class CacheCQL : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Consistency
        /// </summary>
        [DataMember(Name = "consistency", EmitDefaultValue = false)]
        public CacheConsistencyLevel? Consistency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheCQL" /> class.
        /// </summary>
        /// <param name="consistency">consistency.</param>
        /// <param name="cql">The insert, select or delete CQL command.</param>
        /// <param name="retries">Number of retries, before giving up.</param>
        public CacheCQL(CacheConsistencyLevel? consistency = default(CacheConsistencyLevel?), string cql = default(string), int retries = default(int))
        {
            this.Consistency = consistency;
            this.Cql = cql;
            this.Retries = retries;
        }

        /// <summary>
        /// The insert, select or delete CQL command
        /// </summary>
        /// <value>The insert, select or delete CQL command</value>
        [DataMember(Name = "cql", EmitDefaultValue = false)]
        public string Cql { get; set; }

        /// <summary>
        /// Number of retries, before giving up
        /// </summary>
        /// <value>Number of retries, before giving up</value>
        [DataMember(Name = "retries", EmitDefaultValue = false)]
        public int Retries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CacheCQL {\n");
            sb.Append("  Consistency: ").Append(Consistency).Append("\n");
            sb.Append("  Cql: ").Append(Cql).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
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
