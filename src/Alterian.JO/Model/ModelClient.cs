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
    /// ModelClient
    /// </summary>
    [DataContract(Name = "varClient")]
    public partial class ModelClient : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelClient" /> class.
        /// </summary>
        /// <param name="defaultCacheDuration">When you add a new table to the cache, this is the default (in seconds) for how long data will say in   that table if it has not been written recently..</param>
        public ModelClient(int defaultCacheDuration = default(int))
        {
            this.DefaultCacheDuration = defaultCacheDuration;
        }

        /// <summary>
        /// When you add a new table to the cache, this is the default (in seconds) for how long data will say in   that table if it has not been written recently.
        /// </summary>
        /// <value>When you add a new table to the cache, this is the default (in seconds) for how long data will say in   that table if it has not been written recently.</value>
        [DataMember(Name = "defaultCacheDuration", EmitDefaultValue = false)]
        public int DefaultCacheDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelClient {\n");
            sb.Append("  DefaultCacheDuration: ").Append(DefaultCacheDuration).Append("\n");
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